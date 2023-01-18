package edu.met.banking;
public class CurvedBanner extends Banner{
	private double radius;

	public CurvedBanner(double w,double h,double r){
		super(w,h);
		radius = r;
	}
	public double bannerArea(){
		double area=super.bannerArea()-0.86*radius*radius;
		return area;
	}
}
