using System;

public class Bills
{
    public Bills()
    {
        Console.WriteLine("We just made a bills instance");
    }

    private static decimal min_income = 0;
    public decimal income;

    public bool ValidIncome()
    {
        if (income > min_income)
        {
            return true;
        }
        return false;
    }
};

class BillCalculator
{
    public static void Main()
    {
        Bills userBills = new Bills();

        Console.WriteLine("How much income have you made this month?");

        userBills.income = Convert.ToDecimal(Console.ReadLine());
        userBills.ValidIncome();
    }
}
