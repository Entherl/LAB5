using System;

class Program
{
    // Method to convert Decimal to Binary
    public static string DecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }

    // Method to convert Binary to Decimal
    public static int BinaryToDecimal(string binaryNumber)
    {
        return Convert.ToInt32(binaryNumber, 2);
    }

    static void Main(string[] args)
    {
        // Decimal to Binary
        Console.Write("Enter a decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binary = DecimalToBinary(decimalNumber);
        Console.WriteLine($"Binary equivalent: {binary}");

        // Binary to Decimal
        Console.Write("\nEnter a binary number:");
        string binaryNumber = Console.ReadLine();
        int decimalEquivalent = BinaryToDecimal(binaryNumber);
        Console.WriteLine($"Decimal equivalent: {decimalEquivalent}");
    }
}

