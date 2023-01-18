using Eduworld;

double Compute(Banner b,int copies)
{
		double rate=copies>5?0.86:0.75;
		return copies*b.BannerArea()*rate;
}

double p = double.Parse(args[0]);
double q = double.Parse(args[1]);
double r = double.Parse(args[2]);
int copies = int.Parse(args[3]);

Banner ban=new Banner(p,q);
CurvedBanner ban1 = new CurvedBanner(p,q,r);

try{
			ban.Resize(p,q);
			Console.WriteLine("The Total price of Banner is {0:0.00}",Compute(ban,copies));
		    Console.WriteLine("The Total price of CurvedBanner is {0:0.000}",Compute(ban1,copies));
	}
		catch(IllegalDimensionException )
        {
			Console.WriteLine("You have Entered wrong Dimension .%n Thank you for visiting!! %n Come Again.%n");
		}
	


