// using System;
// using System.Collections;

// public class Program
// {
//     public string Title{get;set;}
//     public string Artist{get;set;}

//     static bool IsValidInput(string str)
//     {
//         if (string.IsNullOrWhiteSpace(str))
//         {
//             return false;
//         }
//         return true;
//     }
//     static void Display(ArrayList nums)
//     {
//         foreach(Program it in nums)
//         {
//             Console.WriteLine($"Auther: {it.Artist} Title: {it.Title}");
//         }
//     }
//     static void Main(string[] args)
//     {
//         try
//         {
//             ArrayList obj = new ArrayList();
//             while (true)
//             {
//                 string str1 = Console.ReadLine();
//                 if((str1.ToLower() == "quit")) break;
//                 string str2 = Console.ReadLine();
//                 if(str2.ToLower() == "quit") break;
//                 if(IsValidInput(str1) || IsValidInput(str2))
//                 {
//                     obj.Add(new Program()
//                     {
//                         Title = str1,
//                         Artist = str2
//                     });
//                 }
//             }
//             Display(obj);
//         }catch(InvalidOperationException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//     }
// }