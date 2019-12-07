using System;
using System.Collections.Generic;

class Bill
{
    public string billDate;
    public string Description;
    public double Amount; //bill total amount

    public Bill(string billDate, string Description, double Amount){
        this.billDate = billDate; 
        this.Description = Description;
        this.Amount = Amount;
    }
    public string getBillInfo(){
            Console.WriteLine($"Date: {billDate}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Amount due: {Amount}");
          //  Console.WriteLine($"On {Payment.paymentDate} payment with {Payment.getPaymentType} the amount ${Payment.amount} was processed");
          //  Console.WriteLine($"Total paid: {total}");
           // Console.WriteLine($"Remaining balance: {balance}");

    }

    public double getBalance(double total, double balance){
        double total = 0;
        foreach (var a in Payment){
            this.total += Payment.getAmount();
            return total;
        }

        balance = Amount - total;

        return balance;

    }


    public bool addPayment(Payment p){
        if(p.verify == true){
            Payment.Add(p);
            return true;
        }
        return false;
    }

}