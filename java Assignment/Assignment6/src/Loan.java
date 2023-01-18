package mumbai;

public abstract class Loan{
	private double principle;
	private int period;


	public double getPrinciple(){
		return principle;
	}
	public void setPrinciple(double p){
		principle = p;
	}
	
	public int getPeriod(){
		return period;
	}
	public void setPeriod(int prd){
		period = prd;
	}
	public abstract double getRate();

	public double getEMI(){
		return principle*(1+getRate()*period/100)/(12*period);
	}
}

