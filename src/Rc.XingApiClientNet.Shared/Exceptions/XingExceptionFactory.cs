using System;
using System.Collections.Generic;
using System.Text;

namespace Rc.XingApiClientNet.Exceptions;

public static class XingExceptionFactory
{
    public static AggregateException GetExceptions(List<string> errorCodes)
    {
        List<Exception> exceptions = new();

        for(var i = 0; i < errorCodes.Count; i++)
        {
            switch(errorCodes[i])
            {
                case "com.amiando.api.rest.NotAuthorized":
                    exceptions.Add(new NotAuthorizedException());
                    continue;
                case "com.amiando.api.rest.InvalidApiKey":
                    exceptions.Add(new InvalidAPIKeyException());
                    continue;
                case "com.amiando.api.rest.InvalidPath":
                    exceptions.Add(new InvalidPathException());
                    continue;
                case "com.amiando.api.rest.ObjectNotFound":
                    exceptions.Add(new ObjectNotFoundException());
                    continue;
                case "com.amiando.api.rest.InvalidResourceId":
                    exceptions.Add(new InvalidResourceIdException());
                    continue;
                case "com.amiando.api.rest.DataProcessingAgreementMissing":
                    exceptions.Add(new DataProcessingAgreementMissingException());
                    continue;
                case "com.amiando.api.rest.InsecureConnection":
                    exceptions.Add(new InsecureConnectionException());
                    continue;
                case "com.amiando.api.rest.InvalidPassword":
                    exceptions.Add(new InsecureConnectionException());
                    continue;
                case "com.amiando.api.rest.InvalidSignUpPromotionCode":
                    exceptions.Add(new InvalidSignUpPromotionCodeException());
                    continue;
                case "com.amiando.api.rest.NoMultiUserKey":
                    exceptions.Add(new NoMultiUserKeyException());
                    continue;
                case "com.amiando.Event.AlreadyActivated":
                    exceptions.Add(new EventAlreadyActivatedException());
                    continue;
                case "com.amiando.Event.DateIsPast":
                    exceptions.Add(new EventDateInThePastException());
                    continue;
                case "com.amiando.Event.EndDateBeforeDate":
                    exceptions.Add(new EndDateBeforeDateException());
                    continue;
                case "com.amiando.Event.NoLanguage":
                    exceptions.Add(new NoLanguageException());
                    continue;
                case "com.amiando.User.NoLanguage":
                    exceptions.Add(new NoLanguageException());
                    continue;
                case "com.amiando.Event.UnsupportedLanguage":
                    exceptions.Add(new UnsupportedLanguageException());
                    continue;
                case "com.amiando.User.UnsupportedLanguage":
                    exceptions.Add(new UnsupportedLanguageException());
                    continue;
                case "amiando.Event.NoCountry":
                    exceptions.Add(new NoCountryException());
                    continue;
                case "amiando.Event.UnsupportedCountry":
                    exceptions.Add(new UnsupportedCountryException());
                    continue;
                case "com.amiando.Event.NoTimezone":
                    exceptions.Add(new NoTimezoneException());
                    continue;
                case "com.amiando.Event.NoTitle":
                    exceptions.Add(new NoTitleException());
                    continue;
                case "com.amiando.TicketShop.NoTicketCategories":
                    exceptions.Add(new NoTicketCategoriesException());
                    continue;
                case "com.amiando.TicketShop.NoBillingAddres":
                    exceptions.Add(new NoBillingAddress());
                    continue;
                case "com.amiando.TicketShop.NoBankAccount":
                    exceptions.Add(new NoBankAccountException());
                    continue;
                case "com.amiando.TicketShop.NoPaymentType":
                    exceptions.Add(new NoPaymentTypeException());
                    continue;
                case "com.amiando.TicketShop.NoTicketType":
                    exceptions.Add(new NoTicketTypeException());
                    continue;
                case "com.amiando.Event.IdentifierExists":
                    exceptions.Add(new IdentifierExistsException());
                    continue;
                case "com.amiando.api.rest.InvalidVisibility":
                    exceptions.Add(new InvalidVisibilityException());
                    continue;
                case "com.amiando.ticketShop.cantChangeCurrency":
                    exceptions.Add(new CannotChangeCurrencyException());
                    continue;
                case "com.amiando.ticketshop.registrationDateValidationError":
                    exceptions.Add(new RegistrationDeadlineInvalidException());
                    continue;
                case "com.amiando.api.rest.InvalidGender":
                    exceptions.Add(new InvalidGenderException());
                    continue;
                case "com.amiando.api.rest.InvalidCountry":
                    exceptions.Add(new InvalidCountryException());
                    continue;
                case "com.amiando.api.rest.InvalidDate":
                    exceptions.Add(new InvalidDateException());
                    continue;
                case "com.amiando.api.rest.InvalidNumber":
                    exceptions.Add(new InvalidNumberException());
                    continue;
                case "com.amiando.ticketing.TicketShop.AmountBelowZero":
                    exceptions.Add(new AmountBelowZeroException());
                    continue;
                case "com.amiando.ticketing.TicketShop.TooManyItems":
                    exceptions.Add(new TooManyItemsException());
                    continue;
                case "com.amiando.ticketing.TicketShop.ExceededMaxSell":
                    exceptions.Add(new ExceededMaxSellException());
                    continue;
                case "com.amiando.Payment.TicketsRequired":
                    exceptions.Add(new TicketsRequiredException());
                    continue;
                case "com.amiando.api.rest.CannotUpdateNonDraftPayment":
                    exceptions.Add(new CannotUpdateNonDraftPaymentException());
                    continue;
                case "com.amiando.api.rest.DiscountCodeUsedUp":
                    exceptions.Add(new DiscountCodeUsedUpException());
                    continue;
                case "com.amiando.api.rest.DataPrefilled":
                    exceptions.Add(new DataPrefilledException());
                    continue;
                case "com.amiando.api.rest.InvalidDiscountCode":
                    exceptions.Add(new InvalidDiscountCodeException());
                    continue;
                case "com.amiando.api.rest.InvalidDiscountCodeForNumberOfTicketsException":
                    exceptions.Add(new InvalidDiscountCodeForNumberOfTicketsException());
                    continue;
                case "com.amiando.api.rest.DiscountCodeRequired":
                    exceptions.Add(new DiscountCodeRequiredException());
                    continue;
                case "com.amiando.api.rest.BuyerAddressMissing":
                    exceptions.Add(new BuyerAddressMissingException());
                    continue;
                case "com.amiando.api.rest.CreditCardPaymentNotEnabled":
                    exceptions.Add(new CreditCardPaymentNotEnabledException());
                    continue;
                case "com.amiando.api.rest.MethodNotAllowed":
                    exceptions.Add(new MethodNotAllowedException());
                    continue;
                case "com.amiando.api.rest.PaymentStartedInIframeException":
                    exceptions.Add(new PaymentStartedInIframeException());
                    continue;
                case "com.amiando.TicketCategory.NameMissing":
                    exceptions.Add(new NameMissingException());
                    continue;
                case "com.amiando.TicketCategory.PriceMissing":
                    exceptions.Add(new PriceMissingException());
                    continue;
                case "com.amiando.TicketCategory.NoTicketsAvailable":
                    exceptions.Add(new NoTicketsAvailableException());
                    continue;
                case "com.amiando.TicketCategory.InvalidMaxSell":
                    exceptions.Add(new NoTicketsAvailableException());
                    continue;
                case "com.amiando.TicketCategory.MaxSellLowerThanMinSell":
                    exceptions.Add(new MaxSellLowerThanMinSellException());
                    continue;
                case "TicketSaleSpanIsTooBig":
                    exceptions.Add(new TicketSaleSpanIsTooBigException());
                    continue;
                case "com.amiando.TicketCategory.SaleEndBeforeSaleStart":
                    exceptions.Add(new SaleEndBeforeSaleStartException());
                    continue;
                case "com.amiando.TicketCategory.CommentTooLong":
                    exceptions.Add(new CommentTooLongException());
                    continue;
                case "com.amiando.api.rest.CantEditPrice":
                    exceptions.Add(new CantEditPriceException());
                    continue;
                case "com.amiando.TicketCategory.InvalidOnlineTypeForThisEvent":
                    exceptions.Add(new InvalidOnlineTypeForThisEventException());
                    continue;
                case "com.amiando.api.rest.NoHtmlContentAllowed":
                    exceptions.Add(new NoHtmlContentAllowedException());
                    continue;
                case "com.amiando.api.rest.NoTextContentAllowed":
                    exceptions.Add(new NoTextContentAllowedException());
                    continue;
                case "com.amiando.api.rest.ErrorOnEvaluatingTemplate":
                    exceptions.Add(new ErrorOnEvaluatingTemplateException());
                    continue;
                case "com.amiando.api.rest.ErrorOnSending":
                    exceptions.Add(new ErrorOnSendingException());
                    continue;
                case "com.amiando.campaign.Campaign.noHtmlContentGiven":
                    exceptions.Add(new NoHtmlContentGivenException());
                    continue;
                case "com.amiando.campaign.Campaign.noUnsubscribeLink":
                    exceptions.Add(new NoUnsubscribeLinkException());
                    continue;
                case "com.amiando.User.EmailInvalid":
                    exceptions.Add(new EmailInvalidException());
                    continue;
                case "com.amiando.api.rest.ticketType.TicketTypeNotAllowed":
                    exceptions.Add(new TicketTypeNotAllowedException());
                    continue;
                case "com.amiando.api.rest.ticketType.TicketTypeAlreadyExists":
                    exceptions.Add(new TicketTypeAlreadyExistsException());
                    continue;
                case "com.amiando.api.rest.paymentType.PaymentTypeNotAllowed":
                    exceptions.Add(new PaymentTypeNotAllowedException());
                    continue;
                case "com.amiando.api.rest.paymentType.PaymentTypeAlreadyExists":
                    exceptions.Add(new PaymentTypeAlreadyExistsException());
                    continue;
                case "com.amiando.api.rest.MissingParam.name":
                    exceptions.Add(new DirectPaymentWithoutNameException());
                    continue;
                case "com.amiando.api.rest.DirectPaymentTypeInstructionsMissing":
                    exceptions.Add(new DirectPaymentTypeInstructionsMissingException());
                    continue;
                case "com.amiando.api.rest.DiscountCodeExistsException":
                    exceptions.Add(new DiscountCodeExistsException());
                    continue;
                case "com.amiando.billing.BankAccount.InternationalBankAccountInvalid":
                    exceptions.Add(new InternationalBankAccountInvalidException());
                    continue;
            }

            if(errorCodes[i].StartsWith("com.amiando.api.rest.MissingParam", StringComparison.OrdinalIgnoreCase))
            {
                exceptions.Add(new MissingParameterException(errorCodes[i]));
            } else if (errorCodes[i].StartsWith("com.amiando.api.rest.InvalidFormat", StringComparison.OrdinalIgnoreCase))
            {
                exceptions.Add(new InvalidFormatException(errorCodes[i]));
            }
            else if (errorCodes[i].StartsWith("com.amiando.api.rest.InvalidParam", StringComparison.OrdinalIgnoreCase))
            {
                exceptions.Add(new InvalidParamException(errorCodes[i]));
            }
            else if (errorCodes[i].StartsWith("com.amiando.api.rest.InternalServerException", StringComparison.OrdinalIgnoreCase))
            {
                exceptions.Add(new InternalServerException(errorCodes[i]));
            }
            else if (errorCodes[i].StartsWith("com.amiando.User.", StringComparison.OrdinalIgnoreCase))
            {
                exceptions.Add(new RequiredFieldMissingException(errorCodes[i]));
            }
            else if (errorCodes[i].StartsWith("com.amiando.api.rest.InvalidDavaluationSource.", StringComparison.OrdinalIgnoreCase))
            {
                exceptions.Add(new InvalidDevaluationSourceException(errorCodes[i]));
            }
        }

        return new AggregateException(exceptions);
    }
}
