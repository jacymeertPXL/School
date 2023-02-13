package be.pxl.h3.oefening_02;

public class Main {
    public static void main(String[] args) {
        Munt munt = new Munt();
        Munt[] munten = new Munt[10];

        munten[0] = new Munt("Britse pond", 0.985);
        munten[1] = new Munt();
        munten[2] = new Munt("Amerikaanse dollar", 1.287);
        munten[3] = new Munt("Russische roebel", 86.950);

        System.out.println("overzicht koersen tov de euro: 1 euro =");
        String formaat = "%10." + munt.getAfronding() + "f %s%n";

        for (Munt value : munten) {
            if (value != null){
                System.out.printf(formaat, value.getKoers(), value.getNaam());
            }
        }

        System.out.println();
        System.out.println("overzicht koersen tov " + munten[0].getNaam() + ": 1 "
                + munten[0].getNaam() + " =");

        for (int i = 1 ; i < munten.length; i++) {
            if (munten[i] != null){
                double res = 1 / munten[0].getKoers() * munten[i].getKoers();
                System.out.printf(formaat, res, munten[i].getNaam());
            }
        }

        System.out.println("overzicht koersen tov " + munten[2].getNaam() + ": 1 "
                + munten[2].getNaam() + " =");

        for (int i = 1 ; i < munten.length; i++) {
            if (munten[i] != null){
                double res = 1 / munten[2].getKoers() * munten[i].getKoers();
                System.out.printf(formaat, res, munten[i].getNaam());
            }
        }

        System.out.println("overzicht koersen tov " + munten[3].getNaam() + ": 1 "
                + munten[3].getNaam() + " =");

        for (int i = 1 ; i < munten.length; i++) {
            if (munten[i] != null){
                double res = 1 / munten[3].getKoers() * munten[i].getKoers();
                System.out.printf(formaat, res, munten[i].getNaam());
            }
        }
    }
}
