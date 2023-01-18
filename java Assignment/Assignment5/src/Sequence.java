package edu.met.dac;
public abstract class Sequence {
	private double total=0;

	public abstract double next();

	public final double sum(int count) {
		for (int i=1;i<=count;i++) 
		{
			total+= next();
		}
		return total;
	}
}
