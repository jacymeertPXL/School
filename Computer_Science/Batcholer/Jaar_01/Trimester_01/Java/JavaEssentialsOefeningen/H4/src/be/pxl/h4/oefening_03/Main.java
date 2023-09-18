package be.pxl.h4.oefening_03;

public class Main {
    public static void print(Leraar l) {
        System.out.println("Leraar " + l.getNaam() + " is aangesteld voor " + l.getAanstelling() + "%");
        System.out.println("Volgende vakken behoren tot het takenpakket:");
        for (int jaar = 1; jaar <= 3; jaar++) {
            System.out.println("Vakken van jaar " + jaar + ":");
            for (int i = 0; i < l.getAantalVakken(); i++) {
                Vak v = l.getVak(i);
                if (v.getJaar().equals(jaar+"")) {
                    System.out.printf("%5s%-13s%-25s%d%n", " ", v.getCode(), v.getNaam(), v.getAantalSTP());
                }
            }
        }
    }

    public static void main(String[] args) {
        String codeTabel[] = {"4TIN1100", "48TIN1130", "41TIN1140", "41TIN1160", "41TIN1240", "41TIN1290", "41TIN1300", "42TIN1220", "42TIN1230", "43AON3120", "43AON3130"};
        String[] naamTabel = {"Web Essentials", "Java Essentials", ".Net Essentials", "Data Essentials", "System Essentials", "Data advanced", "IT Essentials", ".Net Advanced", "Java Advanced", "Software engineering", "Mobile development"};
        int[] stpTabel = {7, 6, 6, 3, 6, 6, 5, 3, 3, 3, 3};
        Vak[] vakken = new Vak[codeTabel.length];

        for (int i = 0; i < vakken.length; i++) {
            Vak v = new Vak(codeTabel[i], naamTabel[i], stpTabel[i]);
            vakken[i] = v;
        }

        Leraar ler1 = new Leraar("Daems", "Greta", 73);
        ler1.voegVakToe(vakken[1]);
        ler1.voegVakToe(vakken[6]);
        ler1.voegVakToe(vakken[9]);
        ler1.voegVakToe(vakken[7]);
        ler1.voegVakToe(vakken[8]);
        ler1.voegVakToe(vakken[0]);
        print(ler1);
    }
}
