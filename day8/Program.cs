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
        // Question 1
        // Console.Write("Enter your name: ");
        // var Name = Console.ReadLine();
        // Console.WriteLine(Name);

        // Question 2
        // string[] NameArr = new string[10];
        // for(int i = 0; i < 10; i++)
        // {
        //     NameArr[i] = Console.ReadLine();
        // }
        // foreach(var it in NameArr)
        // {
        //     Console.WriteLine(it);
        // }

        // Question 3
        // string[,] name = new string[2,2];
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 2; j++)
        //     {
        //         name[i,j] = Console.ReadLine();
        //     }
        // }
        // Console.WriteLine("Name is here");
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 2; j++)
        //     {
        //         Console.WriteLine(name[i,j]);
        //     }
        // }


        // Question 5 transpose of matrix
        // int[,] name = new int[2, 2];
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         name[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // Console.WriteLine("Current element: ");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"{name[i, j]} ");
        //     }
        //     Console.WriteLine();
        // }
        // int[,] tran = new int[2,2];
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         tran[j, i] = name[i, j];
        //     }
        // }
        // Console.WriteLine("transpose element: ");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"{tran[i, j]} ");
        //     }
        //     Console.WriteLine();
        // }

        // Question 6 Add to matrix
        // int[,] arr1 = new int[2, 2];
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         arr1[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // int[,] arr2 = new int[2, 2];
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         arr2[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // int[,] arr3 = new int[2,2];
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 2; j++)
        //     {
        //         arr3[i,j] = arr1[i,j]+arr2[i,j];
        //     }
        // }
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"{arr3[i,j]} ");
        //     }
        //     Console.WriteLine();
        // }

        // Question 7 matrix multiplication
        // int[,] arr1 = new int[2, 2];
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         arr1[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // int[,] arr2 = new int[2, 2];
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         arr2[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // int[,] arr3 = new int[2,2];
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 2; j++)
        //     {
        //         for(int k = 0; k < 2; k++)
        //         {
        //             arr3[i,j] += arr1[i,k] * arr2[k,j]; 
        //         }
        //     }
        // }
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"{arr3[i,j]} ");
        //     }
        //     Console.WriteLine();
        // }

        // Question 8 digonal matrix
        // int[,] arr1 = new int[2, 2];
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         arr1[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // bool istrue = true;
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 2; j++)
        //     {
        //         if(i!=j && arr1[i,j] != 0)
        //         {
        //             istrue = false;
        //             break;
        //         }
        //     }
        // }
        // if (istrue)
        // {
        //     Console.WriteLine("Is a digonal matrix");
        // }
        // else
        // {
        //     Console.WriteLine("Is not digonal matrxi");
        // }

        // Question 9 reverse a string
        // string name = Console.ReadLine();
        // string rev = new string(name.ToCharArray().Reverse().ToArray());
        // Console.WriteLine(rev);

        // Question 10 reverse a string
        // var ans = "";
        // var name = Console.ReadLine();
        // for(int i = name.Length - 1; i >= 0; i--)
        // {
        //     ans+= name[i];
        // }
        // Console.WriteLine(ans);

        // Question 11  lower to upper and viversa
        // var name = Console.ReadLine();
        // Console.WriteLine($"{name.ToUpper()}");
        // Console.WriteLine($"{name.ToLower()}");

        // Question 12 string compare
        // var name1 = Console.ReadLine();
        // var name2 = Console.ReadLine();
        // if (String.Compare(name1, name2) == 0)
        // {
        //     Console.WriteLine("Name is same");
        // }
        // else
        // {
        //     Console.WriteLine("Name is not same");
        // }

        // Question 13 string compare
        // var name1 = Console.ReadLine();
        // var name2 = Console.ReadLine();
        // if (name1 == name2)
        // {
        //     Console.WriteLine("Name is same");
        // }
        // else
        // {
        //     Console.WriteLine("Name is not same");
        // }

        // Question 14 string concatinate
        // var name1 = Console.ReadLine();
        // var name2 = Console.ReadLine();
        // var name3 = name1+name2;
        // Console.WriteLine(name3);


        // Question 15 search a string 
        // var name6 = Console.ReadLine();
        // if (name6.Contains("hello"))
        // {
        //     Console.WriteLine($"it has");
        // }
        // else
        // {
        //     Console.WriteLine("it don't");
        // }

        string name = Console.ReadLine();
        string ans = "";
        string rev = new string(name.ToCharArray().Reverse().ToArray());
        int n = rev.Length;
        for(int i = 0; i < n; i++)
        {   
            string word = "";
            while(i<n && rev[i] == ' ') i++;
            while(i<n && rev[i] != ' ')
            {
                word += rev[i];
                i++;
            }
            string abc = new string(word.ToCharArray().Reverse().ToArray());
            if(ans.Length == 0)
            {
                ans = abc;
            }
            else
            {
                ans += " "+abc;
            }
        }
        Console.WriteLine(ans);
    }
}