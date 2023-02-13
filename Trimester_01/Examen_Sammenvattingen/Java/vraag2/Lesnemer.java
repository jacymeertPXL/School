package be.pxl.vraag2;

public final class Lesnemer extends Lid {

	private int niveau;
	private int volgnummer;
	private static int aantal = 0;
	
	public Lesnemer(String voornaam, String lidSinds, int niveau) {
		super(voornaam, lidSinds);
		this.niveau = niveau;
		aantal++;
		this.volgnummer = aantal;
	}
	
	public Lesnemer() {
		this("geen naam", "1111", 0);
	}
	
	@Override
	public void bepaalLidnummer() {
		this.setLidnummer(this.getVoornaam().substring(this.getVoornaam().length() - 2, this.getVoornaam().length()).toUpperCase() + this.volgnummer);
	}

	public int getNiveau() {
		return niveau;
	}

	@Override
	public boolean equals(Object object) {
		if (object != null && object instanceof Lesnemer) {
			Lesnemer temp = (Lesnemer) object;
			if (this.getVoornaam().equals(temp.getVoornaam()) && this.niveau == temp.niveau) {
				return true;
			}
		}
		return false;
	}
}
