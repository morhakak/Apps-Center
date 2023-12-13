using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppsCenter.Apps.UserManagement.Utils;

public class Validate
{
    public static bool UserName(TextBox box)
    {
        Regex regex = new(@"^[A-Za-z].{2,20}");
        Match match = regex.Match(box.Text);

        if (!match.Success)
        {
            MessageBox.Show("Username: Please enter at least 3 characters");
            box.BorderBrush = new SolidColorBrush(Colors.Red);

            return false;
        }

        box.BorderBrush = new SolidColorBrush(Colors.Black);

        return true;
    }

    public static bool UserPassword(TextBox box)
    {
        Regex regex = new(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$");
        Match match = regex.Match(box.Text);

        if (!match.Success)
        {
            MessageBox.Show("Password: \n- Minimum length of 8 characters\n- At least one digit\n- At least one lowercase letter\n- At least one capital letter. ");
            box.BorderBrush = new SolidColorBrush(Colors.Red);

            return false;
        }

        box.BorderBrush = new SolidColorBrush(Colors.Black);

        return true;
    }

    public static bool Email(TextBox box)
    {
        Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(box.Text);

        if (!match.Success)
        {
            MessageBox.Show("please enter a valid email");
            box.BorderBrush = new SolidColorBrush(Colors.Red);

            return false;
        }

        box.BorderBrush = new SolidColorBrush(Colors.Black);

        return true;
    }
}
