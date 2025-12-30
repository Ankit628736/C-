using System;
using System.Xml.Schema;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Declare first name and last name
//         string fname, lname;
//         fname = "Rowan";
//         lname = "Atkinson";

//         // Store characters in char array
//         char[] letter = { 'H', 'e', 'l', 'l', 'o' };

//         // Combine first name and last name
//         string fullname = fname + " " + lname;
//         Console.WriteLine("Full Name: {0}", fullname);

//         // Convert char array to string
//         string greeting = new string(letter);
//         Console.WriteLine("Greeting: {0}", greeting);

//         // String array to join words
//         string[] sarray = { "Hello", "From", "Points" };

//         // Join string array elements using space
//         string message = string.Join(" ", sarray);
//         Console.WriteLine("Message: {0}", message);

//         // Create DateTime object
//         DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);

//         // Format DateTime into string
//         string format = string.Format("Waiting until: {0:MM/dd/yy HH:mm:ss}", waiting);
//         Console.WriteLine(format);

//         // Compare two strings
//         string str1 = "This is test";
//         string str2 = "This is text";

//         if (String.Compare(str1, str2) == 0)
//         {
//             Console.WriteLine($"{str1} and {str2} are equal");
//         }
//         else
//         {
//             Console.WriteLine($"{str1} and {str2} are not equal");
//         }

//         // Check if string contains a word
//         string str = "This is test";
//         if (str.Contains("test"))
//         {
//             Console.WriteLine($"{str} has 'test' in it");
//         }

//         // Substring example
//         string str3 = "Last night I dream of San Pedro";
//         Console.WriteLine(str3);

//         // Extract substring from index 5
//         string substr = str3.Substring(5);
//         Console.WriteLine(substr);

//         // Escape character examples
//         Console.WriteLine("Hello\nWorld");                // New line
//         Console.WriteLine("\"HelloWorld\"");              // Double quotes
//         Console.WriteLine("D:\\Project\\csharp\\Program.cs"); // Escaped path
//         Console.WriteLine(@"D:\Project\csharp\Program.cs");   // Verbatim string

//         // Verbatim multi-line string example
//         var messge = @"Hello Alice,
//     Good morning!
//     Your files have been saved to this location
//     \shared\files

//     Thanks.";
//         Console.WriteLine(messge);


//         //3.var
//         var name1 = "Rohan";
//         var num = 12;
//         Console.WriteLine($"Name: {name1},Age: {num}");

//         var name = "Sachin";
//         var greeting1 = String.Format("Hello {0},\nGood morning!", name);
//         Console.WriteLine(greeting1);

//         // string str10 = "Hello";
//         // string str11 = "Hello";
//         var str10 = "Hello";
//         var str11 = "Hello";
//         if (str10 == str11)
//         {
//             Console.WriteLine("equal");
//         }
//         if (String.Compare(str10, str11) == 0)
//         {
//             Console.WriteLine("equal");
//         }
//         var greeeting2 = "Hello, World!";
//         var str5 = greeeting2.Substring(6, 5);
//         Console.WriteLine(str5);

//         var str6 = "   Hello world  ";
//         var trimString = str6.Trim();
//         Console.WriteLine(trimString);

//         var greeeting3 = "Hello, World!";
//         var index = greeeting3.IndexOf("lo");
//         Console.WriteLine(index);

//         var csv = "Alices,Bob,chris,Vave,Eric,Fred";
//         var names = csv.Split(',');
//         foreach(var it in names)
//         {
//             Console.Write($"{it} ");
//         }
//         var gree4 = "Hello Alice Welcome";
//         var index4 = gree4.LastIndexOf("el");
//         Console.WriteLine(index4);


//         int[][] j_arr = new int[4][];
//         j_arr[0] = new int[]{1,2,3,4};
//         j_arr[1] = new int[]{1,2};
//         j_arr[2] = new int[]{1,2,3};
//         j_arr[3] = new int[]{1,2,3,4};

//         for(int i = 0; i < j_arr.Length; i++)
//         {
//             Console.Write($"Row {i} ");
//             for(int j = 0; j < j_arr[i].Length; j++)
//             {
//                 Console.Write($"{j_arr[i][j]}");
//             }
//             Console.WriteLine();
//         }


//     }
// }


class Program
{
    static void Main(string[] args)
    {
        
    }
}