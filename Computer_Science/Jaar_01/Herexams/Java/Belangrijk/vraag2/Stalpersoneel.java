package be.pxl.vraag2;

public final class Stalpersoneel extends Lid {
	private char embleem;
	
	public Stalpersoneel() {
		super();
	}
	
	public void kenEmbleemToe(char embleem) {
		this.embleem = embleem;
	}
	
	public char getEmbleem() {
		return this.embleem;
	}

	@Override
	public void bepaalLidnummer() {
		this.setLidnummer(this.getVoornaam().toUpperCase());
	}
	
	@Override
	public boolean equals(Object object) {
		if (object != null && object instanceof Stalpersoneel) {
			Stalpersoneel temp = (Stalpersoneel) object;
			if (this.getVoornaam().equals(temp.getVoornaam())) {
				return true;
			}
		}
		return false;
	}
	
	@Override
	public String toString() {
		return super.toString() + "        " + this.embleem;
	}
}
