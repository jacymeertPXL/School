package be.pxl.h4.oefening_04;

public class Main {
    public static void main(String[] args) {

        Datum datum1 = new Datum();
        System.out.println(datum1.getDag());

        Gemeente gem = new Gemeente(555555, "hE78rk-7dE-Stad");
        System.out.println(gem);

        Adres adres = new Adres("testtraat", "10", 3290, "Diest");
        adres.getGemeente().setGemeenteNaam("Hasselt");
        System.out.println(adres);

        Persoon persoon1 = new Persoon();
        Persoon persoon2 = new Persoon();
        persoon1.getAdres().getGemeente().setGemeenteNaam("Brussel");
        persoon2.getGeboortedatum().setJaar(1999);

        System.out.println(persoon1);
        System.out.println(persoon2);

        Huwelijk huwelijk1 = new Huwelijk();
        System.out.println(huwelijk1.getHuwelijkdsDatum().getJaar()); // test
        System.out.println(huwelijk1.getPersoon01().toString());
        huwelijk1.adresWijziging("teststraatje", "20", 3270, "Bekkevoort");
        huwelijk1.print();
    }
}
