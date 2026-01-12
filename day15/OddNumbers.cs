// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string str = Console.ReadLine();
//         List<int> arr = ParseIntegers(str);
//         GetOddNumbers(arr);
//     }
//     private static List<int> ParseIntegers(string input)
//     {
//         List<int> arr = new List<int>();
//         string[] values = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//         foreach(var it in values)
//         {
//             arr.Add(Convert.ToInt32(it));
//         }
//         return arr;
//     }
//     private static void GetOddNumbers(List<int> numbers)
//     {
//         foreach(var it in numbers)
//         {
//             if (it % 2 != 0)
//             {
//                 Console.Write($"{it} ");
//             }
//         }
//     }
// }