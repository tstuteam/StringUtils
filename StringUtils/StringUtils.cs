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
        double wordsPer100 = Words(input) / 100.0;
        double L = Letters(input) / wordsPer100;
        double S = Sentences(input) / wordsPer100;
        return Math.Round(0.0588 * L - 0.296 * S - 15.8);
    }

    /// <summary>
    ///     Подсчёт букв в строке.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int Letters(string input)
    {
        int letters = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                letters++;
            }
        }
        return letters;
    }

    /// <summary>
    ///     Подсчёт количества предложений в строке.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int Sentences(string input)
    {
        // TODO: бывают сокращения, в которых используется точка. Например: Mr. Mrs. P.S. и так дале...
        char[] delimiters = { '.', '?', '!' };
        int sentences = Split(input, delimiters).Length;
        return sentences;
    }

    /// <summary>
    ///     Подсчёт количества слов в строке
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int Words(string input)
    {
        char[] delimiters = new char[] { ' ', '\r', '\n' };
        int words = Split(input, delimiters).Length;
        return words;
    }

    private static string[] Split(string input, char[] delimiters)
    {
        return input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    }
}
