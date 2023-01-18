import edu.met.banking.*;
public class Program4{
	private static double compute(Banner b,int copies){
		double rate=copies>5?0.86:0.75;
		return copies*b.bannerArea()*rate;
	}
	public static void main (String[] args){
		double w=Double.parseDouble(args[0]);
		double h=Double.parseDouble(args[1]);
		double r=Double.parseDouble(args[2]);
		int copies=Integer.parseInt(args[3]);
		Banner ban=new Banner(w,h);
		CurvedBanner ban1=new CurvedBanner(w,h,r);
		try{
			ban.resize(w,h);
			System.out.printf("The Total price of Banner is %.3f%n",compute(ban,copies));
			System.out.printf("The Total price of Banner is %.3f%n",compute(ban1,copies));
		}
		catch(IllegalDimensionException e){
			System.out.printf("You have Entered wrong Dimension .%n Thank you for visiting!! %n Come Again.%n");
		}
	}
}


			

