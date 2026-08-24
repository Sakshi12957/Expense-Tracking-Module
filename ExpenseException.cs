using System;

public class ExpenseException : Exception
{
    public ExpenseException(string message) : base(message)
    {
    }
}