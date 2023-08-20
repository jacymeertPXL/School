package be.pxl.vraag2;

public final class Lesgever extends Lid {

	private int type;

	public Lesgever(String voornaam, String lidSinds, int type) {
		super(voornaam, lidSinds);
		this.type = type;
	}

	public Lesgever() {
		this("onbekend", "9999", 0);
	}

	public int getType() {
		return type;
	}

	public void setType(int type) {
		this.type = type;
	}

	@Override
	public void bepaalLidnummer() {
		this.setLidnummer(this.getVoornaam().substring(0, 2).toUpperCase() + this.type);
	}

	@Override
	public boolean equals(Object object) {
		if (object != null && object instanceof Lesgever) {
			Lesgever temp = (Lesgever) object;
			if (this.getVoornaam().equals(temp.getVoornaam()) && this.type == temp.type) {
				return true;
			}
		}
		return false;
	}
}
