using System;

class Bills
{
    private static decimal min_income = 0;

    public bool ValidIncome(decimal income)
    {
        if (income >= min_income)
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
        userBills.ValidIncome(512);
    }
}
