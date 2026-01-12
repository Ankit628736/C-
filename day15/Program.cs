// using System;
// using System.Collections;

// class Program
// {
//     private static bool IsValidName(string name)
//     {
//         if(name == "") return false;
//         return true;
//     }
//     private static bool IsNameInCollection(ArrayList studentNames, string name)
//     {
//         foreach(var it in studentNames)
//         {
//             if(it.ToString() == name) return true;
//         }
//         return false;
//     }
//     static void Main(string[] args)
//     {
//         ArrayList studentNames = new ArrayList();
//         while (true)
//         {
//             string str = Console.ReadLine();
//             if ("stop" == str.ToLower()) break;
//             if (IsValidName(str))
//             {
//                 if (!IsNameInCollection(studentNames, str.ToLower()))
//                 {
//                     studentNames.Add(str);
//                     Console.WriteLine($"{str} added to the collection.");
//                 }
//             }
//         }
//         Console.WriteLine($"Unique student names entered:");
//         foreach (var it in studentNames)
//         {
//             Console.WriteLine(it);
//         }
//     }
// }

// internal class ArrayList<T>
// {
// }