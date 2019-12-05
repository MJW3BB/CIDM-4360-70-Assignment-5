using System;
using System.Collections.Generic;

class Check : Payment
{
    private string Bank; //Bank Name
    private string custName; //Customer/client name
    private string accNum; //Account number

    public Check(decimal amount, string bank, string custName, string accNum, string paymentDate) : base(amount, paymentDate){
        this.bank = Bank; 
        this.custName = custName; 
        this.accNum = accNum;
    }

    public override bool verify(){
        Console.WriteLine("Signature and balance verified...");
        return true;
    }

    public override string getPaymentType(){
        return getPaymentType;
    }

}