using Client.Exceptions;
using Client.Extensions;
using System.Text;

namespace Client.Models;

/// <summary>
/// Хранит данные очеловеке
/// </summary>
internal class Person
{
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string BirthDate { get; set; } = string.Empty;   
    public string Gender { get; set; } = string.Empty;
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Фамилия       : {LastName}");
        builder.AppendLine($"Имя           : {FirstName}");
        builder.AppendLine($"Отчетство     : {MiddleName}");
        builder.AppendLine($"Дата рождения : {BirthDate}");
        builder.AppendLine($"Номер телефона: {PhoneNumber}");
        builder.AppendLine($"Пол           : {Gender}\r\n");
        return builder.ToString();
    }
    public string ToStringInline()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append($"{LastName} ");
        builder.Append($"{FirstName} ");
        builder.Append($"{MiddleName} ");
        builder.Append($"{BirthDate} ");
        builder.Append($"{PhoneNumber} ");
        builder.Append($"{Gender}\r\n");
        return builder.ToString();
    }
    public void Validate()
    {
        if (LastName.IsNullOrEmpty()) throw new LastNameCantReadException();
        if (FirstName.IsNullOrEmpty()) throw new FirstNameCantReadException();
        if (MiddleName.IsNullOrEmpty()) throw new MiddleNameCantReadException();
        if (BirthDate.IsNullOrEmpty()) throw new BirthDateCantReadException();
        if (PhoneNumber.IsNullOrEmpty()) throw new PhoneNumberCantReadException();
        if (Gender.IsNullOrEmpty()) throw new GenderCantReadException();
    }
}