namespace Bombay;

public class HomeLoan :Loan, IDiscountable
{
    double Amount = Loan.Principle;
	public override double GetRate(){
		if(Amount<=200000)
			return 10;
		else
			return 11;
	}
	public double GetDiscount(){
		if(Amount>2500000)
			return 0.2;
		else
			return 0.1;
	}

	public HomeLoan(double P,int Prd,double amount):base(P,Prd)
	{
		Amount=amount;
	}

	/*public HomeLoane():base()
	{
		Amount=2000;
	}*/
}