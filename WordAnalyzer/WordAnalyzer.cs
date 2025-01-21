namespace WordAnalyzer;
public class Analyzer
{
    public string UserInput()
    {
        Console.WriteLine("Digite uma frase: ");
        string words = Console.ReadLine();
       // words = words.Replace(" ", "");
        return words.Trim(); 
    }
    public string LongestWord(string words)
    {
        List<string> WordList = words.Split(' ').ToList(); 
        var longWord = WordList.OrderByDescending(s => s.Length).First();
        return longWord;
    }
    public string ShortestWord(string words)
    {
        List<string> WordList = words.Split(' ').ToList();
        var shortWord = WordList.OrderByDescending(s => s.Length).Last();
        return shortWord;
    }
    public string FirstWord(string words)
    {
        List<string> WordList = words.Split(' ').ToList();
        var first = WordList.First();
        return first;
    }
    public string LastWord(string words)
    {
        List<string> WordList = words.Split(' ').ToList();
        var last = WordList.Last();
        return last;
    }
    public int QuantityWord(string words)
    {
        List<string> WordList = words.Split(' ').ToList();
        var quantityWord = WordList.Count();
        return quantityWord;
    }
    public int QuantityChar(string words)
    {
        return words.Select(c => c).Count();
    }
    public int AverageChar(string words)
    {
       // List<string> WordList = words.Split(' ').ToList();
        var quantityWord = QuantityWord(words);
        var quantityChar = QuantityChar(words);
        var average = quantityChar / quantityWord;
        return average;
    }
    public void Result()
    {
        var input = UserInput();
        Console.WriteLine($"A maior palavra é: {LongestWord(input)}");
        Console.WriteLine($"A menor palavra é: {ShortestWord(input)}");
        Console.WriteLine($"A primeira palavra é: {FirstWord(input)}");
        Console.WriteLine($"A última palavra é: {LastWord(input)}");
        Console.WriteLine($"A quantidade de palavras é: {QuantityWord(input)}");
        Console.WriteLine($"A quantidade de caracteres é: {QuantityChar(input)}");
        Console.WriteLine($"A quantidade média de caracteres por palavra é: {AverageChar(input)}");
    }
}
