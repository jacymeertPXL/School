package be.pxl.vraag1;

public class MuziekBand extends Artiest {

	private static int aantalBandleden;

	public MuziekBand(String naam, Genre genre, int aantalBandleden) {
		super(naam, genre);
		this.aantalBandleden = aantalBandleden;

		if (this.aantalBandleden <= 0) {
			this.aantalBandleden = 1;
		}
	}

	@Override
	public int getPrijs() {
		return this.aantalBandleden * 100;
	}

}
