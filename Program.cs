using System;
class Program
{
    static void Main()
    {
        int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.WriteLine("matrix:");
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
                Console.Write(arr1[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("transpose:");
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
                Console.Write(arr1[j, i] + " ");
            Console.WriteLine();
        }
    }
}
