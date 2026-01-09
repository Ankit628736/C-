using System;

class FileDemo
{
    public void WriteTextData()
    {
        // FileStream file = new FileStream(@"C:\Users\singh\Desktop\csharp\Data\Test.txt",FileMode.Open,FileAccess.Write);
        FileStream file = new FileStream(@"C:\Users\singh\Desktop\csharp\Data\Test.txt", FileMode.Append, FileAccess.Write);
        StreamWriter streamWriter = new StreamWriter(file);
        Console.Write("Enter the text: ");
        string str = Console.ReadLine();

        streamWriter.WriteLine(str);
        streamWriter.Close();
        file.Close();
    }
    public void ReadTextData()
    {
        FileStream file = new FileStream(@"C:\Users\singh\Desktop\csharp\Data\Test.txt", FileMode.Open, FileAccess.Read);
        StreamReader streamReader = new StreamReader(file);
        streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
        string str = streamReader.ReadLine();
        while (str != null)
        {
            Console.WriteLine(str);
            str = streamReader.ReadLine();
        }
        streamReader.Close();
        file.Close();
    }
}