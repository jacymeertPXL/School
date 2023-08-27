package be.pxl.vraag2;

public class Les implements Betaalbaar, Printbaar {

	private boolean groepsLes;
	private int aantalLesnemers;
	private final static int MAX_AANTAL_LESNEMERS = 6;
	private Lesgever lesgever;
	private Lesnemer[] lesnemers = new Lesnemer[this.MAX_AANTAL_LESNEMERS];

	public Les(Lesgever lesgever, Lesnemer lesnemer, boolean groepsles) {
		this.lesgever = lesgever;
		this.lesnemers[0] = lesnemer;
		this.groepsLes = groepsles;
		this.aantalLesnemers = 1;
	}

	public Les(Lesnemer lesnemer, boolean groepsles) {
		lesgever = new Lesgever();
		this.lesnemers[0] = lesnemer;
		this.groepsLes = groepsles;
	}

	public Les(Lesnemer lesnemer) {
		this.groepsLes = true;
		lesgever = new Lesgever();

	}

	public int getAantalLesnemers() {
		return this.aantalLesnemers;
	}

	public void voegLesnemerToe(Lesnemer... lesnemers) {
		if (this.groepsLes) {
			int openPlaatsen = 0;
			for (int i = 0; i < this.lesnemers.length; i++) {
				if (this.lesnemers[i] == null) {
					openPlaatsen++;
				}
			}

			if (openPlaatsen < lesnemers.length) {
				System.out.println("De lesnemers zijn niet toegevoegd want er is niet voldoende plaats in de les");
			} else {
				int eersteOpenPlaats = 0;
				for (int i = 0; i < this.lesnemers.length; i++) {
					if (this.lesnemers[i] == null) {
						eersteOpenPlaats = i;
						i = this.lesnemers.length;
					}
				}
				int count = 0;
				for (int i = eersteOpenPlaats; i < lesnemers.length; i++) {
					this.lesnemers[i] = lesnemers[count];
					count++;
					this.aantalLesnemers++;
				}
			}

		} else {
			System.out.println("Je kan geen lesnemers toevoegen aan een privé-les.");
		}
	}

	@Override
	public double berekenPrijs() {
		int prijs = 20;
		
		if (this.groepsLes) {
			for (int i = 0; i < this.lesnemers.length; i++) {
				if (this.lesnemers[i] != null) {
					prijs += 2;
				}
			}
		} else {
			prijs += 5;
			if (this.lesgever.getType() > 5 && Integer.parseInt(this.lesnemers[0].getLidSinds()) < 2000) {
				prijs += 5;
			}
		}
		
		return prijs;
	}

	@Override
	public void print() {
		for (int i = 0; i < this.lesnemers.length; i++) {
			if (this.lesnemers[i] != null) {
				System.out.printf("%-10s%-10s%-5s%-10s%-2.2f%-20d%-10s%-5s\n", this.lesgever.getVoornaam(), this.lesgever.getLidnummer(), this.lesgever.getType(), this.groepsLes, this.berekenPrijs(), this.aantalLesnemers, this.lesnemers[0].getVoornaam(), this.lesnemers[0].getNiveau());
			}
		}
	}

	@Override
	public void print(int aantal, char teken) {
		for (int i = 0; i < this.lesnemers.length; i++) {
			if (this.lesnemers[i] != null) {
				System.out.printf("%-10s%-10s%-5s%-10s%-2.2f%-20d%-10s%-5s\n", this.lesgever.getVoornaam(), this.lesgever.getLidnummer(), this.lesgever.getType(), this.groepsLes, this.berekenPrijs(), this.aantalLesnemers, this.lesnemers[0].getVoornaam(), this.lesnemers[0].getNiveau());
				for (int k = 0; k < aantal; k++) {
					System.out.print(teken);
				}
				System.out.println();
			}
		}
	}

}
