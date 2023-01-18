package Hospital;

public class InHousePatient extends Patient{
	private double discount;
   //	Patient a = new Patient();
	public InHousePatient(){
		super(1002,1,10);
		discount = 0.05;
	}

	public InHousePatient(int id,int type,int numdays,double dis){
		super(id,type,numdays);
		discount = dis;
	}
	public  double getBillAmount(){
		double Amount=super.getBillAmount();
	
		//	System.out.printf("Return Amount Outer %f %n",Amount);
		if(Amount>5000){
		//	System.out.printf("Return Amount Inner  %f %n",Amount);
			return Amount-=Amount*discount;
		}
		else
		{
			return Amount;
		}
	}
}
