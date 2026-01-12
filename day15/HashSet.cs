// using System;
// using System.Collections.Generic;

// class HashSet
// {
//     static void Main(string[] args)
//     {
//         HashSet<string> lio = new HashSet<string>();
//         bool isTrue = true;

//         while (isTrue)
//         {
//             Console.WriteLine("\nHashSet Operations:");
//             Console.WriteLine("1. Add Student");
//             Console.WriteLine("2. Display Students");
//             Console.WriteLine("3. Update Student");
//             Console.WriteLine("4. Delete Student by Name");
//             Console.WriteLine("5. Clear List");
//             Console.WriteLine("6. Exit");

//             if (!int.TryParse(Console.ReadLine(), out int num))
//             {
//                 Console.WriteLine("Enter valid number!");
//                 continue;
//             }

//             switch (num)
//             {
//                 case 1: AddItem(lio); break;
//                 case 2: DisplayItem(lio); break;
//                 case 3: UpdateItem(lio); break;
//                 case 4: DeleteItem(lio); break;
//                 case 5: ClearItem(lio); break;
//                 case 6: isTrue = false; break;
//                 default: Console.WriteLine("Invalid choice!"); break;
//             }
//         }
//     }

//     static void AddItem(HashSet<string> lio)
//     {
//         Console.Write("Enter student name to add: ");
//         string? name = Console.ReadLine();

//         if (!string.IsNullOrWhiteSpace(name))
//         {
//             if (lio.Contains(name))
//             {
//                 Console.WriteLine($"{name} already exists in the set.");
//             }
//             else
//             {
//                 lio.Add(name);
//                 Console.WriteLine($"{name} added.");
//             }
//         }
//         else
//             Console.WriteLine("Invalid name!");
//     }

//     static void DisplayItem(HashSet<string> lio)
//     {
//         if (lio.Count == 0)
//         {
//             Console.WriteLine("List is empty.");
//             return;
//         }

//         foreach (var it in lio)
//             Console.WriteLine(it);
//     }

//     static void UpdateItem(HashSet<string> lio)
//     {
//         Console.Write("Enter Student Name: ");
//         string? n = Console.ReadLine();
//         if (!lio.Contains(n))
//         {
//             Console.WriteLine("Student not found.");
//             return;
//         }
//         Console.Write("Enter new Name: ");
//         string? newName = Console.ReadLine();
//         lio.Remove(n);
//         lio.Add(newName);
//     }

//     static void DeleteItem(HashSet<string> lio)
//     {
//         Console.Write("Enter name you want to delete: ");
//         string? name1 = Console.ReadLine();
//         if (lio.Remove(name1))
//         {
//             Console.WriteLine($"{name1} is delete from Hashset");
//         }
//         else
//         {
//             Console.WriteLine($"{name1} is not find in Hashset");
//         }
//     }

//     static void ClearItem(HashSet<string> lio)
//     {
//         lio.Clear();
//         Console.WriteLine("All Student Data clear");
//     }
// }
