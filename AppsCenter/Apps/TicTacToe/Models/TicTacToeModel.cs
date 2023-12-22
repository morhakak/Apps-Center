namespace AppsCenter.Apps.TicTacToe.Models;

public class TicTacToeModel
{
    public char[,] GameBoard { get; set; }
    public char CurrentPlayer { get; set; }
    private const char PlayerX = 'X';
    private const char PlayerO = 'O';

    public TicTacToeModel()
    {
        GameBoard = new char[3, 3];
        CurrentPlayer = PlayerX;
    }

    public bool IsBoardFull()
    {
        foreach (char cell in GameBoard)
        {
            if (cell == 0)
                return false;
        }

        return true;
    }

    public bool CheckForWin()
    {
        for (int i = 0; i < 3; i++)
        {
            if (GameBoard[i, 0] == CurrentPlayer && GameBoard[i, 1] == CurrentPlayer && GameBoard[i, 2] == CurrentPlayer)
                return true;
        }

        for (int i = 0; i < 3; i++)
        {
            if (GameBoard[0, i] == CurrentPlayer && GameBoard[1, i] == CurrentPlayer && GameBoard[2, i] == CurrentPlayer)
                return true;
        }

        if (GameBoard[0, 0] == CurrentPlayer && GameBoard[1, 1] == CurrentPlayer && GameBoard[2, 2] == CurrentPlayer)
            return true;

        if (GameBoard[0, 2] == CurrentPlayer && GameBoard[1, 1] == CurrentPlayer && GameBoard[2, 0] == CurrentPlayer)
            return true;

        return false;
    }

    public bool IsGameOver()
    {
        return IsBoardFull() || CheckForWin();
    }

    public void ToggleCurrentPlayer()
    {
        CurrentPlayer = (CurrentPlayer == PlayerX) ? PlayerO : PlayerX;
    }
}
