#include<cstdio>
#include"Money.h"
int main(void)
{
	int Rupees, Paise;
	printf("Enter the Rupees and Paise\n");
	scanf("%d%d",&Rupees,&Paise);
	Money m1(Rupees,Paise);
	m1.Calculated();
	Money m2(m1);
	Money m3;
	m3=m1+m2;
	m3.TotalMoney();
	m3.Print();
}
