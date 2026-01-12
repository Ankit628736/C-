// using System;
// using System.Collections.Generic;

// class LindexList
// {
//     static void Main(string[] args)
//     {
//         LinkedList<string> lio = new LinkedList<string>();
//         bool isTrue = true;

//         while (isTrue)
//         {
//             Console.WriteLine("\nLinkedList Operations:");
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

//     static void AddItem(LinkedList<string> lio)
//     {
//         Console.Write("Enter student name to add: ");
//         string? name = Console.ReadLine();

//         if (!string.IsNullOrWhiteSpace(name))
//         {
//             lio.AddLast(name);
//             Console.WriteLine($"{name} added.");
//         }
//         else
//             Console.WriteLine("Invalid name!");
//     }

//     static void DisplayItem(LinkedList<string> lio)
//     {
//         if (lio.Count == 0)
//         {
//             Console.WriteLine("List is empty.");
//             return;
//         }

//         foreach (var it in lio)
//             Console.WriteLine(it);
//     }

//     static void UpdateItem(LinkedList<string> lio)
//     {
//         Console.Write("Enter name to update: ");
//         string? oldName = Console.ReadLine();

//         var node = lio.Find(oldName);
//         if (node == null)
//         {
//             Console.WriteLine("Student not found.");
//             return;
//         }

//         Console.Write("Enter new name: ");
//         string? newName = Console.ReadLine();

//         if (!string.IsNullOrWhiteSpace(newName))
//         {
//             node.Value = newName;
//             Console.WriteLine("Student updated.");
//         }
//         else
//             Console.WriteLine("Invalid name!");
//     }

//     static void DeleteItem(LinkedList<string> lio)
//     {
//         Console.Write("Enter name to delete: ");
//         string? name = Console.ReadLine();

//         if (lio.Remove(name))
//             Console.WriteLine("Student deleted.");
//         else
//             Console.WriteLine("Student not found.");
//     }

//     static void ClearItem(LinkedList<string> lio)
//     {
//         lio.Clear();
//         Console.WriteLine("All students cleared.");
//     }
// }
