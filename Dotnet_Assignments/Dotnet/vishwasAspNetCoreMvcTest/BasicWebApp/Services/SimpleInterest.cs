namespace BasicWebApp.services;

public class SimpleInterest:ISimpleInterest
{
    public double Calculate (double Amount,double Rate,int Period)
    {
        return Amount*Rate*Period/100;
        
    }
}