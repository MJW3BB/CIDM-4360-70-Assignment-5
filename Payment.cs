using System;
using System.Collections.Generic;

abstract class Payment
{
    double amount; //Amount of this payment
    string paymentDate; //Date of this payment

    double getAmount(){

    }

    string getPaymentDate(){

    }

    virtual bool verify(){

    }

    abstract string getPaymentType(){

    }



}