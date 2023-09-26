package be.pxl.h1.oef3;

import java.util.Scanner;

public class VoetballerApp {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Naam: ");
        String naam = scanner.nextLine();

        while (!naam.equals("stop")) {
            Voetballer voetballer = new Voetballer();
            voetballer.setNaam(naam);

            System.out.print("Leeftijd: ");
            voetballer.setLeeftijd(scanner.nextInt());
            scanner.nextLine(); 

            System.out.print("Positie: ");
            voetballer.setTypeSpeler(scanner.nextLine());

            System.out.print("Beoordeling: ");
            voetballer.setBeoordelingscijfer(scanner.nextInt());

            System.out.print("Doelpunten: ");
            voetballer.setAantalDoelpunten(scanner.nextInt());
            scanner.nextLine(); 

            System.out.printf("Prijs: €%.2f%n", voetballer.berekenPrijs());

            System.out.print("Naam: ");
            naam = scanner.nextLine();
        }
        scanner.close();
    }

}
