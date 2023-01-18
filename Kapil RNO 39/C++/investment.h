#include<cstdio>
class Investment
{
	private:
		double 	amount;
		int	period;

	public:
		Investment()
		{
			this->amount = 0.0;
			this->period = 0;
		}
		
		double GetAmount()
		{
			return this->amount;
		}
		int GetPeriod()
		{
			return this->period;
		}

		void SetData(double amount, int period)
		{
			this->amount = amount;
			this->period = period;
		}
		
		







};



