namespace Edu;
public class PowerSequence : Sequence , IResetable 
{
	private double Current;
	private float Factor;

	public override double Next() {
		double term = Current;
		Current *= Factor;
		return term;
	}
	
	public void Reset() {
		Current = 1;
	}

	public PowerSequence() {
		Current = 1;
		Factor = 5;
	}
}
