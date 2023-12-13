using AppsCenter.Apps.TicTacToe.Models;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppsCenter.Apps.TicTacToe;

public partial class TicTacToeView : Window
{
    private TicTacToeModel? _gameModel;

    public TicTacToeView()
    {
        InitializeComponent();
        InitializeGame();
    }

    private void InitializeGame()
    {
        _gameModel = new TicTacToeModel();
        ResetGameBoard();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button && string.IsNullOrEmpty(button.Content as string))
        {
            int row = Grid.GetRow(button);
            int column = Grid.GetColumn(button);

            SetButtonProperties(button);

            _gameModel!.GameBoard[row, column] = _gameModel.CurrentPlayer;

            if (!IsGameEnded())
            {
                _gameModel.ToggleCurrentPlayer();
                ComputerMove();
            }
        }
    }

    private async void ComputerMove()
    {
        await Task.Delay(1000);

        Random random = new();
        int row;
        int column;

        do
        {
            row = random.Next(3);
            column = random.Next(3);

        } while (_gameModel?.GameBoard[row, column] != '\0');

        Button? computerButton = FindButton(row, column);

        if (computerButton != null)
        {
            computerButton.Content = _gameModel.CurrentPlayer;
            _gameModel.GameBoard[row, column] = _gameModel.CurrentPlayer;
            SetButtonProperties(computerButton);

            if (!IsGameEnded())
                _gameModel.CurrentPlayer = 'X';
        }
    }

    private Button? FindButton(int row, int column)
    {
        foreach (Button? button in MainGrid.Children)
        {
            if (Grid.GetRow(button) == row && Grid.GetColumn(button) == column)
                return button;
        }

        return null;
    }

    private void SetButtonProperties(Button button)
    {
        button.Content = _gameModel?.CurrentPlayer.ToString();
        button.Foreground = _gameModel!.CurrentPlayer.Equals('X') ? Brushes.Green : Brushes.Red;
    }

    private void ResetGameBoard()
    {
        _gameModel = new TicTacToeModel();

        foreach (Button button in MainGrid.Children)
        {
            button.Content = "";
            button.Background = Brushes.White;
        }
    }

    public bool IsGameEnded()
    {
        string title = "TicTacToe";
        string playAgainMessage = "Do you want to play again?";

        if (_gameModel!.CheckForWin())
        {
            ShowMessage($"{_gameModel.CurrentPlayer} Won! \n{playAgainMessage}", title);
            return true;
        }
        else if (_gameModel.IsBoardFull())
        {
            ShowMessage($"It's a tie!\n{playAgainMessage}", title);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShowMessage(string message, string title)
    {
        MessageBoxResult result = MessageBox.Show(message, title, MessageBoxButton.YesNo);

        if (result == MessageBoxResult.Yes)
            ResetGameBoard();
        else
            Close();
    }
}

