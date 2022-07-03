using Rc.XingApiClientNet.Entities;

namespace Rc.XingApiClientNet.Tests;

public class EventTests
{
    [Fact]
    public async void ReadTestAsync()
    {
        var client = new XingApiClient();

        var a = await client.FindAsync<Event, EventFindFilter>(new EventFindFilter { });
    }
}