package be.pxl.h7.oefextra1;

import java.util.Scanner;

public class TShirtApp {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int telMaat = TShirtSize.values().length;
        int telKleur = Kleur.values().length;
        TShirt[][] tshirt = new TShirt[telKleur][telMaat];
        for (Kleur k : Kleur.values()) {
            for (TShirtSize s : TShirtSize.values()) {
                tshirt[k.ordinal()][s.ordinal()] = new TShirt(s, k);
            }
        }

        System.out.print("geef een naam in:  ");
        String naam = input.next();

        while (!(naam.equals("stop") || naam.equals("Stop"))) {   //.equalsIgnoreCase()
            System.out.print("Geef borstomtrek in: ");
            int borst = input.nextInt();

            int i = 0;
            while (i < telMaat - 1 && TShirtSize.values()[i].getBorst() < borst) {  // let op: -1
                i++;
            }
            System.out.println("de maat die nodig is " + TShirtSize.values()[i]);

            System.out.print("Welke kleur wenst u? Beschikbare kleuren: ");
            for (Kleur k : Kleur.values()) {
                System.out.print(k + " (ingave " + k.ordinal() + ") ");
            }
            int keuze = input.nextInt();

            System.out.print("Hoeveel artikels wenst u? ");
            int aantal = input.nextInt();
            tshirt[keuze][i].setAantal(aantal + tshirt[keuze][i].getAantal());
            System.out.println("geef een naam in ");
            naam = input.next();
        }
        System.out.println();
        System.out.printf("%12s", " ");
        for (TShirtSize s : TShirtSize.values()) {
            System.out.printf("%10s   ", s);
        }
        System.out.println();
        for (Kleur k : Kleur.values()) {
            System.out.printf("%12s", k.name().toLowerCase());
            for (TShirtSize s : TShirtSize.values()) {
                System.out.printf("%10d   ", tshirt[k.ordinal()][s.ordinal()].getAantal());
            }
            System.out.println();
        }
        input.close();
    }

}


