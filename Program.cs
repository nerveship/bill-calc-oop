using System;

public class Bills
{
    //Initalise values
    private static decimal Min_Income = 0;
    public decimal Income;
    public int BillNo;
    public List<float> SumOfBills = new List<float>();

    //Checks if the users income is valid or not
    public bool ValidIncome()
    {
        if (Income > Min_Income)
        {
            return true;
        }
        return false;
    }

    //Adds the users number of bills and prompts them for how much each costs
    public void BillAccum()
    {
        for (int i = 0; i < BillNo; i++)
        {
            Console.WriteLine($"Bill #{i + 1}: ");
            SumOfBills.Add(Convert.ToInt32(Console.ReadLine()));
        }
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
        //Create new bill object
        Bills userBills = new Bills(0);

        //Welcome message
        Console.WriteLine("Welcome! Let's calculate your bills and savings for this month!");
        Console.WriteLine("Press any key to continue at any time");
        Console.ReadKey();
        Console.Clear();

        //Get users income
        Console.WriteLine("How much income have you made this month?");
        userBills.Income = Convert.ToDecimal(Console.ReadLine());
        userBills.ValidIncome();
        Console.Clear();

        //Get users number of bills
        Console.WriteLine("How many bills do you have this month?");
        userBills.BillNo = Convert.ToInt32(Console.ReadLine());
        userBills.BillAccum();
    }
}
