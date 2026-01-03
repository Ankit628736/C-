using System;
class Employee:IComparable<Employee>
{
    public int Id{get;set;}
    public string Name{get;set;}

    public int CompareTo(Employee other)
    {
        return this.Id.CompareTo(other.Id); //Acceding
    }
    public override string ToString()
    {
        return $"Employee Id is {Id}"+
                $"Employee Name is {Name}";
    }
}