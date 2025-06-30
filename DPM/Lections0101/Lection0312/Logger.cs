using System.Threading.Channels;

namespace Lection0312
{
    public class Logger
    {
        private static readonly Logger _instance = new();

        private Logger() { }

        public void Log(string message) => Console.WriteLine(message);

        public static Logger GetInstance() => _instance;
    }
}