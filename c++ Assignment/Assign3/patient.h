#include<cstring>
#include<cstdio>

class Patient
{
       private:
	       int patientId;
	       char patientName[10];
	       int bedType;
               int numofdays;
        public:
	       Patient()
	       {
		       patientId =340;
		       strcpy(patientName, "Avi");
	       	       bedType=2;
		       numofdays=7;
	       }
               void SetData(int id,char name[10], int bt, int days)
	       {
		       patientId=id;
		       strcpy(patientName,name);
		       bedType=bt;
		       numofdays=days;
	       }
                
	       void GetData()
	       {

		       printf("Patient ID :%d\n",patientId);
		       printf("Name of Patient :%s\n",patientName);
		       printf("Bed Type :%d\n",bedType);
		       printf("No. of days :%d\n",numofdays);
	       }

	       int GetNumofDays()
	       { 
		  return numofdays;
	       }



	       virtual float GetBillAmount()
	       {
		  float amount;
		  if(bedType==1)
	                  amount=numofdays*500;
		  if(bedType==2)
			  amount=numofdays*350;
		  if(bedType==3)
			  amount=numofdays*200;
	                  return amount;
	       }

		     
	      

	       
	       ~Patient()
	       {

	       }
};

class InHousePatient: public Patient
{
     
        private:
	        
	        float discount;
	     
         public:
                InHousePatient(float d=0.05):Patient()

	       {
			       discount=d;
	       }  
			     
	        float GetBillAmount()
		{
			
	               float Amount=Patient::GetBillAmount();
		         if(Amount>5000)
		         return Amount-Amount*discount;
			 else
			 return Amount;
	        }
		
	      
	     

};





	  	       


	       


