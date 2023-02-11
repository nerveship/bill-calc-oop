using System;

public class Bills
{
    //Initalise values
    private static decimal Min_Income = 0;
    public decimal Income;
    public int BillNo;
    public List<float> NoOfBills = new List<float>();

    public bool ValidIncome()
    {
        if (Income > Min_Income)
        {
            return true;
        }
        return false;
    }

    //Constructor
    public Bills(decimal inIncome)
    {
        inIncome = Income;
    }
};

class BillCalculator
{
    public static void Main()
    {
        Bills userBills = new Bills(0);
        Console.WriteLine("Welcome! Let's calculate your bills and savings for this month!");
        Console.WriteLine("Press any key to continue at any time");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("How much income have you made this month?");

        userBills.Income = Convert.ToDecimal(Console.ReadLine());
        userBills.ValidIncome();
    }
}
