namespace StringInfoLibrary;


public struct StringInfo
{
  
    public int Length { get; init; }

  
    public int DigitCount { get; init; }

   
    public int LetterCount { get; init; }

    
    public override readonly string ToString()
    {
        return $"Длина: {Length}, Цифр: {DigitCount}, Букв: {LetterCount}";
    }
}