using System;

class TpException : Exception
{
    public TpException(string str) : base("Invalid conversion type. Please enter 'F' or 'C'.")
    {
    }
}