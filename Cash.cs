using System;
using System.Collections.Generic;

class Cash : Payment
{
    public double tenderedCash; //Cash provided by customer, e.g. $200
    public double change; //Change given to customer

    public Cash(decimal amount, string paymentDate, ) : base(amount, paymentDate){

    }
    double calcChange(double change){
        change = tenderedCash - amount; 
        
    }

    public override bool verify(){
        Console.WriteLine("Payment verified...");
        return true;
    }
    public override string getPaymentType(){
        return getPaymentType;
    }

}