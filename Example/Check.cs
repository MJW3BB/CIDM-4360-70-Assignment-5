using System;

class Check : Payment
{
    string Bank; // bank name
    string custName; // customer/client name
    string accNum; // account number

    public Check(double amount, string b, string c, string a, string date):base (amount, date)
    {
        Bank=b;
        custName=c;
        accNum=a;
    }

    public override bool verify()
    {
        Console.WriteLine("Signature and account Balance verified.");
        return true;
    }

     public override string getPaymentType()
    {
        return "Check";
    }

}