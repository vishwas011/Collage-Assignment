namespace MetTours;



public class EconomyTours

{
    [LuxaryTax()]
    public double getDaysRent(int nodays,int noPersons)
    {
        return nodays*noPersons*500;
    }
}