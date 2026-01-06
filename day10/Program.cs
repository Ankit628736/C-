// using System;
// using System.Collections;
// class Program
// {
//     static void Main(string[] args)
//     {
// Hashtable hashtable = new Hashtable();
// hashtable.Add(200,"Rajesh");
// hashtable.Add(300,"Rakesh");
// hashtable.Add(400,"Mukesh");
// hashtable.Add(500,"Surash");

// ICollection key = hashtable.Keys;
// Console.WriteLine("All the key");
// foreach(var it in key)
// {
//     Console.WriteLine(it);
// }
// ICollection value = hashtable.Values;
// Console.WriteLine("All values");
// foreach(var it in value)
// {
//     Console.WriteLine(it);
// }
// ICollection key1 = hashtable.Keys;
// Console.WriteLine("Keys and value");
// foreach(var it in key1)
// {
//     Console.WriteLine($"key is {it} and value is {hashtable[it]}");
// }




// Console.WriteLine("Search key and value");
// int key2 = int.Parse(Console.ReadLine());
// if (hashtable.ContainsKey(key2))
// {
//     Console.WriteLine($"Found {key2} with value {hashtable[key2]}");
// }
// else
// {
//     Console.WriteLine("Key is not found");
// }



//         SortedList list = new SortedList();
//         list.Add(500,"Rajesh");
//         list.Add(400,"Mukesh");
//         list.Add(300,"Rohan");
//         list.Add(200,"Sohan");
//         list.Add(100,"Jon");

//         ICollection key = list.Keys;
//         Console.WriteLine("All key are: ");
//         foreach(var it in key)
//         {
//             Console.WriteLine(it);
//         }

//         ICollection value = list.Values;
//         Console.WriteLine("All values are: ");
//         foreach(var it in value)
//         {
//             Console.WriteLine(it);
//         }
//         ICollection key1 = list.Keys;
//         Console.WriteLine("All keys and values: ");
//         foreach(var it in key1)
//         {
//             Console.WriteLine($"keys {it} and value {list[it]}");
//         }
//         Console.WriteLine($"Index 0 having key {list.IndexOfKey(0)} value {list.IndexOfValue(0)}");
//         list.Clear();
//         Console.WriteLine("After clear");
//         Console.WriteLine("All key and value are");
//         foreach(var it in key1)
//         {
//             Console.WriteLine($"keys {it} and value {list[it]}");
//         }
//         int count = list.Count;
//         Console.WriteLine($"Count is {count}");
//     }
// }



// using System;
// using System.Collections;

// class Program
// {
//     static void Main()
//     {
//         Stack st = new Stack();

//         st.Push("A");
//         st.Push("B");
//         st.Push("C");

//         Console.WriteLine("Stack elements:");
//         foreach (var it in st)
//         {
//             Console.Write(it + " ");
//         }

//         Console.WriteLine("\nTop element (Peek) = " + st.Peek());

//         Console.WriteLine("Removed element (Pop) = " + st.Pop());

//         Console.WriteLine("After Pop:");
//         foreach (var it in st)
//         {
//             Console.Write(it + " ");
//         }

//         Console.WriteLine("\nContains B? " + st.Contains("B"));


//         Console.WriteLine("Count = " + st.Count);


//         object[] arr = st.ToArray();
//         Console.WriteLine("Stack to Array:");
//         foreach (var i in arr)
//         {
//             Console.Write(i + " ");
//         }

//         // Clear()
//         st.Clear();
//         Console.WriteLine("\nAfter Clear Count = " + st.Count);
//     }
// }




// using System;
// using System.Collections;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // var x = 10;
//         // x = "Mohna";

//         // dynamic y = 10;
//         // y = "Mohan";
//         object o;
//         int i=10;
//         o=i;//boxing

//         int j=(int)o; // unboxing
//         ArrayList list = new ArrayList();
//         list.Add(10);
//         list.Add(false);
//         list.Add(65.5f);

//         int k = (int)list[0];
//         var v = list[1];
//         bool t = (bool)v;
//     }
// }


// using System;
// using System.Collections;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         AddClass addClass = new AddClass();

//         int sumInt = addClass.AddInt(30, 20);
//         Console.WriteLine("Sum of integers is: {0}", sumInt);

//         float sumFloat = addClass.AddFloat(30.15f, 20.15f);
//         Console.WriteLine("Sum of float: {0}", sumFloat);

//         string concat = addClass.AddString("Hello ", "World");
//         Console.WriteLine("Concatenation of string is: {0}", concat);

