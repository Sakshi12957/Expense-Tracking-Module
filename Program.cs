using System;

class Program
{
    static void Main()
    {
        ExpenseManager manager = new ExpenseManager();

        while (true)
        {
            Console.WriteLine("\n===== EXPENSE TRACKING SYSTEM =====");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Show Total Expense");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                   Console.Write("Enter category: ");
string category = Console.ReadLine() ?? "";

Console.Write("Enter amount: ");
double amount = Convert.ToDouble(Console.ReadLine());

manager.AddExpense(category, amount);
break;

                    case 2:
                        manager.ViewExpenses();
                        break;

                    case 3:
                        manager.ShowTotal();
                        break;

                    case 4:
                        Console.WriteLine("Thank you!");
                        return;

                    default:
                        Console.WriteLine("Please enter a choice between 1 and 4.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (ExpenseException ex)
            {
                Console.WriteLine("Expense Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }
    }
}