class Loan
{
	private:
		double principle;
		float period;
	public:
	       double GetPrinciple()
	       {
		   return principle;
	       }
	       
	       void SetPrinciple(double pp)
	       {
		   principle = pp;
	       }

	       float GetPeriod()
	       {
		   return period;
	       }

	       void SetPeriod(float prd)
	       {
		   period = prd;
	       }

	       ~Loan()
	       {

	       }
	       virtual double GetRate() = 0;
};

class PersonalLoan: public Loan
{
      private:
	       float rate;
       public:
	      double GetRate()
	      {
		    double Amount= Loan::GetPrinciple();
		    if(Amount <= 500000)
			    return rate = 15;
		    else
			    return rate = 16;
	      }


};

class HomeLoan: public Loan
{
       private:
	      float rate;
       public:
	      double GetRate()
	      {
		      double Amount= Loan::GetPrinciple();
		      if(Amount <= 2000000)
			      return rate = 10;
		      else
			      return rate = 11;
	      }

};



			 






