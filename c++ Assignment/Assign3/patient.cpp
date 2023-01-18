#include"patient.h"
#include<cstdio>
#include<cstring>
#include<iostream>
using namespace std;
float TotalAmount(Patient& info)
{
	float GST=0.5;
	return GST*info.GetBillAmount()+info.GetBillAmount();


}
int main(void)
{
	int id;
	char name[10];
	int bt;
	int days;
	int choice;
	printf("1.Regular Patient\n");
	printf("2.Inhouse Patient\n");
	printf("Enter the Choice\n");
	scanf("%d",&choice);
	
	printf("Enter the patientId:\n");
	scanf("%d",&id);
	printf("Enter the patientName:\n");
	scanf("%s",name);
        printf("Enter the bedType :\n");
	scanf("%d", &bt);
	printf("No. of Days:\n");
	scanf("%d",&days);
	Patient p;
	InHousePatient ihp;
	p.SetData(id,name,bt,days);
	ihp.SetData(id,name,bt,days);
	switch(choice)
	{
         case 1:
                p.GetData();
		printf("Total Amount for Patient is %f\n",TotalAmount(p));			
		break;
	 case 2:
		ihp.GetData();
		printf("Total Amount for Patient is %f\n",TotalAmount(ihp));
		break;
	 default:
		printf("Invalid Entry");
	}

}



