namespace DelegateFullExample.crs.DelegateWithGenericExample.CurrencyRateService;

public class CurrencyRateDto
{
    public string FromCurrency { get; set; } = string.Empty;
    public string ToCurrency { get; set; } = string.Empty;
    public decimal Rate { get; set; }
}
