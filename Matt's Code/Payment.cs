using System;
// using System.Collections.Generic;

abstract class Payment
{
    public double amount; // Amount of this payment
    public string paymentDate; // Date of this payment

    public Payment(double payAmount, string payDate)
    {
        amount = payAmount;
        paymentDate = payDate; 
    }
    public double getAmount(/*double amount*/)
    {
        // this.amount = amount;
        return amount;
    }

    public string getPaymentDate(/*string paymentDate*/)
    {
        // this.paymentDate = paymentDate;
        return paymentDate;
    }
    public virtual bool verify()
    {
        Console.WriteLine("\tPayment verified...\n");
        return true;
    }
    public abstract string getPaymentType();

}