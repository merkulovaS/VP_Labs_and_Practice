namespace StringInfoLibrary;


public static class StringExtensions
{
    
    public static StringInfo GetStringInfo(this string str)
    {
        if (str == null)
        {
            // Обработка null-строки, возвращаем структуру с нулями.
            return new StringInfo { Length = 0, DigitCount = 0, LetterCount = 0 };
        }

        int digitCount = str.Count(char.IsDigit);
        int letterCount = str.Count(char.IsLetter);

        return new StringInfo
        {
            Length = str.Length,
            DigitCount = digitCount,
            LetterCount = letterCount
        };
    }
}