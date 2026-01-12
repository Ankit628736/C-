// using System;
// using System.Collections.Generic;

// class Student
// {
//     public int Id{get;set;}
//     public string Name{get;set;} = "";
//     public string Grade{get;set;} = "";
// }

// class StudentManager
// {
//     public Dictionary<int,string> students = new Dictionary<int, string>();
//     public void AddStudent(Student student)
//     {
//         students[student.Id] = student.Name;
//     }
//     public void DisplayStudents()
//     {
//         foreach(var it in students)
//         {
//             Console.WriteLine($"Id: {it.Key}, Name: {it.Value}");
//         }
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         StudentManager sm = new StudentManager();
//         int n = int.Parse(Console.ReadLine());
//         for(int i = 0; i < n; i++)
//         {
//             int id = int.Parse(Console.ReadLine());
//             Console.WriteLine("Enter name");
//             string name = Console.ReadLine();
//             string grade = Console.ReadLine();

//             sm.AddStudent(new Student()
//             {
//                 Id = id,
//                 Name = name,
//                 Grade = grade,
//             });
//         }
//         sm.DisplayStudents();
//     }
// }