using System;
using System.Collections.Generic;

class Bill
{
    string billDate;
    string Description;
    double Amount; //bill total amount

    public Bill(string billDate, string Description, double Amount){
        billDate = billDate; 
        Description = Description;
        Amount = Amount;
    }
    string getBillInfo(){

    }

    double getBalance(double balance){
        balance = Amount - Payment.getAmount();
    }

    bool addPayment(Payment p){

    }

}