package be.pxl.h2.oefening_01;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Persoon persoon = new Persoon();
        Scanner scanner = new Scanner(System.in);

        persoon.setVoornaam("Micheal");
        persoon.setNaam("Mystery");
        persoon.setGewicht(59.00);
        persoon.setLengte(1.85);
        persoon.setGeboortejaar(1984);

        System.out.println(persoon);
        System.out.println(persoon.getLengte());
        persoon.groei();
        System.out.println(persoon.getLengte());
        System.out.println("Hoeveel met de persoon groeien? ");
        int groei = scanner.nextInt();
        persoon.groei(groei);
        System.out.println(persoon.getLengte());
        persoon.groei(10);
        System.out.println(persoon.getLengte());
        System.out.println(persoon.geefOmschrijving());
        scanner.close();
    }
}
