using System;

class Program2
{
    static void Main()
    {
        Console.WriteLine("Even numbers (1-100):");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\nOdd numbers (1-100):");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\nAll numbers (1-100):");
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
        }
    }
}