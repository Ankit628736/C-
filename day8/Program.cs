using System;
class Program
{
    static void Main(string[] args)
    {
        string fname,lname;
        fname = "Rowan";
        lname = "Akkinson";

        char[] letter = {'H','e','l','l','o'};
        char[] salary = {"Hello","From","Points"};

        string fullname = fname+lname;
        Console.WriteLine("full name {0}",fullname);

        string greeting = new string(letter);
        Console.WriteLine("Greeting: {0}",greeting);

        string sarray = "hello";
        string message = string.Join(" ",sarray);
        Console.WriteLine("Message {0}",message);

        DateTime wating = new DateTime(2012,10,10,1017,58,1);
        
    }
}