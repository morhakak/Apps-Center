using AppsCenter.Apps.CurrencyConverter.Services;
using AppsCenter.Apps.UserManagement.Utils;
using Microsoft.Extensions.Configuration;
using System.Windows;

namespace AppsCenter.Apps.UserManagement;

public partial class LoginView : Window
{
    private UserManagementView? _userManagementView;
    private readonly IConfiguration _configuration = new ConfigurationBuilder().AddUserSecrets<CurrencyService>().Build();
    public LoginView()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (Validate.UserName(UsernameTextBox) && Validate.UserPassword(PasswordBox))
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Text;

            if (username == _configuration["loginUserName"] && password == _configuration["loginPassword"])
            {

                _userManagementView = new UserManagementView();
                _userManagementView.Show();
                Close();
            }
            else
                MessageBox.Show("Login failed. Please check your credentials.");

            UsernameTextBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }
    }
}
