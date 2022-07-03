using Rc.XingApiClientNet.Entities;
using Rc.XingApiClientNet.Exceptions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rc.XingApiClientNet;

public partial class XingApiClient : IXingClient
{
    private static class TypeCache<T> where T : BaseEntity
    {
        public static readonly string EntityName = (string)typeof(T).GetProperty("EntityName").GetValue(new Event());
    }

    protected HttpClient HttpClient;

    public XingApiClient(string apiKey)
    {
        HttpClient = new HttpClient()
        {
            BaseAddress = XingClientConsts.GetBaseUri(),
        };

        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("ApiKey", apiKey);
    }

    /// <summary>
    /// BaseUrl and "Authorization: ApiKey {KEY}" must be set
    /// </summary>
    /// <param name="httpClient"></param>
    public XingApiClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public Task<FindResponse> FindAsync<TEntity, TFilter>(TFilter filter)
        where TEntity : BaseEntity
    {
        return RequestAsync<FindResponse>(
            HttpMethod.Get,
            $"api/{TypeCache<TEntity>.EntityName}/find");
    }


    public Task<CreateResponse> CreateAsync<TEntity>(TEntity entity)
        where TEntity : BaseEntity
    {
        return RequestAsync<CreateResponse>(
          HttpMethod.Post,
          $"/api/{TypeCache<TEntity>.EntityName}/create");
    }

    public Task<UpdateResponse> UpdateAsync<TEntity>(TEntity entity)
        where TEntity : BaseEntity
    {
        return RequestAsync<UpdateResponse>(
          HttpMethod.Post,
          $"/api/{TypeCache<TEntity>.EntityName}/{entity.Id}");
    }

    public Task<DeleteResponse> DeleteAsync<TEntity>(TEntity entity)
    where TEntity : BaseEntity
    {
        return RequestAsync<DeleteResponse>(
          HttpMethod.Delete,
          $"/api/{TypeCache<TEntity>.EntityName}/{entity.Id}");
    }

    public Task<ExistsResponse> ExistsAsync<TEntity>(uint id)
    where TEntity : BaseEntity
    {
        return RequestAsync<ExistsResponse>(
          HttpMethod.Get,
          $"/api/{TypeCache<TEntity>.EntityName}/exists?identifier={id}");
    }

    public Task<ExistsResponse> GetAsync<TEntity>(uint id)
where TEntity : BaseEntity
    {
        return RequestAsync<ExistsResponse>(
          HttpMethod.Get,
          $"/api/{TypeCache<TEntity>.EntityName}/{id}");
    }


    protected async Task RequestAsync(HttpMethod method,
        string uri,
        HttpContent? content = null)
    {
        var httpResponseMessage = await HttpClient.SendAsync(new HttpRequestMessage()
        {
            Method = method,
            RequestUri = new Uri(HttpClient.BaseAddress + uri),
            Content = content
        });

        if (httpResponseMessage.IsSuccessStatusCode == false)
        {
            using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

#pragma warning disable IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code
            var result = await JsonSerializer.DeserializeAsync<ErrorResponse>(contentStream);
#pragma warning restore IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code

            throw XingExceptionFactory.GetExceptions(result!.Errors!);
        }
    }

    protected async Task<TResponse> RequestAsync<TResponse>(HttpMethod method,
    string uri,
    HttpContent? content = null)
    {
        var httpResponseMessage = await HttpClient.SendAsync(new HttpRequestMessage()
        {
            Method = method,
            RequestUri = new Uri(HttpClient.BaseAddress + uri),
            Content = content
        });

        using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
        if (httpResponseMessage.IsSuccessStatusCode == false)
        {

#pragma warning disable IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code
            var result = await JsonSerializer.DeserializeAsync<ErrorResponse>(contentStream);
#pragma warning restore IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code

            throw XingExceptionFactory.GetExceptions(result!.Errors!);
        }

#pragma warning disable IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code
        return (await JsonSerializer.DeserializeAsync<TResponse>(contentStream))!;
#pragma warning restore IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code

    }
}
