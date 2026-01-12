using System;
using System.IO;

class FileInfoDemo
{
    static void Main3()
    {
        // at my given location
        // string path = @"C:\Users\singh\Desktop\csharp\day14\hello.txt";
        // FileInfo fi = new FileInfo(path);
        // File.Create(path);
        // {
        //     Console.WriteLine("File has been created");
        // }


        // Create at currect file
        // string path = @"MyTestFile.txt";
        // FileInfo fi = new FileInfo(path);
        // File.Create(path);
        // {
        //     Console.WriteLine("File has been created");
        // }




        // FileInfo fi = new FileInfo(@"MyTestFile2.txt");
        // StreamWriter str = fi.CreateText();
        // str.WriteLine("Hello");
        // Console.WriteLine("File has been created with text");
        // str.Close();

        // Delete
        // FileInfo fi = new FileInfo(@"MyTestFile2.txt");
        // fi.Delete();
        // Console.WriteLine("File has been Deleted");

        // Copy to file 1 to file 2;
        // string path1 = @"MyTestFile.txt";
        // string path2 = @"MyTestFile3.txt";

        // FileInfo f1 = new FileInfo(path1);
        // f1.CopyTo(path2);
        // Console.WriteLine($"{path1} to data in {path2}");


        // string path1 = @"obj/Data1/NewFile1.txt";
        // string path2 = @"obj/Data2/newFile.txt";
        // FileInfo f1 = new FileInfo(path1);
        // FileInfo f2 = new FileInfo(path2);
        // f1.MoveTo(path2);
        // Console.WriteLine($"{path1} to data in {path2}");



        // FileInfo f1 = new FileInfo(@"obj\Data2\newFile.txt");
        // StreamWriter sw = f1.AppendText();
        // sw.WriteLine("That");
        // sw.WriteLine("is Extra");
        // sw.WriteLine("text");
        // sw.Close();


        // FileInfo fi = new FileInfo(@"obj/Data2/newFile.txt");
        // StreamReader sr = fi.OpenText();
        // string s = "";
        // while((s = sr.ReadLine()) != null)
        // {
        //     Console.WriteLine(s);
        // }


        FileInfo fi = new FileInfo(@"obj\Data2\newFile.txt");
        Console.WriteLine($"File name is {fi.Name}");
        Console.WriteLine($"File creation time {fi.CreationTime.ToLongTimeString()}");
        Console.WriteLine($"File LastAccessTime:- {fi.LastAccessTime.ToLongTimeString()}");
        Console.WriteLine($"File extension:- {fi.Extension}");
        Console.WriteLine($"File exit is:- {fi.Exists}");
    }
}