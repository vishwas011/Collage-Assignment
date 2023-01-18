#include"loan.h"
#include<cstdio>
using namespace std;
double MonthlyEmi(Loan& oct)
{
	double Principle=oct.GetPrinciple();
	double Period = oct.GetPeriod();
	double Rate = oct.GetRate();
	
	return Principle*(1+Rate*Period/100)/(12*Period);
}

int main(void)
{
	double ppal = 0;
	float prd  = 0;
	int choice = 0;
	printf("Enter Principle Amount:\n");
	scanf("%lf",&ppal);
	printf("Enter the number of years:\n");
	scanf("%f",&prd);
	PersonalLoan pl;
	HomeLoan hl;
	printf("Enter the Type of Loan\n");
	printf("1.Personal Loan\n");
	printf("2.Home Loan\n");
	scanf("%d",&choice);
		   
	switch(choice)
	{
		case 1:
			pl.SetPrinciple(ppal);
			pl.SetPeriod(prd);
			printf("The EMI to be filled is:%lf\n", MonthlyEmi(pl));
			break;
		case 2:
			hl.SetPrinciple(ppal);
			hl.SetPeriod(prd);
		        printf("The EMI to be filled is:%lf\n", MonthlyEmi(hl));
		        break;
	       default:	
			puts("Invalid Choice");
	}


}


