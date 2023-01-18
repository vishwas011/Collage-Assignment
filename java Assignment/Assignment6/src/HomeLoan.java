package mumbai;
public class HomeLoan extends Loan implements Discountable{	
	private double amount=super.getPrinciple();
	public double getRate(){
		if(amount<=200000)
			return 10;
		else
			return 11;
	}
	public double getDiscount(){
		if(amount>2500000)
			return 0.2;
		else
			return 0.1;
	}
}	
