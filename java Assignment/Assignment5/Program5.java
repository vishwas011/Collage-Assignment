import edu.met.dac.*;
 class Program {
	 public static double compute(Sequence Seq, int count) {
		 if(Seq instanceof Resetable p)
			 p.reset();
		 return Seq.sum(count)/count;
	 }

	 public static void main (String [] args) {
		 LinearSequence ls = new LinearSequence();
		 PowerSequence ps = new PowerSequence();
		 System.out.printf("The Sum of Linear Sequence is %.3f%n",compute(ls,12));
		 System.out.printf("The Sum of Power Sequence is %.3f%n",compute(ps,5));
	 }
 }
