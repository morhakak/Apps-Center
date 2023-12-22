using System.Windows;
using System.Windows.Controls;

namespace AppsCenter.Apps;

public partial class Calculator : Window
{
    double _lastNumber;
    double _result;
    double _newNumber;
    SelectedOperator _selectedOperator;

    public Calculator()
    {
        InitializeComponent();

        acButton.Click += AcButton_Click;
        negativeButton.Click += NegativeButton_Click;
        precentageButton.Click += PrecentageButton_Click;
    }
    private void EqualButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(resultLabel.Content.ToString(), out _newNumber))
        {
            switch (_selectedOperator)
            {
                case SelectedOperator.Addition:
                    _result = SimpleMath.Add(_lastNumber, _newNumber);
                    break;
                case SelectedOperator.Subtraction:
                    _result = SimpleMath.Substract(_lastNumber, _newNumber);
                    break;
                case SelectedOperator.Division:
                    _result = SimpleMath.Divide(_lastNumber, _newNumber);
                    break;
                case SelectedOperator.Multiplication:
                    _result = SimpleMath.Multiply(_lastNumber, _newNumber);
                    break;
            }

            resultLabel.Content = _result.ToString();
        }
    }

    private void PrecentageButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(resultLabel.Content.ToString(), out double temp))
        {
            temp /= 100;

            if (_lastNumber != 0)
            {
                temp *= _lastNumber;
            }

            resultLabel.Content = temp.ToString();
        }
    }

    private void NegativeButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(resultLabel.Content.ToString(), out _lastNumber))
        {
            _lastNumber *= -1;
            resultLabel.Content = _lastNumber.ToString();
        }
    }

    private void AcButton_Click(object sender, RoutedEventArgs e)
    {
        resultLabel.Content = "0";
        _lastNumber = 0;
        _newNumber = 0;
        _result = 0;
    }

    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button button) return;

        string? content = button.Content.ToString();
        if (string.IsNullOrEmpty(content)) return;

        if (int.TryParse(content, out int selectedValue))
        {
            resultLabel.Content = resultLabel.Content.ToString() == "0" ? selectedValue.ToString() : $"{resultLabel.Content}{selectedValue}";
        }
    }

    private void OperationButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(resultLabel.Content.ToString(), out _lastNumber))
            resultLabel.Content = "0";

        _selectedOperator = sender switch
        {
            Button b when b == plusButton => SelectedOperator.Addition,
            Button b when b == minusButton => SelectedOperator.Subtraction,
            Button b when b == divisionButton => SelectedOperator.Division,
            Button b when b == multipleButton => SelectedOperator.Multiplication,
            _ => _selectedOperator
        };
    }

    private void PointButton_Click(object sender, RoutedEventArgs e)
    {
        if (!resultLabel.Content.ToString()!.Contains("."))
            resultLabel.Content = $"{resultLabel.Content}.";
    }
}
