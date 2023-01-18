package shopping;

public class UsedItem extends Item {

	private float discount;

	public float getDiscount() {
		
		if(super.sellingPrice() > 50000)
			discount = 5.0f;
		else if(super.sellingPrice() > 100000)
			discount = 10.0f;

		return discount;	
	}	

	public double sellingPrice() {


