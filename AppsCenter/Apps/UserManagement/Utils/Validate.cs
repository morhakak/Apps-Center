using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppsCenter.Apps.UserManagement.Utils;

public class Validate
{
    private static readonly SolidColorBrush RedBrush = new(Colors.Red);
    private static readonly SolidColorBrush BlackBrush = new(Colors.Black);

    public static bool UserName(TextBox textBox)
    {
        Regex regex = new(@"^[A-Za-z].{2,20}");
        Match match = regex.Match(textBox.Text);

        if (!match.Success)
        {
            ShowErrorMessage("Username: Please enter at least 3 characters");
            SetErrorStyle(textBox);

            return false;
        }

        ResetStyle(textBox);

        return true;
    }

    public static bool UserPassword(PasswordBox passwordbBox)
    {
        Regex regex = new(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$");
        Match match = regex.Match(passwordbBox.Password);

        if (!match.Success)
        {
            ShowErrorMessage("Password: \n- Minimum length of 8 characters\n- At least one digit\n- At least one lowercase letter\n- At least one capital letter.");
            SetErrorStyle(passwordbBox);

            return false;
        }

        ResetStyle(passwordbBox);

        return true;
    }

    public static bool Email(TextBox textBox)
    {
        Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(textBox.Text);

        if (!match.Success)
        {
            ShowErrorMessage("Please enter a valid email");
            SetErrorStyle(textBox);

            return false;
        }

        ResetStyle(textBox);
        return true;
    }

    private static void ShowErrorMessage(string message)
    {
        MessageBox.Show(message);
    }

    private static void SetErrorStyle(Control control)
    {
        control.BorderBrush = RedBrush;
    }

    private static void ResetStyle(Control control)
    {
        control.BorderBrush = BlackBrush;
    }
}
