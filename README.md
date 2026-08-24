# Expense Tracking Module

## Description

This project is a C# Console Application developed to track daily expenses.

The application allows users to:

- Add expenses
- View all expenses
- Calculate total expenses
- Handle invalid user input
- Handle invalid expense amounts
- Use custom exception handling

## Technologies Used

- C#
- .NET
- Console Application
- Object-Oriented Programming
- Exception Handling

## Project Structure

- Program.cs - Main program and menu
- Expense.cs - Expense model
- ExpenseManager.cs - Expense management operations
- ExpenseException.cs - Custom exception class

## Features

1. Add Expense
2. View Expenses
3. Show Total Expense
4. Exit

## Exception Handling

The application handles:

- Invalid numeric input
- Empty category
- Negative or zero expense amount
- Unexpected errors

## How to Run

Create a C# Console Application and add all four `.cs` files.

Run the application using:

dotnet run

## Sample Input

Category: Food  
Amount: 250

Category: Travel  
Amount: 500

## Sample Output

Total Expense: ₹750
