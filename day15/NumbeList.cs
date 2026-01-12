// using System;
// using System.Collections;

// class Program
// {
//     static void Add(ArrayList newNumber,int num)
//     {
//         if (num < 0)
//         {
//             throw new ArgumentException("Number must be greater than 0");
//         }
//         newNumber.Add(num);
//     }
//     static void remove(ArrayList newNumber,int num)
//     {
//         if (newNumber.Contains(num))
//         {
//             newNumber.Remove(num);
//             Console.WriteLine($"{num} is remove from Student list");
//         }
//         else
//         {
//             Console.WriteLine($"{num} is not fount in Student list");
//         }
//     }
//     static void Main(string[] args)
//     {
//         try
//         {
//             ArrayList newNumber = new ArrayList();
//         bool isRunning = true;
//         while (isRunning)
//         {
//             string str = Console.ReadLine().ToLower();
//             switch (str)
//             {
//                 case "add":
//                     int x = int.Parse(Console.ReadLine());
//                     Add(newNumber,x);
//                     break;
//                 case "remove":
//                     int y = int.Parse(Console.ReadLine());
//                     remove(newNumber,y);
//                     break;
//                 case "display":
//                     Console.WriteLine("Display all number is ArrayList: ");
//                     foreach(var it in newNumber)
//                     {
//                         Console.WriteLine(it);
//                     }
//                     break;
//                 case "exit":
//                     isRunning = false;
//                     break;
//                 default:
//                     Console.WriteLine("Please Enter valid opration!");
//                     break;
//             }
//         }
//         }catch(ArgumentException e)
//         {
//             Console.WriteLine(e.Message);
//         }catch(Exception e)
//         {
//             Console.WriteLine(e.Message.ToString());
//         }
//     }
// }

