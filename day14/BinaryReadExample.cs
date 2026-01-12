using System;
using System.IO;

class BinaryReadExample
{
    static void Main1()
    {
        string filepath = "employee.dat";
        using (FileStream fs = new FileStream(filepath,FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int id = reader.ReadInt32();
            string name = reader.ReadString();
            double salary = reader.ReadDouble();
            bool isActive = reader.ReadBoolean();
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"IsActive: {isActive}");
        }
    }
}