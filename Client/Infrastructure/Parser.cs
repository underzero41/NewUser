using Client.Exceptions;
using Client.Extensions;
using Client.Models;

namespace Client.Infrastructure;


internal class Parser
{
    public Person Parse(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Validate(words);

        Person person = new Person();

        foreach (string word in words)
            if (word.IsPhoneNumber())
                person.PhoneNumber = word;
            else if (word.IsDate())
                person.BirthDate = word;
            else if (word.IsGender())
                person.Gender = word == "m" ? "Мужской" : "Женский";
            else
            {
                if (person.LastName.IsNullOrEmpty())
                    person.LastName = word;
                else if (person.FirstName.IsNullOrEmpty())
                    person.FirstName = word;
                else if (person.MiddleName.IsNullOrEmpty())
                    person.MiddleName = word;
            }

        person.Validate();
        return person;
    }
    
    private static void Validate(string[] words)
    {
        if (words.Length > 6) throw new InputDataMoreThanRequiredException();
        if (words.Length < 6) throw new InputDataLessThanRequiredException();
    }
}