#include<cstdio>
class Money
{
	private:
		int Rupees;
		int Paise;
	public:
		Money(int Rs=0,int Ps=0)
		{
		    Rupees=Rs;
	    	    Paise=Ps;
		
		}
                Money(Money& m)
		{
		    Rupees=m.Rupees;
    		    Paise=m.Paise;
		   
		}
		void Calculated()
		{
		    Rupees=Rupees+Paise/100;
    		    Paise=Paise%100;
		}
		int TotalMoney() const
		{
		    return 100*Rupees+Paise;
		}
		void Print() const
		{
		    printf("Total Paise %d\n",TotalMoney());
		}
		Money operator+(const Money& info)
		{
		    Money Temp;
    		    Temp.Rupees=Rupees+info.Rupees;
		    Temp.Paise=Paise+info.Paise;
		    return Temp;
		}
		~Money()
		{
		  
		}
};		
