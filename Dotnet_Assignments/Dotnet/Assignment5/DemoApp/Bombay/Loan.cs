namespace Bombay;

public abstract class Loan
{
	
	public  static double Principle {get; set;}
	public int Period {get; set;}

	public Loan(double P,int Prd)
	{
       Principle=P;
	   Period = Prd;

	}
	public Loan():this(50000,5)
	{

	}

    public abstract double GetRate();

	public double GetEMI()
    {
		return Principle*(1+GetRate()*Period/100)/(12*Period);
	}

}
