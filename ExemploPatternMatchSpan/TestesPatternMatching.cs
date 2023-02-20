namespace ExemploPatternMatchSpan;

public static class TestesPatternMatching
{
    public static void IsProgrammingLanguage(ReadOnlySpan<char> tecnologia)
    {
        if (tecnologia is "C# 11")
            Console.WriteLine($"{tecnologia} = versão mais recente da linguagem");
        else if (tecnologia is ['C', '#', ..])
            Console.WriteLine($"{tecnologia} = linguagem para desenvolvimento em .NET");
        else
            Console.WriteLine($"{tecnologia} = outro tipo de tecnologia");
    }

    public static void IsRelationalDatabase(Span<char> tecnologia)
    {
        if (tecnologia is ['S', 'Q', 'L', ..])
            Console.WriteLine($"{tecnologia} = banco de dados relacional");
        else
            Console.WriteLine($"{tecnologia} = outro tipo de tecnologia");
    }
}