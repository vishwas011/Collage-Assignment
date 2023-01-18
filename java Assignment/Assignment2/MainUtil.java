class MainUtil{
	public static void main(String[] args) {
		int a = Integer.parseInt(args[0]);
		int b = Integer.parseInt(args[1]);
		MathUtil m = new MathUtil(a,b);
	        MathUtil p = new MathUtil(a,b);

		boolean ans = m.isEven(a);
		if(ans==true)
	                System.out.printf("The no is even%n");
		else
			System.out.printf("The no is not even%n");
		
		if(ans==true)
			System.out.printf("The no. is odd %n");
		else
			System.out.printf("The no. is not odd %n");
		
		boolean ann = m.isPrime(a);
		if(!ann)
			System.out.println("The Number is prime");
		        System.out.printf("The total number of primes are %d %n",m.countPrimes(a,b));
	
/*		if(ans=true)

			System.out.printf("The no. is prime %n");
		else
			System.out.printf("The no. is not prime %n");

		for(int i=first;i<=second;i++)
		{
			int three;
		    return three+= countPrime(i);
		}
		System.out.printf("The no. of prime number is %d%n",three);
*/
		System.out.printf("The reverse number is %d%n",m.reverse(a));

		System.out.printf("The no. of digit  is %d%n",m.digitCount(a));
	}
}











































































































































































