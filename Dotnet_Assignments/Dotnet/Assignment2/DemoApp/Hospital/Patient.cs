namespace Hospital;

public class Patient
{
    public int Pid { get;  set; }

    public string  PatientName { get; set; }

     public int BedType {get; set;}
    public int Days {get; set;}

    public Patient(int Pid, string PatientName,int BedType, int Days)
    {
        this.Pid=Pid;
        this.PatientName=PatientName;
        this.BedType=BedType;
        this.Days=Days;
    }

    public Patient():this(123,"kapil",1,10)
    {

    }

    public double GetPricePerDay(){
		double rate = 0;
		if(BedType == 1)
			rate = 500;
		if(BedType == 2)
			rate = 350;
		if(BedType == 3)
			rate =200;
		return rate;
	}

    public virtual double GetBillAmount(){
		return GetPricePerDay() * Days;
	}
}
