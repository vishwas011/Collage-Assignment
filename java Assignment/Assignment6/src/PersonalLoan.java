package mumbai;

public class PersonalLoan extends Loan implements Taxable{

	private double amount=super.getPrinciple();

	public double getRate(){
		if(amount<=500000)
			return 15;
		else
			return 16;
	}
	public double getTax(){
		if(amount>2000000)
			return 0.1;
		else
			return 0.07;
	}
}

