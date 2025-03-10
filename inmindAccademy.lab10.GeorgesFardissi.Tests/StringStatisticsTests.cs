using Xunit;
using Xunit.Sdk;

namespace inmindAccademy.lab10.GeorgesFardissi.Tests;

public class StringStatisticsTests
{
    [Fact]
    public void CountWords_ShouldReturnCorrectWordCount()
    {
        Assert.Equal(3, StringStatistics.CountWords("Hello World Test"));
    }

    [Fact]
    public void CountCharacters_ShouldReturnCorrectCharacterCount()
    {
        Assert.Equal(11, StringStatistics.CountCharacters("Hello World"));
    }

    [Fact]
    public void MostCommonWord_ShouldReturnMostFrequentWord()
    {
        Assert.Equal("hello", StringStatistics.MostCommonWord("Hello world! Hello again."));
    }
}