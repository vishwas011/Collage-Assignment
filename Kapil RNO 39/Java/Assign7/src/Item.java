package shopping;

public class Item {

	private int id;
	private float cost;
	private int qty;

	public double sellingPrice() {

		return cost * qty;
	}
}
