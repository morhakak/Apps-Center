﻿using AppsCenter.Apps.CurrencyConverter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AppsCenter.Apps.CurrencyConverter;

public partial class CurrencyConverterView : Window
{
    private CurrencyService _currencyService;
    private Dictionary<string, double> _exchangeRates;

    public CurrencyConverterView()
    {
        InitializeComponent();
        _currencyService = new CurrencyService();
        _exchangeRates = new Dictionary<string, double>();
    }

    public async Task LoadCurrencies()
    {
        try
        {
            _exchangeRates = await _currencyService.GetExchangeRatesAysnc();

            List<string> rates = _exchangeRates.Keys.ToList();
            FromCurrencyComboBox.ItemsSource = rates;
            ToCurrencyComboBox.ItemsSource = rates;
        }
        catch (Exception e)
        {
            MessageBox.Show($"{e.Message}", "Failed to load currencies", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void BtnConvert_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            string? fromCurrency = FromCurrencyComboBox.SelectedItem?.ToString();
            string? toCurrency = ToCurrencyComboBox.SelectedItem?.ToString();

            double amount;
            if (string.IsNullOrEmpty(AmountTextBox.Text) || !double.TryParse(AmountTextBox.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount!", "Invalid Amount", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            double? convertedAmount = ConvertCurrency(fromCurrency, toCurrency, amount);

            if (convertedAmount.HasValue)
            {
                txtResult.Text = $"{amount} {fromCurrency} is {convertedAmount:0.00} {toCurrency}";
                AmountTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Selected currency not available in the exchnage rates", "Invalid Rate Selection", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error converting currencies: {ex.Message}");
        }
    }

    private double? ConvertCurrency(string? fromCurrency, string? toCurrency, double amount)
    {
        bool currenciesNull = fromCurrency == null || toCurrency == null;
        bool currenciesKeysExists = _exchangeRates.ContainsKey(fromCurrency) && _exchangeRates.ContainsKey(toCurrency);

        if (!currenciesNull && currenciesKeysExists)
        {
            double fromCurrencyValue = _exchangeRates[fromCurrency];
            double toCurrencyValue = _exchangeRates[toCurrency];

            double result = (toCurrencyValue / fromCurrencyValue) * amount;

            return result;
        }

        return null;
    }
}