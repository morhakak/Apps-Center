using AppsCenter.Apps.CurrencyConverter;
using AppsCenter.Apps.UserManagement;
using AppsCenter.Helpers;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace AppsCenter;

public partial class AppsPresentationView : Window
{
    private Window? _appWindow;
    public event EventHandler? AppPresentationClosing;
    public AppsPresentationView()
    {
        InitializeComponent();

        DispatcherTimer timer = new()
        {
            Interval = TimeSpan.FromSeconds(1),
        };

        timer.Tick += UpdateDate;
        timer.Start();
    }

    private void UpdateDate(object? sender, EventArgs e)
    {
        date.Content = DateTime.Now.ToString("dddd, dd MMMM, HH:mm:ss");
    }

    public void OnStart(Window app, AppInfo appInfo, ImageSource imgSrc)
    {
        _appWindow = app;
        appTitle.Content = appInfo.AppTitle;
        appDescription.Text = appInfo.AppDescription;
        technologies.Text = $"Technologies: {appInfo.Technologies}";
        appImage.Source = imgSrc;
    }

    private async void OpenApp(object sender, MouseButtonEventArgs e)
    {
        try
        {
            if (_appWindow!.GetType() == typeof(CurrencyConverterView))
            {
                CurrencyConverterView currencyConverter = new();
                currencyConverter = (CurrencyConverterView)_appWindow;
                await currencyConverter.LoadCurrencies();
                _appWindow.Show();
                Close();
            }
            else if (_appWindow!.GetType() == typeof(UserManagementView))
            {
                LoginView loginView = new();
                loginView.Show();
                Close();
            }
            else
            {
                _appWindow.Show();
                Close();
            }
        }
        catch (Exception)
        { }
    }

    private void GoBack(object sender, MouseButtonEventArgs e) => Close();

    private void Mouse_Enter(object sender, MouseEventArgs e)
    {
        Mouse.OverrideCursor = Cursors.Hand;

        if (sender is Image img)
        {
            img.Opacity = 0.5;
        }

        if (sender is Label label)
        {
            label.Opacity = 0.5;
        }
    }

    private void Mouse_Leave(object sender, MouseEventArgs e)
    {
        Mouse.OverrideCursor = null;

        if (sender is Image img)
        {
            img.Opacity = 1;
        }

        if (sender is Label label)
        {
            label.Opacity = 1;
        }
    }
}
