package be.pxl.h1.oefening_01;

import java.util.Scanner;

public class MijnToren {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Toren toren = new Toren();
        System.out.println("Geef alle waarden van u toren in");
        String naam = scanner.nextLine();
        String locatie = scanner.nextLine();
        int voltooid = scanner.nextInt();
        int HoogteZonderAntenne = scanner.nextInt();
        int Verdieping = scanner.nextInt();
        toren.setNaam(naam);
        toren.setLocatie(locatie);
        toren.setVoltooid(voltooid);
        toren.setHoogteZonderAntenne(HoogteZonderAntenne);
        toren.setVerdieping(Verdieping);
        System.out.println(toren.weergeven());
    }
}
