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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="words"></param>
    /// <param name="wordsPerMinute"></param>
    /// <returns></returns>
    public static double MinutesToRead(int words, double wordsPerMinute = 150)
    {
        return words / wordsPerMinute;
    }

    /// <summary>
    /// https://en.wikipedia.org/wiki/Coleman%E2%80%93Liau_index
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static double Readability(string input)
    {
        return 0.0588 * ((Letters(input) / Words(input)) * 100) -
            0.296 * ((Sentences(input) / Words(input)) * 100) - 15.8;
    }

    public static int Letters(string input)
    {
        int result = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                result++;
            }
        }
        return result;
    }

    public static int Sentences(string input)
    {
        int result = 0;
        foreach (char c in input)
        {
            if (c == '.' || c == '?' || c == '!')
            {
                result++;
            }
        }
        return result;
    }

    /// <summary>
    /// TODO: бывают предложения, где много пробелов подряд
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int Words(string input)
    {
        return input.Split(' ').Length;
    }
}
