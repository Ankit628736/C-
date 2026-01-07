using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    string[] str = new string[5];

    // int indexer → store / get value by index
    public string this[int index]
    {
        get { return str[index]; }
        set { str[index] = value; }
    }

    // string indexer → return index of given name
    public int this[string sr]
    {
        get
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == sr)
                {
                    return i;
                }
            }
            return -1;   // if not found
        }
    }
}