using Client.Exceptions;
using Client.Models;

namespace Client.Infrastructure;
internal class Writer
{
    const string FOLDER_NAME = "Data";
    const string FILE_EXTENSION = ".txt";
    public void Write(Person person)
    {
        if (person == null) throw new PersonIsNullException();

        if (!Directory.Exists(FOLDER_NAME))  
            Directory.CreateDirectory(FOLDER_NAME); 

        string filename = $"{FOLDER_NAME}/{person.LastName}{FILE_EXTENSION}";
        File.AppendAllText(filename, person.ToStringInline());
    }
}