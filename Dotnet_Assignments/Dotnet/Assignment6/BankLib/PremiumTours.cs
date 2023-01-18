namespace MetTours;



public class PremiumTours
{
[LuxaryTax(0.10f)]
public double getDaysRentForCommon(int noofdays,int noPersons)
{
    double amount = 1200;
    double n = noofdays > 6 ? amount-100:amount;
    double m = noPersons >= 4 ? n -100: n;
    return noPersons*m;
}

public double getDaysRentForSeniors(int noofdays,int noPersons)
{
    double amount = 1100;
    double n = noofdays >6 ? amount-100:amount;
    double m = noPersons >= 4 ? n - 100: noofdays;
    return noPersons*m;
}

public double getDaysRentForWomens(int noofdays,int noPersons)
{
    double amount = 1000;
    double n = noofdays >6 ? amount-100:amount;
    double m = noPersons >= 4 ? n - 100: n;
    return noPersons*m;
}


}
