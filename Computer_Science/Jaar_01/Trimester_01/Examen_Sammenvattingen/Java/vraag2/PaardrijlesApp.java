package be.pxl.vraag2;

public class PaardrijlesApp {

	public static void main(String[] args) {
		// 2 lesgevers aanmaken
		Lesgever laura = new Lesgever("Laura", "2002", 11);
		Lesgever marjolein = new Lesgever("Marjolein", "1997", 8);
		
		//4 lesnemers aanmaken
		Lesnemer erik = new Lesnemer();
		Lesnemer elise = new Lesnemer("Elise", "2005", 4);
		Lesnemer anna = new Lesnemer("Anna", "1995", 33);
		Lesnemer frits = new Lesnemer("Frits", "2015", 1);
		
		//1 stalpersoneel aanmaken en zijn lidnummer afprinten
		Stalpersoneel mats = new Stalpersoneel();
		System.out.println(mats.getLidnummer());
		System.out.println("------------------------------------------------------------------");
		
		ToegangManege toegangManege = new ToegangManege(3);
		//5 leden toevoegen aan de manege:
		//het derde lid (laura) is hetzelfde als het eerste ==> wordt niet toegevoegd; zie melding
		//het vijfde lid (anna) is teveel (slechts 3 mogelijk) ==> wordt niet toegevoegd; zie melding
		toegangManege.voegLidToe(laura);
		toegangManege.voegLidToe(frits);
		toegangManege.voegLidToe(laura);
		toegangManege.voegLidToe(mats);
		toegangManege.voegLidToe(anna);
		System.out.println("------------------------------------------------------------------");
		System.out.println("voornaam   embleem(stalpersoneel)");
		//print van de 3 leden van de manege nl laura, frits en xxx (mats)
		toegangManege.print();
		
		//5 lessen aanmaken
		Les les1 = new Les(erik);
		Les les2 = new Les(elise, false);
		Les les3 = new Les(laura, anna, true);
		Les les4 = new Les(marjolein, frits, true);
		Les les5 = new Les(marjolein, elise, false);
		//aan les 2 een lesnemer (anna) proberen toe te voegen; niet mogelijk owv privé les
		//en aan les3 2 lesnemers toevoegen 
		les2.voegLesnemerToe(anna);
		les3.voegLesnemerToe(frits, elise);
		System.out.println("------------------------------------------------------------------");
		
		//les3 printen
		les3.print();
		System.out.println();
		System.out.println("------------------------------------------------------------------");
		
		//het aantal lesnemers van les 3 printen = 3	
		System.out.println("het aantal lesnemers van les 3 is " +les3.getAantalLesnemers());
		System.out.println("------------------------------------------------------------------");
		
		Les[] lessen = new Les[5];
		lessen[0] = les1;
		lessen[1] = les2;
		lessen[2] = les3;
		lessen[3] = les4;
		lessen[4] = les5;
		
		System.out.println();
		System.out.println("De lessen van manege de Cavalerie");
		System.out.println();
		
		System.out.printf("%-10s %-10s %-5s %-10s %-6s %-16s %-18s %n" ,"lesgever", "lidnummer","type", "groepsles", "prijs", "aantalLesnemers", "naamLesnemers+niv");
		for (Les les : lessen) {
			les.print();
			System.out.println("");
		}
		
		System.out.println();
		
		System.out.printf("%-10s %-10s %-5s %-10s %-6s %-16s %-18s %n" ,"lesgever", "lidnummer", "type", "groepsles", "prijs", "aantalLesnemers", "naamLesnemers+niv");
		for (Les les : lessen) {
			les.print(120, '*');
			System.out.println("");
		}

	}

}
