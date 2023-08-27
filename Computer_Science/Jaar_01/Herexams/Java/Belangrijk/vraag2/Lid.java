package be.pxl.vraag2;

public abstract class Lid {
	private String voornaam;
	private String lidnummer;
	private String lidSinds;
	
	public Lid(String voornaam, String lidSinds) {
		this.voornaam = voornaam;
		this.lidSinds = lidSinds;
		this.bepaalLidnummer();
	}
	
	public Lid() {
		this("xxx", "0000");
	}
	
	public String getLidnummer() {
		return this.lidnummer;
	}

	public void setLidnummer(String lidnummer) {
		this.lidnummer = lidnummer;
	}
	
	public String getVoornaam() {
		return voornaam;
	}

	public String getLidSinds() {
		return lidSinds;
	}
	
	public abstract void bepaalLidnummer();
}
