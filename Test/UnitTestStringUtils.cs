using Xunit;

namespace Test;

public class UnitTestStringUtils
{
    [Theory]
    [InlineData(double.NaN, "")]
    [InlineData(double.NaN, "    ")]
    [InlineData(-9, "One fish. Two fish. Red fish. Blue fish.")]
    [InlineData(2, "Would you like them here or there? I would not like them here or there. I would not like them anywhere.")]
    [InlineData(3, "Congratulations! Today is your day. You're off to Great Places! You're off and away!")]
    [InlineData(5, "Harry Potter was a highly unusual boy in many ways. For one thing, he hated the summer holidays more than any other time of year. For another, he really wanted to do his homework, but was forced to do it in secret, in the dead of the night. And he also happened to be a wizard.")]
    [InlineData(7, "In my younger and more vulnerable years my father gave me some advice that I've been turning over in my mind ever since.")]
    [InlineData(7, "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, \"and what is the use of a book,\" thought Alice \"without pictures or conversation ?\"")]
    [InlineData(8, "When he was nearly thirteen, my brother Jem got his arm badly broken at the elbow. When it healed, and Jem's fears of never being able to play football were assuaged, he was seldom self-conscious about his injury. His left arm was somewhat shorter than his right; when he stood or walked, the back of his hand was at right angles to his body, his thumb parallel to his thigh.")]
    [InlineData(9, "There are more things in Heaven and Earth, Horatio, than are dreamt of in your philosophy.")]
    [InlineData(10, "It was a bright cold day in April, and the clocks were striking thirteen. Winston Smith, his chin nuzzled into his breast in an effort to escape the vile wind, slipped quickly through the glass doors of Victory Mansions, though not quickly enough to prevent a swirl of gritty dust from entering along with him.")]
    [InlineData(18, "A large class of computational problems involve the determination of properties of graphs, digraphs, integers, arrays of integers, finite families of finite sets, boolean formulas and elements of other countable domains.")]
    public void TestReadability(double expected, string value)
    {
        var actual = StringUtils.StringUtils.Readability(value);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(0, "    ")]
    [InlineData(2, "Hello, World!")]
    public void TestWords(int expected, string value)
    {
        var actual = StringUtils.StringUtils.Words(value);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(0, "    ")]
    [InlineData(10, "Hello, World!")]
    public void TestLetters(int expected, string value)
    {
        var actual = StringUtils.StringUtils.Letters(value);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(1, "    ")]
    [InlineData(1, "Hello, World!")]
    public void TestSentences(int expected, string value)
    {
        var actual = StringUtils.StringUtils.Sentences(value);
        Assert.Equal(expected, actual);
    }
}