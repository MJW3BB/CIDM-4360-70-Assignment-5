using System;


abstract class Payment
{
    double amount; // amount of this payment
    string paymentDate; // date of this payment
    
    
    
    public Payment(double number, string date) 
    {
        this.amount=number;
        this.paymentDate=date;
    }

    public double getAmount()
    {
        return this.amount;s
    }

    public string getPaymentDate()
    {
        return this.paymentDate;
    }

    public virtual bool verify()
    {
        Console.Write("Payment verified.");
        return true;
    }

    abstract public string getPaymentType();
    

}