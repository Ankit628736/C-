// using System;
// using System.Collections;
// using System.Globalization;
// using System.Text;

// class Program
// {
//     static void Main(string[] args)
//     {
//         StringBuilder sb = new StringBuilder("Hello, World!");

//         for(int i = 0; i < sb.Length; i++)
//         {
//             Console.Write($"{sb[i]}");
//         }

//         StringBuilder sb2 = new StringBuilder();
//         sb2.AppendLine("World");
//         sb2.Append("Hello ");
//         sb2.AppendLine("World");
//         sb2.AppendLine("Hello c#");
//         Console.WriteLine(sb2);

//         StringBuilder sbAmount = new StringBuilder("Your total amount is ");
//         sbAmount.AppendFormat("{0:C}",25);

//         CultureInfo india = new CultureInfo("en-IN");
//         sbAmount.AppendFormat(india,"{0:C}",12213336);


//         Console.WriteLine(sbAmount);

//         StringBuilder sb3 = new StringBuilder("Hello, World");
//         sb.Insert(5," c#");
//         Console.WriteLine(sb3);


//         StringBuilder sb4 = new StringBuilder("Hello world!",50);
//         sb4.Remove(6,6);
//         Console.WriteLine(sb4);
//     }
// }


// public class Employee: IComparable<Employee>
// {
//     public int Id {get;set;}
//     public string name {get;set;}

//     public int CompareTo(Employee other)
//     {
//         return this.Id.CompareTo(other.Id);
//     }

//     public override string ToString()
//     {
//         return $"emp id: {Id} Name: {name}";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         ArrayList list = new ArrayList();
//         list.Add(10);
//         list.Add(20);
//         list.Add(20.05f);
//         list.Add(false);
//         // Console.WriteLine(list.Count);
//         Employee emp1 = new Employee(){Id = 10,name="mohan"};
//         Employee emp2 = new Employee(){Id = 20,name="sohan"};
//         Employee emp3 = new Employee(){Id = 30,name="rohan"};

//         list.Add(emp1);
//         list.Add(emp2);
//         list.Add(emp3);

//         foreach(var it in list)
//         {
//             Console.WriteLine(it);
//         }

//         ArrayList list1 = new ArrayList();
//         list1.Add(50);
//         list1.Add(60);
//         list1.Add(70);
//         list.AddRange(list1);
    
//         foreach(var it in list)
//         {
//             Console.WriteLine(it);
//         }



//         Console.WriteLine($"Count of Array list is {list.Count}");
//         // list.Clear();
//         // Console.WriteLine($"Count of after clear Array list is {list.Count}");

//         if (list.Contains(50))
//         {
//             Console.WriteLine($"Object 50 is at index no: {list.IndexOf(50)}");
//         }
//         else
//         {
//             Console.WriteLine("Object not found");
//         }
//         list.RemoveAt(5);
//         Console.WriteLine("\n\n List After removing value at index 5 range");
//         foreach(var it in list)
//         {
//             Console.WriteLine(it);
//         }
//         list.Remove(false);
//         Console.WriteLine("\n\n List After removing value 5 ");
//         foreach(var it in list)
//         {
//             Console.WriteLine(it);
//         }
//         list.RemoveRange(5,3);
//         Console.WriteLine("\n\n List After removing Range from the list ");
        
//         foreach(var it in list)
//         {
//             Console.WriteLine(it);
//         }
//         // Console.WriteLine("\n\n\n List Before Sorting the list");
//         // list.Sort();
//         // foreach(var it in list)
//         // {
//         //     Console.WriteLine(it);
//         // }

//         Console.WriteLine("\n\n\n after reverse the list");
//         list.Reverse();
//         foreach(var it in list)
//         {
//             Console.WriteLine(it);
//         }


//         ArrayList list2 = new ArrayList();
//         list2.Add(46);
//         list2.Add(44);
//         list2.Add(42);
//         list.InsertRange(5,list2);

//         Console.WriteLine("\n\n\n List after inserting range in the list");
//         foreach(var it in list)
//         {
//             Console.WriteLine(it);
//         }   
//     }
// }



// Write a class Student with properties Name and Age, and a method DisplayInfo().

using System;

class Student
{
    public string Name{get;set;}   
    public int Age{get;set;}

    public void DisplayInfo()
    {
        Console.WriteLine("Name: {Name}, Age: {Age}");
    }
}