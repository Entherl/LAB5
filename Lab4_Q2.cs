using System;

class Program
{
    public static string Merger(string[] strings)
    {
        return string.Concat(strings);
    }

    static void Main(string[] args)
    {
        string[] s = { "hello ", "and ", "welcome ", "to ", "this ", "demo!" };
        Console.WriteLine(Merger(s));  // Output: "hello and welcome to this demo!"
    }
}

