namespace Eduworld;

public class CurvedBanner : Banner
{
	public double Radius;
    
    public CurvedBanner(double Width, double Height,double Radius):base(Width,Height)
    {
        this.Radius=Radius;
    }

    public override double BannerArea()
    {
		double area=base.BannerArea()-0.86*Radius*Radius;
		return area;
	}
}
