class MathUtil {
	private int first;
	private int second;
	
	public MathUtil(int a, int b){
		first=a;
		second=b;
	}
	public boolean isEven(int first) {
		boolean flag = false;

		if(first %2==0)
		{
			flag=true;
		}
		return flag;

	}
	public static boolean isOdd(int first) {
		boolean flag = false;
		if(first %2==1)
		{
			flag=true;
		}
		return flag;
	}  

	public boolean isPrime(int first){
		int num = first;
		boolean flag = false;

		for (int i =2; i <=num / 2; ++i){
			if(num % i == 0){
				flag = true;
			}
		}
		return flag;
	}
	
	  public int isprime(int n) {
		int m;
		if(n == 1)
			return 0;
		if(n == 2 || n == 3)
			return 1;
		if((n % 2)== 0)
			return 0;
		for(m = 3; m*m <=n; m+= 2)
		{
			if((n % m) ==0)
			return 0;
		}
		return 1;
				
	}
	
	public  int countPrimes(int first,int second) {
		int term, count=0;
		
        /*        if(first==2)
			return 1;
		if(first==3)
			return 1;*/
		for(term = first; term <= second;++term)
		{
			count += isprime(term);
			
		}
		return count;

	}
	
	public  int reverse(int first) {
                int sum=0;
		int temp=first;
		while(first>0)
		{
			int r=0;
			r = first%10;
			sum=sum*10+r;
			first=first/10;
		}
		return sum;

	}
	
	public int digitCount(int first) {
                int count=0;
		while(first>0)
		{
			int r=0;
			r=first%10;
			count++;
			first=first/10;
		}
		return count;

	}
}	
	
		
