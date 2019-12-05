using System;
using System.Collections.Generic;

class CreditCard : Payment
{
    private string CCNum; //credit card number
    private string expDate; //Expiration date
    private string CHolderName; //Card holder name
    private string CType; //Card type

    public CreditCard(double amount, string CCNum, string CType, string expDate, string CHolderName, string paymentDate ) : base(amount, paymentDate){
        this.CCNum = CCNum;
        this.CType = CType; 
        this.expDate = expDate;
        this.CHolderName = CHolderName;
    }

    public override bool verify(){
        Console.WriteLine("Credit Card verified...");
        return true;
    }

    public override string getPaymentType(){
        return getPaymentType;
    }

}