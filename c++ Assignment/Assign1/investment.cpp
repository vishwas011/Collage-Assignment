#include"investment.h"
#include<cstdio>
#include<iostream>
int main(void)
{
	Investment inv;
	float amt;
	int period;
	bool chk=true;
        int choice;
	printf("Enter the Amount and Period\n");
	scanf("%f%d",&amt,&period);
	inv.SetData(amt,period);
	printf("1.Calculate Simple Interest\n2.Calculate Compound Interest\n");
	printf("Enter the Choice\n");
	scanf("%d",&choice);
	switch(choice)
	{
	  case 1:
		chk=false;
	        break;
          case 2:
		chk=true;
	        break;
		default:
		printf("Invalid Entry\n");
	}

	printf("The Interest is %f\n",inv.GetInterest(chk));
 
 
}
