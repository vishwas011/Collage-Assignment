using Edu;
        
	 double Compute(Sequence seq, int count) 
      {
		 if(seq is IResetable p)
			 p.Reset();
		 return seq.Sum(count)/count;
	 }
  
   LinearSequence ls = new LinearSequence();
   PowerSequence ps = new PowerSequence();
  Console.WriteLine("The Sum of Linear Sequence is {0:0.00}",Compute(ls,12));
  Console.WriteLine("The Sum of Power Sequence is {0:0.00}",Compute(ps,5));