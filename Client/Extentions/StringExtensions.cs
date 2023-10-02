namespace Client.Extensions;

internal static class StringExtensions
{
    const int PHONE_NUMBER_LENGTH = 10;
    const string DATETIME_FORMAT = "dd.MM.yyyy";
    const string GENDER_MALE = "m";
    const string GENDER_FEMALE = "m";
    
    public static bool IsPhoneNumber(this string word) =>
        word.All(char.IsDigit) && word.Length == PHONE_NUMBER_LENGTH;
    
    public static bool IsDate(this string word) =>
        DateTime.TryParseExact(word, DATETIME_FORMAT, null, System.Globalization.DateTimeStyles.None, out _);


    public static bool IsGender(this string word) =>
        word == GENDER_MALE || word == GENDER_FEMALE;

 
    public static bool IsNullOrEmpty(this string word) => string.IsNullOrEmpty(word);
}