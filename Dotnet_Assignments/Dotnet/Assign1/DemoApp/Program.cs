class Program
{
    public static bool IsEven(int num)
    {
         return num % 2 == 0;
    }

    public static bool IsOdd(int num)
    {
        return num % 2 == 1;
    }

    public static bool IsPrime(int num)
    {
        if(num==2)
            return true;
        if(num==3)
            return true;

        for(int i=3;i<num;i++)
        {
            if(num%i==0)
                return false;
        }
          return true;
    }

    public static int CountPrime(int num)
    {
        if(num==2)
              return 1;
        if(num==3)
              return 1;

        for(int i=3;i<num;i++)
        {
            if(num%i==0)
              return 0;    
        }
        return 1;
    }

     public static int Reverse(int num)
    {
        int sum=0;
        int Temp=num;
        while(num>0)
        {
            int r=0;
            r=num%10;
            sum=sum*10+r;
            num=num/10;
        }
        return sum;
    }

    public static int DigitCount(int num)
    {
        int count=0;
        while(num>0)
        {
            int r=0;
            r=num%10;
            count++;
            num=num/10;
        }
        return count;
    }
     
    public static void Main(string[] args)
    {
        
       int p = int.Parse(args[0]);
       int q = int.Parse(args[1]);
       if(IsEven(p)==true)
       Console.WriteLine("The Number is Even ");
       else
       Console.WriteLine("The Number is odd");

       
       if(IsOdd(q)==true)
       Console.WriteLine("The Number is odd");
       else
       Console.WriteLine("The Number is even");

       if(IsPrime(p)==true)
       Console.WriteLine("The Number is Prime Number");
       else
       Console.WriteLine("This Number is not Prime Number");

       int first=0;
       int last=0;
       int count=0;
       //Console.WriteLine("Enter Range");
       for(int i=first;i<=last;i++)
       {
        count=count+CountPrime(i);
       }
       Console.WriteLine("The Total Prime Number is {0:0.00}",count);

       Console.WriteLine("The Number of digit are {0:000}",Reverse(p));

       Console.WriteLine("The Number of digit are {0:000}",DigitCount(q));

    }
}