namespace Edu;
public abstract class Sequence 
{
	private double Total=0;

	public abstract double Next();

	public double Sum(int count) 
       {
		for (int i=1;i<=count;i++) 
		{
			Total+= Next();
		}
		return Total;
	}
}

