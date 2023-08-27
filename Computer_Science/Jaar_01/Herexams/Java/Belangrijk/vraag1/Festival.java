package be.pxl.vraag1;

import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

public class Festival {
	private Optreden[] optredens;
	private String naam;
	private LocalDate datum;
	private int aantalToegevoegdeOptredens;
	private int maxAantalOptredens;

	public Festival(String naam, LocalDate datum, int maxAantalOptredens) {
		this.naam = naam;
		this.datum = datum;
		this.maxAantalOptredens = maxAantalOptredens;
		optredens = new Optreden[this.maxAantalOptredens];
	}

	public String getNaam() {
		return naam;
	}

	public LocalDate getDatum() {
		return datum;
	}

	public void addOptreden(Artiest artiest, LocalTime start, LocalTime einde)
			throws FestivalVolgeboektException, OptredenOverlapException {
		int count = 0;

		for (int o = 0; o < optredens.length; o++) {
			if (optredens[o] != null && optredens[o].overlaps(new Optreden(artiest, start, einde))) {
				DateTimeFormatter formatter = DateTimeFormatter.ofPattern("HH:mm");
				throw new OptredenOverlapException("Het optreden [" + start.format(formatter) + " - "
						+ einde.format(formatter) + " | " + artiest.getNaam() + "] overlapt met een ander optreden.");
			}
		}

		for (int i = 0; i < optredens.length; i++) {
			if (optredens[i] == null) {
				optredens[i] = new Optreden(artiest, start, einde);
				count++;
				i = optredens.length;
			}
		}

		if (count == 0) {
			throw new FestivalVolgeboektException("Het maximum aantal optredens in bereikt.");
		}
	}

	public int getPrijs() {
		int totaal = 0;
		for (int i = 0; i < optredens.length; i++) {
			totaal += optredens[i].artiest.getPrijs();
		}
		return totaal;
	}

	public String getOptredens() {
		StringBuilder tekst = new StringBuilder("");

		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("HH:mm");
		for (int i = 0; i < optredens.length; i++) {
			if (optredens[i] != null) {
				tekst.append(optredens[i].starttijd.format(formatter));
				tekst.append(" - ");
				tekst.append(optredens[i].eindtijd.format(formatter));
				tekst.append(" | ");
				tekst.append(optredens[i].toString());
				tekst.append("\n");
			}
		}

		return tekst.toString();
	}
	
	@Override
	public String toString() {
		StringBuilder tekst = new StringBuilder("");
		
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM");
		tekst.append(this.getNaam()).append(" :: ").append(this.getDatum().format(formatter)).append("\n");
		tekst.append(this.getOptredens());
		
		return tekst.toString();
	}

}
