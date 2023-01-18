package Tours;

public class EconomyTours {
    
    @LuxuryTax
    public double common(int days, int noOfPersons) {

        return days * noOfPersons * 500;
    }
}