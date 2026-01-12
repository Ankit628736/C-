using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] input = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        List<int> numbers = new List<int>();

        foreach (var it in input)
        {
            if (int.TryParse(it, out int x))
            {
                numbers.Add(x * x);
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }
        }

        numbers.Sort();
        Console.WriteLine(string.Join(" ", numbers));
    }
}
