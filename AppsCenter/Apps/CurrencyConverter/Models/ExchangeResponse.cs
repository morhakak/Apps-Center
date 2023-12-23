using System.Collections.Generic;

namespace AppsCenter.Apps.CurrencyConverter.Models;

public class ExchangeResponse
{
    public bool Success { get; set; }
    public long Timestamp { get; set; }
    public string? Base { get; set; }
    public string? Date { get; set; }
    public Dictionary<string, double>? Rates { get; set; }
}
