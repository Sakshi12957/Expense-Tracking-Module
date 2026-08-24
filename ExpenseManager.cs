using System;
using System.Collections.Generic;

public class ExpenseManager
{
    private List<Expense> expenses = new List<Expense>();

    public void AddExpense(string category, double amount)
    {
        if (string.IsNullOrWhiteSpace(category))
        {
            throw new ExpenseException("Category cannot be empty.");
        }

        if (amount <= 0)
        {
            throw new ExpenseException("Amount must be greater than zero.");
        }

        expenses.Add(new Expense(category, amount));

        Console.WriteLine("Expense added successfully!");
    }

    public void ViewExpenses()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }

        Console.WriteLine("\n----- EXPENSE LIST -----");

        for (int i = 0; i < expenses.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. Category: {expenses[i].Category}, Amount: ₹{expenses[i].Amount}"
            );
        }
    }

    public void ShowTotal()
    {
        double total = 0;

        foreach (Expense expense in expenses)
        {
            total += expense.Amount;
        }

        Console.WriteLine($"\nTotal Expense: ₹{total}");
    }
}