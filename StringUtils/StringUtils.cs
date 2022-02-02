namespace StringUtils;

public static class StringUtils
{
    /// <summary>
    ///     Рассчитать время для чтения в минутах.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="wordsPerMinute"></param>
    /// <returns></returns>
    public static double MinutesToRead(string input, double wordsPerMinute = 150)
    {
        return MinutesToRead(Words(input), wordsPerMinute);
    }

    private static double MinutesToRead(int words, double wordsPerMinute = 150)
    {
        return words / wordsPerMinute;
    }

    /// <summary>
    ///     https://en.wikipedia.org/wiki/Coleman%E2%80%93Liau_index
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static double Readability(string input)
    {
        var wordsPer100 = Words(input) / 100.0;
        var letters = Letters(input) / wordsPer100;
        var sentences = Sentences(input) / wordsPer100;
        return Math.Round(0.0588 * letters - 0.296 * sentences - 15.8);
    }

    /// <summary>
    ///     Подсчёт букв в строке.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int Letters(string input)
    {
        return input.Count(char.IsLetter);
    }

    /// <summary>
    ///     Подсчёт количества предложений в строке.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int Sentences(string input)
    {
        // TODO: бывают сокращения, в которых используется точка.
        // Например: Mr. Mrs. P.S. и так далее...
        return Count(input, new char[] { '.', '?', '!' });
    }

    /// <summary>
    ///     Подсчёт количества слов в строке
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int Words(string input)
    {
        return Count(input, new char[] { ' ', '\r', '\n' });
    }

    private static int Count(string input, char[] delimiters)
    {
        return Split(input, delimiters).Length;
    }

    private static string[] Split(string input, char[] delimiters)
    {
        return input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    }
}