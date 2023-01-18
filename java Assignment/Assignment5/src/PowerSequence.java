package edu.met.dac;
public class PowerSequence extends Sequence implements Resetable {
	private double current;
	private float factor;

	public double next() {
		double term = current;
		current *= factor;
		return term;
	}
	
	public void reset() {
		current = 1;
	}

	public PowerSequence() {
		current = 1;
		factor = 5;
	}
}


