using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] marks = new int[5, 10]; // 5 rows for courses, 10 columns for students

        // Initializing array with random marks between 50 and 100
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                marks[i, j] = random.Next(50, 101);
            }
        }

        // Displaying the marks and calculating averages
        Console.WriteLine("Student\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\tAvg.");
        for (int i = 0; i < 5; i++)
        {
            int sum = 0;
            Console.Write($"Test {i + 1}\t");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{marks[i, j]}\t");
                sum += marks[i, j];
            }
            Console.WriteLine($"{(sum / 10.0):F2}");
        }
    }
}

