package be.pxl.vraag1;

public class Comedian extends Artiest {

	private String voorstelling;

	public Comedian(String naam, String voorstelling) {
		super(naam, Genre.COMEDY);
		this.voorstelling = voorstelling;
	}

	@Override
	public String toString() {
		return super.toString() + " - " + this.voorstelling;
	}

	@Override
	public int getPrijs() {
		return 150;
	}

}
