package edu.met.dac;
public class LinearSequence extends Sequence {
	private double current;
	private float step;
	
	public double next() {
		double term = current;
		current += step;
		return term;
	}
	public LinearSequence() {
		current = 7;
		step = 4;
	}
}
		
