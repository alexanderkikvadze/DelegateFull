namespace DelegateFullExample.crs.DelegateWithGenericExample.CurrencyRateService;

public class CurrencyRateChangeNotificationServiceGeneric
{
    public static void SendSms(CurrencyRateDto currencyRate)
    {
        Console.WriteLine($"SMS: Currency rate changed from {currencyRate.FromCurrency} "+
            $"to {currencyRate.ToCurrency}. New rate: {currencyRate.Rate}");
    }

    public static void SendEmail(CurrencyRateDto currencyRate)
    {
        Console.WriteLine($"Email: Currency rate changed from {currencyRate.FromCurrency} "+
            $"to {currencyRate.ToCurrency}. New rate: {currencyRate.Rate}");
    }
}
