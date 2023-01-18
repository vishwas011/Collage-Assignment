package Hospital;

public class Patient{
	private static int pid;
//	private static char patientName[10];
	private static int bedType;
	private static int days;
   
	public Patient(){
	    pid =340;
//	    strcpy(patientName, "Avi");
	    bedType=1;
	    days=10;
	}
	public Patient(int id,int type,int numdays){
		pid = id;
		bedType = type;
		days = numdays;
	}
	
	public int getpid(){
		return pid;
	}
  	public void setpid(int id){
		pid = id;
	}

	public int getbetType(){
		return bedType;
	}
	public void setbetType(int type){
		bedType = type;
	}

	public int getdays(){
		return days;
	}
	public void setdays(int numdays){
		days = numdays;
	}

	public double getPricePerDay(){
		double rate = 0;
		if(bedType == 1)
			rate = 500;
		if(bedType == 2)
			rate = 350;
		if(bedType == 3)
			rate =200;
		return rate;
	}

	public double getBillAmount(){
		return getPricePerDay() * days;
	}
}


