namespace Tours;

public class EconomyTours 
{
    [LuxuryTax]
    public double Common(int days, int Noperson) => days * Noperson * 500;
    
}
