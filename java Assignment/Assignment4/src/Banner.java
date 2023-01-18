package edu.met.banking;

public class Banner{
	private  double width;
	private  double height;

	public void resize(double w, double h) throws IllegalDimensionException{
		if(w<h)
			throw new IllegalDimensionException();
		width = w;
		height = h;
	}
	
	public Banner(){
		width = 30;
		height = 15;
	}

	public Banner(double w, double h){
		width = w;
		height = h;
	}

	public double getwidth(){
		return width;
	}
	public void setwidth(double w){
		width = w;
	}

	public double getheight(){
		return height;
	}
	public void setheight(double h){
		height = h;
	}

	public double bannerArea(){
		return width*height;
	}
}


