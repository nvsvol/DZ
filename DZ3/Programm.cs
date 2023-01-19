using System;
using System.Linq;

class AtbashCipher
{
    private static readonly string _alphabet = "àáâãäå¸æçèéêëìíîïðñòóôõö÷øùúûüýþÿ";

    public static string Encrypt(string text)
    {
        return new string(text.Select(c => _alphabet[_alphabet.Length - _alphabet.IndexOf(c) - 1]).ToArray());
    }

    public static string Decrypt(string text)
    {
        return Encrypt(text);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string text = Console.ReadLine();
        string encrypted = AtbashCipher.Encrypt(text);
        Console.WriteLine("Encrypted text: {0}", encrypted);

        Console.WriteLine("Enter text to decrypt:");
        text = Console.ReadLine();
        string decrypted = AtbashCipher.Decrypt(text);
        Console.WriteLine("Decrypted text: {0}", decrypted);

        Console.ReadLine();
    }
}
