using System;

class Program
{
    public static void CalculateRatings(int[] responses)
    {
        int[] frequencies = new int[5];

        foreach (int response in responses)
        {
            if (response >= 1 && response <= 5)
            {
                frequencies[response - 1]++;
            }
        }

        for (int i = 0; i < frequencies.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequencies[i]} people");
        }
    }

    static void Main(string[] args)
    {
        int[] responses = { 2, 2, 3, 4, 3, 4, 5, 2, 3, 3, 4, 5, 1, 3, 4, 3, 2, 4, 5, 3, 2, 3, 4, 2, 5, 4, 3, 2, 4, 3, 5, 2, 3, 4, 2, 5, 2, 3, 4, 3 };
        CalculateRatings(responses);
    }
}

