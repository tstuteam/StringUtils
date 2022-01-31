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
        int words = input.Split(' ').Length;
        return MinutesToRead(words, wordsPerMinute);
    }

    public static double MinutesToRead(int words, double wordsPerMinute = 150)
    {
        return words / wordsPerMinute;
    }
}
