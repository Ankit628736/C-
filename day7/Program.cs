using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];

        arr[0, 0] = 10;
        arr[0, 1] = 20;
        arr[0, 2] = 30;
        arr[1, 0] = 40;
        arr[1, 1] = 50;
        arr[1, 2] = 60;
        arr[2, 0] = 70;
        arr[2, 1] = 80;
        arr[2, 2] = 90;

        Console.WriteLine("Element of 3 x 3 Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("\nEnter Number Of Rows: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter Number Of Columns: ");
        int l = int.Parse(Console.ReadLine());

        int[,] arr1 = new int[k, l];

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                arr1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatrix Elements are:");
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
