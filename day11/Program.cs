using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Employee emp = new Employee();

//         emp[0] = "Ankit";
//         emp[1] = "Rohit";
//         emp[2] = "Sohan";
//         emp[3] = "Mohan";
//         emp[4] = "Rahul";

//         Console.WriteLine(emp[0]);
//         Console.WriteLine(emp[1]);
//         // Console.WriteLine(emp[6]); out of bound

//         Console.WriteLine("\nIndex of Sohan = " + emp["Sohan"]);
//         Console.WriteLine("Index of Rahul = " + emp["Rahul"]);
//         Console.WriteLine("Index of Unknown = " + emp["Amit"]);
//         Console.WriteLine("Index of Unknown = " + emp["Amit"]);

//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         int num1 = 0;
//         int num2 = 0;

//         int res = 0;

//         int[] arr = new int[6] { 10, 20, 30, 40, 50, 60 };

//         try
//         {
//             throw new MyException("Rejesh");
//         }catch(Exception e)
//         {
//             Console.WriteLine($"Exception caught here {e.ToString()}");
//         }
//         Console.WriteLine("\nLast Exception");

//         try
//         {
//             Console.Write("Enter first number: ");
//             num1 = int.Parse(Console.ReadLine());
//             Console.Write("Enter Second number: ");
//             num2 = int.Parse(Console.ReadLine());
//             res = num1 / num2;
//             try
//             {
//                 for (int i = 0; i <= 6; i++)
//                 {
//                     Console.WriteLine(arr[i]);
//                 }
//             }
//             catch (IndexOutOfRangeException ex)
//             {
//                 Console.WriteLine($"IndexOutOfBound {ex.Message.ToString()}");
//             }
//             finally
//             {
//                 Console.WriteLine("Nested final block");
//             }
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine($"Format exception {ex.Message.ToString()}");
//         }
//         catch (DivideByZeroException ex)
//         {
//             Console.WriteLine($"Can't divide number by zero {ex.Message.ToString()}");
//         }
//         catch (Exception ex)
//         {
//             // Console.WriteLine("Can't devide by zero");
//             Console.WriteLine(ex.Message.ToString());
//         }
//         // catch
//         // {
//         //     Console.WriteLine("Can't devide by zero");
//         // }
//         finally
//         {
//             Console.WriteLine($"Divisionof the two number {num1} and {num2} is {res}");
//         }
//         Console.WriteLine($"Divisionof the two number {num1} and {num2} is {res}");
//     }
// }


//Question 1
// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             double t = Convert.ToDouble(Console.ReadLine());
//             char ty = Console.ReadLine()[0];

//             if(ty == 'F')
//             {
//                 double res = (t-32)*5/9;
//                 Console.WriteLine($"Temperature in Celsius: {res:F2}");
//             }
//             if(ty == 'C')
//             {
//                 double res = (t * 9/5)+32;
//                 Console.WriteLine($"Temperature in Fahrenheit: {res:F2}");
//             }
//             if(ty!= 'F' && ty != 'C')
//             {
//                 throw new TpException("must be f or c");
//             }
//         }
//         catch (TpException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         catch(FormatException e)
//         {
//             Console.WriteLine($"Exception Message: {e.Message.ToString()}");
//         }
//     }
// }

// public class CricketMatch
// {
//     public int[] arr = new int[5];
//     public int index = 0;
//     public void AddPlayerScore(int num)
//     {
//         if(num<=0 || num > 50)
//         {
//             throw new InvalidOperationException("Invalid score. Score must be between 0 and 50.");
//         }
//         if (index >= 5)
//         {
//             throw new ArgumentException("Cannot add more than 5 player scores.");
//         }
//         arr[index++] = num;
//     }
//     public int CalculateTotalScore()
//     {
//         int sum = 0;
//         foreach(var it in arr)
//         {
//             sum += it;
//         }
//         return sum;
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             CricketMatch cr = new CricketMatch();
//             string input = Console.ReadLine();
//             string[] values = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             foreach(var it in values)
//             {
//                 int num = Convert.ToInt32(it);
//                 cr.AddPlayerScore(num);
//             }
//             Console.WriteLine($"Total score of the cricket team: {cr.CalculateTotalScore()}");
//         }catch(ArgumentException e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }catch(InvalidOperationException e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }
//     }
// }


class MyClassException : Exception
{
    public MyClassException(string str) : base(str)
    {

    }
}


class Program
{
    static void Main(string[] args)
    {
        try
        {
            string str1 = Console.ReadLine();
            string[] val1 = str1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<int> arr1 = new List<int>();
            foreach (var it in val1)
            {
                arr1.Add(Convert.ToInt32(it));
            }


            string str2 = Console.ReadLine();
            string[] val2 = str2.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<int> arr2 = new List<int>();
            foreach (var it in val2)
            {
                arr2.Add(Convert.ToInt32(it));
            }

            
            if (arr1.Count != arr2.Count)
            {
                throw new MyClassException("Error: Arrays must have the same length for addition.");
            }
            List<int> sumArr = new List<int>();
            for (int i = 0; i < arr1.Count; i++)
            {
                sumArr.Add(arr1[i] + arr2[i]);
            }
            int num = int.Parse(Console.ReadLine());

            int x = sumArr[num - 1];
            Console.WriteLine($"sum: {x}");

        }
        catch (MyClassException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Invalid input format. Please enter integers only.");
            Console.WriteLine("Exception Message: Input string was not in a correct format.");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Error: Index out of range for the sum array.\nException Message: Index was outside the bounds of the array.");
        }
    }
}