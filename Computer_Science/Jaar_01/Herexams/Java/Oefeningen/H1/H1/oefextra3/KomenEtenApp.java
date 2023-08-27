package be.pxl.h1.oefextra3;

import java.util.Scanner;

public class KomenEtenApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Geef het aantal deelnemers:");
        int aantalDeelnemers = scanner.nextInt();
        scanner.nextLine();
        Deelnemer[] deelnemers = new Deelnemer[aantalDeelnemers];
        for (int i = 0; i < aantalDeelnemers; i++) {
            System.out.println("Geef naam van deelnemer " + (i + 1) + ":");
            Deelnemer deelnemer = new Deelnemer();
            deelnemer.setNaam(scanner.nextLine(), aantalDeelnemers - 1);
            deelnemers[i] = deelnemer;
        }
        String[] onderdelen = {"SFEER", "ETEN"};
        for (Deelnemer deelnemer : deelnemers) {
            System.out.println("Punten voor " + deelnemer.getNaam());
            for (Deelnemer beoordelaar : deelnemers) {
                if (!beoordelaar.equals(deelnemer)) {
                    for (String onderdeel : onderdelen) {
                        System.out.println(beoordelaar.getNaam() + " geef uw punten voor " + onderdeel + ": ");
                        int punt = scanner.nextInt();
                        while (punt < 0 || punt > 10) {
                            System.out.println("Ongeldige punten!");
                            System.out.println(beoordelaar + " geef uw punten voor " + onderdeel + ": ");
                            punt = scanner.nextInt();
                        }
                        deelnemer.voegPuntToe(onderdeel, punt);
                    }
                }
            }
        }
        int hoogste = 0;
        Deelnemer winnaar = deelnemers[0];
        for (Deelnemer deelnemer : deelnemers) {
            System.out.println(deelnemer.getNaam() + " = " + deelnemer.getTotaal());
            if (deelnemer.getTotaal() > hoogste) {
                hoogste = deelnemer.getTotaal();
                winnaar = deelnemer;
            }
        }
        System.out.println("Winnaar: " + winnaar.getNaam());
        scanner.close();
    }
}
