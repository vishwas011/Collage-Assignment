using Hospital;


int p = int.Parse(args[0]);
string q = (args[1]);
int r = int.Parse(args[2]);
int s = int.Parse(args[3]);
double t = double.Parse(args[4]);

Patient a = new Patient(p,q,r,s);
InHousePatient i = new InHousePatient(p,q,r,s,t);

Console.WriteLine("The Patient Bill is {0:0.000}",a.GetBillAmount());
Console.WriteLine("The InHousePatient Bill is {0:0.000}",i.GetBillAmount());










