using System.Windows;

namespace AppsCenter.Apps;

public class SimpleMath
{
    public static double Add(double num1, double num2) => num1 + num2;
    public static double Substract(double num1, double num2) => num1 - num2;
    public static double Multiply(double num1, double num2) => num1 * num2;
    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            MessageBox.Show("Division by Zero is not supported", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
            return 0;
        }

        return num1 / num2;
    }
}
