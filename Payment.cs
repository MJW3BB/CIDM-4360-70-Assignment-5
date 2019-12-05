using System;
using System.Collections.Generic;

abstract class Payment
{
    private double amount; //Amount of this payment
    public string paymentDate; //Date of this payment

    public Payment(double amount, string paymentDate){
        this.amount = amount;
        this.paymentDate = paymentDate; 
    }
    public double getAmount(string amount){
        amount = amount;
    }

    public string getPaymentDate(string paymentDate){
        paymentDate = paymentDate;
    }

//declared virtual to be overriden
    public virtual bool verify(){

    }

//Abstract method
    abstract public string getPaymentType();

}