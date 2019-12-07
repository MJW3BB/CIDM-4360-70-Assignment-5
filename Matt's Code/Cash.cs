using System;
using System.Collections.Generic;

class Cash : Payment
{
    public double tenderedCash; //Cash provided by customer, e.g. $200
    public double change; //Change given to customer

    public Cash(double amount, string date, double t) : base(amount, date)
    {
        tenderedCash = amount;
        this.change = amount - tenderedCash; 
    }
    public double calcChange(double change)
    {
        change = tenderedCash - amount; 
        return this.change;
    }

    public override bool verify(){
        Console.WriteLine("Payment verified...");
        return true;
    }
    public override string getPaymentType()
    {
        return "Cash";
    }

}