//         AddGenericClass<int> addInteger1 = new AddGenericClass<int>();
//         int sumInt1 = addInteger1.AddAllType(30, 20);
//         Console.WriteLine("Generic Sum of integer: {0}", sumInt1);

//         AddGenericClass<float> addFloat1 = new AddGenericClass<float>();
//         float sumFloat1 = addFloat1.AddAllType(10.5f, 5.5f);
//         Console.WriteLine("Generic Sum of float: {0}", sumFloat1);

//         SubtrcationClass<int> sub = new SubtrcationClass<int>();
//         int mini = sub.SubtractionMethod(5,3);
//         Console.WriteLine($"Generic min of int is {mini}");
//     }
// }

// class AddClass
// {
//     public int AddInt(int a, int b)
//     {
//         return a + b;
//     }

//     public float AddFloat(float a, float b)
//     {
//         return a + b;
//     }

//     public string AddString(string a, string b)
//     {
//         return a + b;
//     }
// }

// class AddGenericClass<T>
// {
//     public T AddAllType(T a, T b)
//     {
//         dynamic x = a;
//         dynamic y = b;
//         return x + y;
//     }
// }


// class SubtrcationClass<T>
// {
//     public T SubtractionMethod(T a,T b)
//     {
//         dynamic x = a;
//         dynamic y = b;
//         return x-y;
//     }
// }



// using System;
// using System.Collections.Generic;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Employee employee1 = new Employee()
//         {
//             Id = 10,
//             Name = "Rajesh"
//         };

//         Employee employee2 = new Employee()
//         {
//             Id = 20,
//             Name = "Ramesh"
//         };

//         List<Employee> employees = new List<Employee>();
//         employees.Add(employee1);
//         employees.Add(employee2);

//         Console.WriteLine("----- Employee List -----");
//         foreach (Employee e in employees)
//         {
//             Console.WriteLine(e);
//         }

//         Dictionary<int, string> directory = new Dictionary<int, string>();
//         directory.Add(100, "Rajesh");
//         directory.Add(200, "Suresh");

//         Console.WriteLine("\n----- Dictionary Data -----");
//         foreach (KeyValuePair<int, string> item in directory)
//         {
//             Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//         }

//         SortedList<string, string> pair = new SortedList<string, string>();
//         pair.Add("100", "Rohan");
//         pair.Add("200", "Sohan");
//         pair.Add("300", "Mohan");
//         Console.WriteLine("\n\nGeneric Sorted List ");
//         foreach (var it in pair)
//         {
//             Console.WriteLine($"key: {it.Key} Value: {it.Value}");
//         }

//         Console.WriteLine("\n----- STACK OPERATIONS -----");

//         Stack<char> stack = new Stack<char>();
//         stack.Push('A');
//         stack.Push('B');
//         stack.Push('C');
//         stack.Push('D');

//         foreach (var s in stack)
//         {
//             Console.WriteLine(s);
//         }

//         Console.WriteLine("Top Element: " + stack.Peek());
//         Console.WriteLine("Stack contains B: " + stack.Contains('B'));
//         Console.WriteLine("Popped Element: " + stack.Pop());
//         Console.WriteLine("Total Elements: " + stack.Count);

//         stack.Clear();
//         Console.WriteLine("After Clear, Count = " + stack.Count);

//         Console.WriteLine("\n----- QUEUE OPERATIONS -----");

//         Queue<char> queue = new Queue<char>();
//         queue.Enqueue('X');
//         queue.Enqueue('Y');
//         queue.Enqueue('Z');
//         queue.Enqueue('W');

//         foreach (var q in queue)
//         {
//             Console.Write(q + " ");
//         }

//         Console.WriteLine("\nFront Element: " + queue.Peek());
//         Console.WriteLine("Queue contains Y: " + queue.Contains('Y'));
//         Console.WriteLine("Removed Element: " + queue.Dequeue());
//         Console.WriteLine("Total Elements: " + queue.Count);

//         queue.Clear();
//         Console.WriteLine("After Clear, Count = " + queue.Count);

//     }
// }

// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public override string ToString()
//     {
//         return $"Id: {Id}, Name: {Name}";
//     }
// }



using System;
using System.Collections;

class MyCollection : IEnumerable
{
    int[] data = {1,2,3};
    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        MyCollection obj = new MyCollection();
        foreach(var it in obj)
        {
            Console.WriteLine(it);
        }
    }
}