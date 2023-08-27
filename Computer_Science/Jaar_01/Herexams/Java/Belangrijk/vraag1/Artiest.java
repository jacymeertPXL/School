package be.pxl.vraag1;

public abstract class Artiest {
	String naam;
	Genre genre;

	public Artiest(String naam, Genre genre) {
		this.naam = naam;
		this.genre = genre;
	}
	
	public String getNaam() {
		return this.naam;
	}

	public abstract int getPrijs();

	public String toString() {
		return genre.toString() + " " + this.naam;
	}
}
