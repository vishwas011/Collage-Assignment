namespace Edu;
public class LinearSequence : Sequence 
{
	private double Current;
	private float Step;
	
	public override double Next() 
        {
		double term = Current;
		Current += Step;
		return term;
        }
	public LinearSequence() 
         {
		Current = 7;
		Step = 4;
         }
}
