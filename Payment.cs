using System;
using System.Collections.Generic;

abstract class Payment
{
    public double amount; //Amount of this payment
    public string paymentDate; //Date of this payment

    static public void Payment(double Amount, string PaymentDate){
        Amount = amount;
        PaymentDate = paymentDate; 
    }
    public double getAmount(double amount){
        this.amount = amount;
        return amount;
    }

    public string getPaymentDate(string paymentDate){
        this.paymentDate = paymentDate;
        return paymentDate;
    }

//declared virtual to be overriden
    public virtual bool verify(){
        Console.WriteLine("Payment verified...");
        return true;
    }

//Abstract method
    public abstract string getPaymentType();

}