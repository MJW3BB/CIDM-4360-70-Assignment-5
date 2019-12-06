using System;

class Cash : Payment
{
    double tenderdCash; // cash provided by customer, e.g. $200
    double change; // change should be returned to customer, e.g. if payment amount is $196, the
    //customer provided $200, then he should get back $4

    public Cash (double amount, string date, double t): base (amount, date)
    {
        tenderdCash=t;
        change=amount-t;
    }

    double calcChange()
    {
        // if we make amount public in payment this works but without turning it public I don't know.
        change = tenderdCash - amount;
        return this.change;
    }

    public override string getPaymentType()
    {
        return "Cash";
    }

}