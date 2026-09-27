namespace DelegateFullExample.crs.DelegateWithGenericExample.CurrencyRateService;

public class CurrencyRateServiceGeneric
{
    public CurrencyRateDto GetCurrencyRate(string fromCurrency, string toCurrency)
    {
        // Simulate fetching currency rate from an external service or database
        // For demonstration purposes, we'll return a hardcoded value
        return new CurrencyRateDto
        {
            FromCurrency = fromCurrency,
            ToCurrency = toCurrency,
            Rate = 1.2m // Example rate
        };
    }

    public void UpdateCurrencyRate(
        string fromCurrency, 
        string toCurrency, 
        decimal newRate, 
        NotificationHandlerGeneric<CurrencyRateDto> notification)
    {
        // Simulate updating the currency rate in an external service or database
        // For demonstration purposes, we'll just create a new CurrencyRateDto
        var updatedRate = new CurrencyRateDto
        {
            FromCurrency = fromCurrency,
            ToCurrency = toCurrency,
            Rate = newRate
        };

        var oldRate = GetCurrencyRate(fromCurrency, toCurrency);
        Console.WriteLine($"Currency rate changing from {fromCurrency} to {toCurrency}. Old Rate: {oldRate.Rate}, New rate: {newRate}");
        // Notify the caller about the currency rate change using the provided delegate
        notification(updatedRate);
    }
}
