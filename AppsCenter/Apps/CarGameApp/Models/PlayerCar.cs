using System.Windows.Controls;

namespace CarGame;

public class PlayerCar : GameObject
{
    public bool LeftKeyPressed { get; set; }
    public bool RightKeyPressed { get; set; }
    public PlayerCar(int x, int y, int speed, Image carImage) : base(x, y, speed, carImage) { }

    public override void Move()
    {
        if (LeftKeyPressed && X > 0)
            X -= Speed;

        if (RightKeyPressed && X < 800 - Representation.Width) // optional change Application.Current.MainWindow.Width  instead of 800
            X += Speed;

        Draw();
    }
}
