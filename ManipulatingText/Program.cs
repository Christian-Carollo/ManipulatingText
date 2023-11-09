using System;

class ManipulatingText
{
    static void Main()
    {
        Console.WriteLine("Inserisci del testo:");
        string input = Console.ReadLine();

        string reversedText = ReverseText(input);

        Console.WriteLine("Testo al contrario: " + reversedText);
    }

    static string ReverseText(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
