using System.Windows;
using System.Windows.Controls;

namespace CarGame;

public class PlayerCar : GameObject
{
    public bool IsLeftKeyPressed { get; set; }
    public bool IsRightKeyPressed { get; set; }
    public PlayerCar(int x, int y, int speed, Image carImage) : base(x, y, speed, carImage) { }

    public override void Move()
    {
        if (IsLeftKeyPressed && X > 0)
            X -= Speed;

        if (IsRightKeyPressed && X < Application.Current.MainWindow.Width - Representation.Width)
            X += Speed;

        Draw();
    }
}
