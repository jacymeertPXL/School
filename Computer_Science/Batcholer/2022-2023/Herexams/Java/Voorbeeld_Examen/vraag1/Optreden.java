package be.pxl.vraag1;

import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

public class Optreden {
	Artiest artiest;
	LocalTime starttijd;
	LocalTime eindtijd;
	
	public Optreden(Artiest artiest, LocalTime starttijd, LocalTime eindtijd) {
		this.artiest = artiest;
		this.starttijd = starttijd;
		this.eindtijd = eindtijd;
	}
	
	public boolean overlaps(Optreden anderOptreden) {
		if (this.starttijd.isBefore(anderOptreden.eindtijd) && this.eindtijd.isAfter(anderOptreden.starttijd)) {
			return true;
		} else {
			return false;
		}
	}
	
	public void setStartEindTijd(LocalTime start, LocalTime einde) throws OngeldigeStartEindTijdException {
		if (start.isBefore(einde)) {
			this.starttijd = start;
			this.eindtijd = einde;
		} else {
			DateTimeFormatter formatter = DateTimeFormatter.ofPattern("HH:mm");
			throw new OngeldigeStartEindTijdException("Ongeldige start- en eindtijd [" + this.starttijd.format(formatter) + ", " + this.eindtijd.format(formatter) + "].");
		}
	}
	
	@Override
	public String toString() {
		return this.artiest.toString();
	}
}
