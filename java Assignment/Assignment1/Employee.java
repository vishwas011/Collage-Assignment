class Employee
{
	private int eid;
	private int age;
	private int hours;
	private double rate;


       Employee(int id, int a,int hrs, double rt)
     { 
	     eid=id;
	     age=a;
	     hours=hrs;
	    rate=rt;
     }

      public double GetNetIncome()
    {
	    if(hours>180)
		    return hours*rate+(hours-180)*300;
	    else
		    return hours*rate;
   }

      public void printEmployee()
   {
     System.out.printf("Employee id:%d%n",eid);
     System.out.printf("Employee age:%d%n",age);
     System.out.printf("Employee hours:%d%n",hours);
     System.out.printf("Employee rate:%.2f%n",rate);
  }
}   
