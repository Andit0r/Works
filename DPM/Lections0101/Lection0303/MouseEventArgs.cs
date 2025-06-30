using System.Drawing;

public class MouseEventArgs : EventArgs
{
    public MouseEventArgs(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }
    public int Y { get; }
    public Point Location => new(X, Y);
}
