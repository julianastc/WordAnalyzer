using WordAnalyzer;
namespace WordAnalyzerUnitTest;

public class AnalyzerUnitTest
{
    [Theory]

    [InlineData("uma frase qualquer", "qualquer")]
    [InlineData( "O sol brilhava intensamente enquanto as crianças brincavam no parque", "intensamente")]
    [InlineData( "Um gato preto misterioso atravessou silenciosamente a rua deserta","silenciosamente")]
    public void LongestWord_ReceiveString_ReturnLongestWord(string words, string longWord)
    {
        // act
        var analyzer = new Analyzer();
        var result = analyzer.LongestWord(words);

        // assert 
        Assert.Equal(longWord, result);
    }

    [Theory]
    [InlineData("uma frase qualquer", "uma")]
    [InlineData( "O sol brilhava intensamente enquanto as crianças brincavam no parque", "O")]
    [InlineData( "Um gato preto misterioso atravessou silenciosamente a rua deserta","a")]


    public void ShortestWord_ReceiveString_ReturnShortestWord(string words, string shortWord)
    {
        // act
        var analyzer = new Analyzer();
        var result = analyzer.ShortestWord(words);

        // assert
        Assert.Equal(shortWord, result);
    }

    [Theory]
    [InlineData("uma frase qualquer", "uma")]
    [InlineData( "O sol brilhava intensamente enquanto as crianças brincavam no parque", "O")]
    [InlineData( "Um gato preto misterioso atravessou silenciosamente a rua deserta","Um")]


    public void FirstWord_ReceiveString_ReturnFirstWord(string words, string first)
    {
        // act
        var analyzer = new Analyzer();
        var result = analyzer.FirstWord(words);

        // assert
        Assert.Equal(first, result);
    }

    [Theory]
    [InlineData("uma frase qualquer", "qualquer")]
    [InlineData( "O sol brilhava intensamente enquanto as crianças brincavam no parque", "parque")]
    [InlineData( "Um gato preto misterioso atravessou silenciosamente a rua deserta","deserta")]
    public void LastWord_ReceiveString_ReturnLastWord(string words, string last)
    {
        // act
        var analyzer = new Analyzer();
        var result = analyzer.LastWord(words);

        // assert
        Assert.Equal(last, result);
    }

    [Theory]
    [InlineData("uma frase qualquer", 3)]
    [InlineData( "O sol brilhava intensamente enquanto as crianças brincavam no parque", 10)]
    [InlineData( "Um gato preto misterioso atravessou silenciosamente a rua deserta",9)]
    public void QuantityWord_ReceiveString_ReturnQuantityWord(string words, int quantityWord)
    {
        // act 
        var analyzer = new Analyzer();
        var result = analyzer.QuantityWord(words);

        // assert
        Assert.Equal(quantityWord, result);
    }


    [Theory]
    [InlineData("uma frase qualquer", 18)]
    [InlineData( "O sol brilhava intensamente enquanto as crianças brincavam no parque", 68)]
    [InlineData( "Um gato preto misterioso atravessou silenciosamente a rua deserta", 65)]
    

  //  [InlineData()]
    public void QuantityChar_ReceiveString_ReturnQuantityChar(string words, int quantityChar)
    {
        // act
        var analyzer = new Analyzer();
        var result = analyzer.QuantityChar(words);

        // assert
        Assert.Equal(quantityChar, result);
    }
    [Theory]
    [InlineData("uma frase qualquer", 6)]
    [InlineData( "O sol brilhava intensamente enquanto as crianças brincavam no parque", 6)]
    [InlineData( "Um gato preto misterioso atravessou silenciosamente a rua deserta", 7)]
    public void AverageChar_ReceiveString_ReturnAverageChar(string words, int average)
    {
        // act
        var analyzer = new Analyzer();
        var result = analyzer.AverageChar(words);

        // assert 
        Assert.Equal(average, result);
    }
}

