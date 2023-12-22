using AppsCenter.Apps.CurrencyConverter.Services;
using AppsCenter.Apps.UserManagement.Utils;
using Microsoft.Extensions.Configuration;
using System.Windows;
using System.Windows.Controls;

namespace AppsCenter.Apps.UserManagement;

public partial class LoginView : Window
{
    private UserManagementView? _userManagementView;
    private const string LoginUserNameKey = "loginUserName";
    private const string LoginPasswordKey = "loginPassword";
    private readonly IConfiguration _configuration = new ConfigurationBuilder()
     .AddUserSecrets<CurrencyService>()
     .Build();

    public LoginView()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (Validate.UserName(UsernameTextBox) && Validate.UserPassword(PasswordBox))
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == _configuration[LoginUserNameKey] && password == _configuration[LoginPasswordKey])
            {
                _userManagementView = new UserManagementView();
                _userManagementView.Show();
                Close();
            }
            else MessageBox.Show("Login failed. Please check your credentials.");

            ClearInputs();
        }
    }

    private void ClearInputs()
    {
        UsernameTextBox.Text = string.Empty;
        PasswordBox.Clear();
    }
}
