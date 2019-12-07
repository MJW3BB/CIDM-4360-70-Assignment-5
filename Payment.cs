using System;
using System.Collections.Generic;

abstract class Payment
{
    public double amount; //Amount of this payment
    public string paymentDate; //Date of this payment
    

    public Payment(double Amount, string PaymentDate){
        this.Amount = amount;
        this.PaymentDate = paymentDate; 
    }
    public double getAmount(double amount){
        this.amount = amount;
        return amount;
    }

    public string getPaymentDate(string PaymentDate){
        this.PaymentDate = paymentDate;
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