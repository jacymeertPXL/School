package be.pxl.h3.oefening_01;

import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class Main {
    public static void main(String[] args) {
        //H02
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

        //Uitbreiding H03
        Persoon persoon2 = new Persoon();

        persoon2.setVoornaam("Jacy");
        persoon2.setNaam("Meert");
        persoon2.setGewicht(ThreadLocalRandom.current().nextInt(40, 100 + 1));
        persoon2.setLengte(ThreadLocalRandom.current().nextDouble(1.57, 2.10 + 1));
        persoon2.setGeboortejaar(2003);

        System.out.println(persoon2.geefNaamAfgekort());
        System.out.println(persoon2.encrypteerNaam());
        System.out.println(persoon2.geefOmschrijving());
    }
}
