#include<cstring>
#include<cmath>

class Investment
{
	private:
		double amount;
		int period;

	public:
		Investment(double amt=0, int period=0)
		{
		amount=amt;
         	this->period=period;
		}

		void SetData(double a, int p)
		{
		  amount=a;
	  	  period=p;
		}
      		


		float InterestRate()
		{
		float Rate;
		if(amount<10000)
			Rate= 8;
		if(amount>=10000 && amount<50000)
			Rate= 9;
		if(amount>=50000) 
			Rate= 10;
		  if(period>5)
		  	return Rate+1;
		  else
		       return Rate;	
		}

		float GetInterest(bool chk)
		{
	         float amt,CI;
		  if(chk==false)
		       return amount*period*InterestRate()/100;
		  else
	               amt=amount*pow((1+InterestRate()/100),period);
		       CI=amt-amount;
		       return CI;
		}

		~Investment()
		{

		}
};
	 	
			 
