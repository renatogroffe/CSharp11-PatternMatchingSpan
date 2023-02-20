using System.Runtime.InteropServices;
using ExemploPatternMatchSpan;

Console.WriteLine("***** Testes com C# 11 | Generic Attributes *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();
Console.WriteLine("**** Testes com ReadOnlySpan<char> ****");
ReadOnlySpan<char> tecnologia01 = "C# 10";
ReadOnlySpan<char> tecnologia02 = "SQL Server 2022";
ReadOnlySpan<char> tecnologia03 = "C# 11";
ReadOnlySpan<char> tecnologia04 = "C# 9";
TestesPatternMatching.IsProgrammingLanguage(tecnologia01);
TestesPatternMatching.IsProgrammingLanguage(tecnologia02);
TestesPatternMatching.IsProgrammingLanguage(tecnologia03);
TestesPatternMatching.IsProgrammingLanguage(tecnologia04);

Console.WriteLine();
Console.WriteLine("**** Testes com Span<char> ****");
Span<char> tecnologia05 = "SQL Server 2000".ToCharArray();
Span<char> tecnologia06 = "C# 8".ToCharArray();
Span<char> tecnologia07 = "SQL Server 2019".ToCharArray();
TestesPatternMatching.IsRelationalDatabase(tecnologia05);
TestesPatternMatching.IsRelationalDatabase(tecnologia06);
TestesPatternMatching.IsRelationalDatabase(tecnologia07);