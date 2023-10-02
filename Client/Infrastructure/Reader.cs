using System.Text;
namespace Client.Infrastructure;

internal class Reader
{
       public string ReadFromConsole()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        return Console.ReadLine() ?? string.Empty;
    }
}