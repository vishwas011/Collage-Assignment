class Income
{
	public static void main(String[] args)
	{
		int eid = Integer.parseInt(args[0]);
		int age  = Integer.parseInt(args[1]);
		int hours = Integer.parseInt(args[2]);
        double rate = Double.parseDouble(args[3]);

		Employee emp = new Employee(eid,age,hours,rate);
		emp.printEmployee();

		System.out.printf("The Salary is %.2f%n",emp.GetNetIncome());
	}
}

