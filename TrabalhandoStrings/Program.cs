using System;

namespace TrabalhandoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var paragrafo = "   C# é uma linguagem moderna de versátil." +
                "Com C# consigo desenvolver para web, DeskTop, Jogos, " +
                "Mobile, entre outros. ";
            // Length
            var tamanho = paragrafo.Length;

            // Empty
            var vazio = string.Empty;

            // ToLower, ToUpper
            var fraseMinuscula = paragrafo.ToLower();
            var fraseMaiuscula = paragrafo.ToUpper();

            // Split
            var frases = paragrafo.Split('.');

            // Trim, TrimEnd, TrimStart
            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimEnd = paragrafo.TrimEnd();
            var paragrafoTrimStart = paragrafo.TrimStart();

            // InsNullOrWhitespace
            var insNullOrWhitespace = string.IsNullOrWhiteSpace(paragrafo);

            // Replace
            var paragrafoCsharp = paragrafo.Replace("C#", "C-Sharp");

            Console.ReadKey();


        }
    }
}
