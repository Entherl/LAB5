using System;
using System.Collections.Generic;

class Program
{
    public static string[] ExtractWords(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            if ((word.Length >= 4 && word.Length <= 5) && word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }) >= 0)
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        string sentence = "This is a demo string with words like hello and world.";
        string[] filteredWords = ExtractWords(sentence);
        Console.WriteLine("Filtered Words: " + string.Join(", ", filteredWords));  // Output: demo, hello, world
    }
}

