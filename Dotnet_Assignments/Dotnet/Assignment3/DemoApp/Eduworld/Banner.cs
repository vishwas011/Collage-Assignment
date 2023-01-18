namespace Eduworld;

public class Banner
{
    public  double Width {get; set;}
	public  double Height {get; set;}

   public void Resize(double Width, double Height)
    {
		if(Width<Height)
			throw new IllegalDimensionException();
		this.Width = Width;
		this.Height = Height;
	}

    public Banner(double Width, double Height)
    {
		this.Width = Width;
		this.Height = Height;
	}

    public Banner():this(30,15)
    {	
	}

    public virtual double BannerArea()
    {
		return Width*Height;
	}

	
}