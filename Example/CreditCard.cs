using System;

// No Idea why this is doing this.
public class CreditCard : Payment
{
    string CCNum; // credit card number
    string expDate; // expiration date
    string CHolderName;// card holder name
    string CType; //Visa,Mastercard,..

    //public CreditCard (double number, string c, string e, string n, string c, ) :base()
    public CreditCard(double amount, string c, string e, string ch, string ct, string date): base(amount, date)
    {
        CCNum=c;
        expDate=e;
        CHolderName=ch;
        CType=ct;
    }

    public override bool verify()
    {
        Console.WriteLine("Credit card verified.");
        return true;
    }
     public override string getPaymentType()
    {
        return "Credit Card";
    }

}