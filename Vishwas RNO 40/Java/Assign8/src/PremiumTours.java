package Tours;

public class PremiumTours {

    @LuxuryTax(10)
    public double common(int days, int noOfPersons) {

        return  days * noOfPersons * 1200;
    }

    @LuxuryTax(10)
    public double senior(int days, int noOfPersons){

        return getDiscount(days,noOfPersons) - 100;
    }

    @LuxuryTax(10)
    public double woman(int days, int noOfPersons){

        return getDiscount(days,noOfPersons) - 200;
    }

    private double getDiscount(int days, int noOfPersons) {
        
        double total = common(days, noOfPersons);
        if ((days > 6) && (noOfPersons >= 4))
        {
            return total - 200 * days * noOfPersons;
        }
        else if (days > 6)
        {
            return total - 100 * days * noOfPersons;
        }
        else if (noOfPersons >= 4)
        {
            return total - 100 * days * noOfPersons;
        }
        return days * noOfPersons * 1200;
    }
}