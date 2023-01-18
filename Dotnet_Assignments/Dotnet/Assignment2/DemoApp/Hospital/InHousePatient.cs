namespace Hospital;
public class InHousePatient : Patient
{
    private double Discount { get; set;}

	public InHousePatient(int Pid, string PatientName,int BedType, int Days,double Discount):base(Pid,PatientName,BedType,Days)
	{
		this.Discount=Discount;
	}

    public InHousePatient():base()
    {
        
    }

    public override double GetBillAmount(){
		/*double Amount=GetBillAmount();
		if(Amount>5000){
		
			return Amount-=Amount*Discount;
		}
		else
		{
			return Amount;
		}*/
		return base.GetBillAmount()*Discount;
	}
}

    
	
    