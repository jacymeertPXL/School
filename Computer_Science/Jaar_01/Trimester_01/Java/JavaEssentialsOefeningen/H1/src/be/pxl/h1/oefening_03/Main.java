package be.pxl.h1.oefening_03;

import java.util.Objects;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        voetbalploeg voetbalploeg = new voetbalploeg();

        Scanner scanner = new Scanner(System.in);
        System.out.println("geef de naam, leeftijd, positie ,beoordeling en doelpunten van de speler. ");


        String naam = "";
        while (!Objects.equals(naam, "stop")){
            naam = scanner.next();

            int leeftijd = scanner.nextInt();
            voetbalploeg.setLeeftijd(leeftijd);

            String positie = scanner.next();
            voetbalploeg.setTypespeler(positie);

            int beoordeling = scanner.nextInt();
            voetbalploeg.setGemiddeldBeoordelingCijfer(beoordeling);

            int doelpunten = scanner.nextInt();
            voetbalploeg.setDoelpunten(doelpunten);

            System.out.println(voetbalploeg.berekeningPrijs());
        }
    }
}
