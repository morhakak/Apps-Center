using AppsCenter.Apps;
using AppsCenter.Apps.CarGameApp;
using AppsCenter.Apps.CurrencyConverter;
using AppsCenter.Apps.TicTacToe;
using AppsCenter.Apps.ToDoApp;
using AppsCenter.Apps.UserManagement;
using AppsCenter.Helpers;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace AppsCenter;

public partial class MainWindow : Window
{
    private Calculator? _calculator;
    private ToDoList? _todoList;
    private CurrencyConverterView? _currencyConverter;
    private CarGameView? _carGameView;
    private AppsPresentationView? _appPresentationView;
    private TicTacToeView? _ticTacToeView;
    private UserManagementView? _userManagementView;
    public MainWindow()
    {
        InitializeComponent();

        DispatcherTimer timer = new()
        {
            Interval = TimeSpan.FromSeconds(1),
        };

        timer.Tick += UpdateDate;
        timer.Start();
        Closed += OnClosed;
    }

    private void OnClosed(object? sender, EventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void UpdateDate(object? sender, EventArgs e)
    {
        date.Content = DateTime.Now.ToString("dddd, dd MMMM, HH:mm:ss");
    }

    private void Image_MouseEnter(object sender, MouseEventArgs e)
    {
        Mouse.OverrideCursor = Cursors.Hand;
        Image image = (sender as Image)!;
        image.Opacity = 0.5;
        GameText.Content = (image.Name) switch
        {
            "CalcualtorImg" => "Calculator",
            "ToDoImg" => "To Do List",
            "CurrencyConverterImg" => "Currency Converter",
            "CarGameAppImg" => "Car Game",
            "TicTacToeImg" => "Tic Tac Toe Game",
            "UserManagementImg" => "User Management",
            _ => "Please pick a game"
        };
    }

    private void Image_MouseLeave(object sender, MouseEventArgs e)
    {
        Mouse.OverrideCursor = null;
        (sender as Image)!.Opacity = 1;
        GameText.Content = "Please pick an app";
    }

    private void Calcualtor_MouseUp(object sender, MouseButtonEventArgs e)
    {
        _calculator = new Calculator();
        LaunchAppPresentation("Calculator", _calculator, CalcualtorImg.Source);
    }

    private void ToDo_MouseUp(object sender, MouseButtonEventArgs e)
    {
        _todoList = new ToDoList();
        LaunchAppPresentation("To Do", _todoList, ToDoImg.Source);
    }

    private void CurrencyConverter_MouseUp(object sender, MouseButtonEventArgs e)
    {
        _currencyConverter = new CurrencyConverterView();
        LaunchAppPresentation("Currency Converter", _currencyConverter, CurrencyConverterImg.Source);
    }

    private void CarGame_MouseUp(object sender, MouseButtonEventArgs e)
    {
        _carGameView = new CarGameView();
        LaunchAppPresentation("Car Game", _carGameView, CarGameAppImg.Source);
    }

    private void TicTacToeGame_MouseUp(object sender, MouseButtonEventArgs e)
    {
        _ticTacToeView = new TicTacToeView();
        LaunchAppPresentation("Tic Tac Toe", _ticTacToeView, TicTacToeImg.Source);
    }

    private void UserManagement_MouseUp(object sender, MouseButtonEventArgs e)
    {
        _userManagementView = new UserManagementView();
        LaunchAppPresentation("User Management", _userManagementView, UserManagementImg.Source);
    }

    private void LaunchAppPresentation(string appName, Window appInstance, ImageSource appImage)
    {
        _appPresentationView = new AppsPresentationView { Owner = this };

        AppInfo? appInfo = DataReader.GetAppByName(appName);

        if (appInfo == null)
        {
            MessageBox.Show("Error loading application data. Please try again later.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            appInfo = new AppInfo()
            {
                AppTitle = appName,
                AppDescription = $"{appName} Description",
                Technologies = string.Empty,
            };
        }

        _appPresentationView.OnStart(appInstance, appInfo, appImage);
        _appPresentationView.Show();
    }

    private void ExistButton_MouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to close the Apps Center?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);

        if (messageBoxResult == MessageBoxResult.Yes)
            Close();
    }

    private void ExistButton_MouseEnter(object sender, MouseEventArgs e)
    {
        ExistButton.Opacity = 0.5;
        Mouse.OverrideCursor = Cursors.Hand;
    }

    private void ExistButton_MouseLeave(object sender, MouseEventArgs e)
    {
        ExistButton.Opacity = 1;
        Mouse.OverrideCursor = null;
    }
}