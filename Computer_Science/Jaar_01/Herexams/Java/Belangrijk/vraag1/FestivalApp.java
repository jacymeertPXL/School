package be.pxl.vraag1;

import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

public class FestivalApp {

	private static Festival festival;

	public static void main(String[] args) {

		LocalDate datum = LocalDate.of(2017, 04, 21);
		festival = new Festival("Vuurdoop", datum, 4);

		MuziekBand snoop = new MuziekBand("Snoop Dogg", Genre.RAP, -4);
		MuziekBand spoon = new MuziekBand("Spoon", Genre.ROCK, 5);
		MuziekBand mill = new MuziekBand("Millionaire", Genre.ROCK, 4);
		MuziekBand steak = new MuziekBand("Steak Number Eight", Genre.METAL, 5);
		MuziekBand paak = new MuziekBand("Anderson .Paak", Genre.HIPHOP, 1);
		Comedian wim = new Comedian("Wim Helsen", "Er wordt naar u geluisterd");
		Comedian bart = new Comedian("Bart Cannaerts", "Wanneer gaan we nog eens bowlen?");
		MuziekBand dimi = new MuziekBand("Dimitri Vegas & Like Mike", Genre.DANCE, 0);

		addOptreden(bart, LocalTime.of(17, 35), LocalTime.of(17, 00));
		addOptreden(spoon, LocalTime.of(19, 15), LocalTime.of(20, 00));
		addOptreden(steak, LocalTime.of(20, 30), LocalTime.of(21, 30));
		addOptreden(paak, LocalTime.of(20, 30), LocalTime.of(21, 30));
		addOptreden(snoop, LocalTime.of(20, 40), LocalTime.of(21, 40));
		addOptreden(mill, LocalTime.of(22, 15), LocalTime.of(23, 30));
		addOptreden(wim, LocalTime.of(17, 00), LocalTime.of(17, 35));
		addOptreden(dimi, LocalTime.of(23, 40), LocalTime.of(23, 50));

		System.out.println(festival);

		System.out.println("Prijs festival: " + festival.getPrijs());
	}

	public static void addOptreden(Artiest artiest, LocalTime start, LocalTime einde) {
		try {
			festival.addOptreden(artiest, start, einde);
		} catch (FestivalVolgeboektException | OptredenOverlapException e) {
			System.out.println(e.getMessage());
		}
	}
	

}
