using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter a mathematical expression:");
        string input = Console.ReadLine();
        
        try
        {
            double result = Evaluate(input);
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static double Evaluate(string expression)
    {
        System.Data.DataTable table = new System.Data.DataTable();
        return Convert.ToDouble(table.Compute(expression, ""));
    }
}
