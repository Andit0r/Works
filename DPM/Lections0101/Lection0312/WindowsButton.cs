using System.Security.Cryptography.X509Certificates;

public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("win button");
}
