import Hospital.*;


class Program{
	public static void main(String[] args){
		Patient p = new Patient (1002,1,15);
		System.out.printf("The bill is %.2f%n",p.getBillAmount());

		InHousePatient q = new InHousePatient(1002,1,15,0.1);

		System.out.printf("The bill is %.2f%n",q.getBillAmount());
	}
}
