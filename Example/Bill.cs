using System;
using System.Collections.Generic;

public class Bill
{
    string billDate;
    string description;
    double amount; // bill total amount
    List<Payment> payments = new List<Payment>();
    //public Payment pay {get; set;};
    
    

    public Bill(string date, string desc, double a)
    {
        this.billDate=date;
        this.description=desc;
        this.amount=a;
    }
    public void getBillInfo()
    {
        Console.WriteLine($"Date: {billDate}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Amount Due: {amount}");
        // Do not know if we need this.
        //this.verify();
        Console.WriteLine($"Total Paid: {getAmountPaid()}");
        Console.WriteLine($"Remaining Balance: {getBalance()}");
    }

    public double getBalance()
    {   
        double Total=0;
        foreach(var a in payments)
        {
            Total=Total+getAmountPaid();
            return Total;
        }
        return Total;
    }

    public double getAmountPaid()
    {
        double Total=0;
        foreach(var a in payments)
        {
            Total=Total-a.getAmount();
        }
        return Total;
    } 

    // Needs to reference payment but we have a list of payments already in here??
    public bool addPayment(Payment p)
    {
       if(p.verify()==true) 
       {
           payments.Add(p);
           return true;
       }
       return false;
       
       
       
    }

}