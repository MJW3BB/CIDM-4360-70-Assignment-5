using System;
using System.Collections.Generic;

class Bill
{
    public string billDate;
    public string description;
    public double amount; //bill total amount
    List<Payment> PaymentList = new List<Payment>();

    // Bill CONSTRUCTOR
    public Bill(string dateOfBill, string descOfBill, double amountOfBill)
    {
        this.billDate = dateOfBill; 
        this.description = descOfBill;
        this.amount = amountOfBill;
    }
    // getBillInfo METHOD
    public string getBillInfo()
    {
            /*
            Console.WriteLine($"Date: {billDate}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Amount due: {amount}");
            Console.WriteLine($"On {Payment.paymentDate} payment with {Payment.getPaymentType} the amount ${Payment.amount} was processed");
            Console.WriteLine($"Total paid: {getBalance(total)}");
            Console.WriteLine($"Remaining balance: {getBalance(balance)}");
            */
            string consolePrint = $"Date: {billDate} \nDescription: {description} \nAmount Due: ${amount}";

            foreach(var p in PaymentList)
            {
                consolePrint+=$"\nOn {p.getPaymentDate()} payment with {p.getPaymentType()} the amount ${p.amount} was processed.";
            }
            consolePrint+=$"\nTotal paid: {getAmountPaid()} \nRemaining Balance: {amount}";
            return consolePrint;

    }
    // getBalance METHOD
    public double getBalance(double total, double balance)
    {
        double getBalanceTotal = 0;
        foreach (var a in PaymentList)
        {
            getBalanceTotal = total;
            // return getBalanceTotal;
        }
        return amount - getAmountPaid();

        // return balance;
    }
    public double getAmountPaid()
    {
        double Total=0;
        foreach(var b in PaymentList)
        {
            Total=Total+b.getAmount();
        }
        return Total;
    } 

    // addPayment METHOD
    public bool addPayment(Payment p)
    {
        if(p.verify() == true)
        {
            PaymentList.Add(p);
            return true;
        }
        return false;
    }


}