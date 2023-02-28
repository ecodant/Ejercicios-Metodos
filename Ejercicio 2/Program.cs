
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese el texto");
string text = Console.ReadLine();
Console.WriteLine(knowWords(text));
static int knowWords(string text)
{
    string[] words = Regex.Split(text, @"[,.:;\-!?]" + " ");
    int count = words.Length;
    return count;
}
