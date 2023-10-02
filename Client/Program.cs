using Client.Infrastructure;
using Client.Models;

Reader reader = new Reader();
Parser parser = new Parser();
Writer writer = new Writer();

try
{
	string input = reader.ReadFromConsole();
    Person person = parser.Parse(input);
	writer.Write(person);
    Console.WriteLine(person);
    Console.WriteLine("Данные успешно добавлены");
}
catch (Exception exception)
{
	Console.Error.WriteLine(exception.GetType().Name);
	Console.Error.WriteLine(exception.Message);
	Console.Error.WriteLine(exception.StackTrace);
}