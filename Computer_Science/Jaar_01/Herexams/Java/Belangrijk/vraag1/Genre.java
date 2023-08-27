package be.pxl.vraag1;

public enum Genre {
	POP, ROCK("RCK"), METAL("MTL"), DANCE("DNC"), HIPHOP("HHP"), RAP, COMEDY("CDY");

	private final String shortcode;

	private Genre(String shortcode) {
		this.shortcode = shortcode;
	}

	private Genre() {
		this.shortcode = this.name();
	}

	@Override
	public String toString() {
		StringBuilder tekst = new StringBuilder("[");

		if (this.shortcode == Genre.COMEDY.shortcode) {
			tekst.append("!");
		}

		tekst.append(this.shortcode);
		tekst.append("]");

		return tekst.toString();

	}
}
