package be.pxl.h1.Opdracht_Curses.Opdracht_13;

import java.util.Scanner;

public class VerkoopApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Verkoper verkoper = new Verkoper();
        System.out.println("Geef je naam in ");
        String naam = scanner.nextLine();
        verkoper.setNaam(naam);
        System.out.println("Voor de 10 maancijfers in op 1 regel");
        for (int i = 1; i <= 12; i++){
            verkoper.setVerkoopcijfers(i, scanner.nextDouble());
        }
        System.out.printf("verkoper %S heeft op een jaar voor %.0f verkocht%n", verkoper.getNaam(), verkoper.getTotaalVerkocht());
        System.out.printf("Deze verkoper verkocht gemiddeld per maand voor %.0f%n", verkoper.getGemiddeldeVerkocht());

        // extra

        Verkoper[] verkopers = new Verkoper[3];
        for (int j = 0; j < verkopers.length; j++){
            verkopers[j] = new Verkoper(); // Verkoper wordt hier pas aangemaakt
            System.out.println("Geef je naam in ");
            String naam2 = scanner.nextLine();
            verkopers[j].setNaam(naam2);
            System.out.println("Voor de 10 maancijfers in op 1 regel");
            for (int i = 1; i <= 12; i++){
                verkopers[j].setVerkoopcijfers(i, scanner.nextDouble());
            }
            System.out.printf("verkoper %S heeft op een jaar voor %.0f verkocht%n", verkopers[j].getNaam(), verkopers[j].getTotaalVerkocht());
            System.out.printf("Deze verkoper verkocht gemiddeld per maand voor %.0f%n", verkopers[j].getGemiddeldeVerkocht());
        }
    }
}
