using Bombay;

public class LoanTest
{
	private static double Compute(Loan info){
		if( info is ITaxable){
			var p=(ITaxable)info;
			return info.GetEMI()+info.GetEMI()*p.GetTax();
		}
		if(info is IDiscountable){
			var h=(IDiscountable)info;
			return info.GetEMI()-info.GetEMI()*h.GetDiscount();
		}
		return 0;
	}
public static void Main(string[] args)
{
int choice=0;
Console.WriteLine("Enter the Amount:");
double Principle=double.Parse(Console.ReadLine());
Console.WriteLine("Enter Period");
int Period=int.Parse(Console.ReadLine());
Console.WriteLine("1.Personal Loan");
Console.WriteLine("2.Home Loan");
Console.WriteLine("Enter Choice");
choice=int.Parse(Console.ReadLine());
switch(choice)
  {
    case 1:
           double amount=0; 
           Loan pl = new PersonalLoan(Principle,Period,amount);
       
            Console.WriteLine("Your Monthly Emi without tax is {0:0.000}",pl.GetEMI());
            Console.WriteLine("Your Monthly Emi with Tax is {0:0.000}",Compute(pl));
            break;

    case 2:
            double aa=0;
            Loan hl = new HomeLoan(Principle,Period,aa);
          
            Console.WriteLine("Your Monthly Emi without Discount is {0:0.000}",hl.GetEMI());
            Console.WriteLine("Your Monthly Emi with Discount is {0:0.000",Compute(hl));
            break;        

   }
  }
} 
