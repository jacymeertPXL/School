package be.pxl.h1.oefening_02;

import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        Zwembad zwembad = new Zwembad();
        System.out.println("Geef de breedte, lengte en diepte van u zwembad");
        zwembad.setBreedte(scanner.nextDouble());
        zwembad.setLengte(scanner.nextDouble());
        zwembad.setDiepte(scanner.nextDouble());
        double volumeWater = zwembad.getVolumeWater();
        System.out.println("Liter water " + volumeWater +"\n"+ "Liter Onstmettingsmiddel " + zwembad.getVolumeOnstmettingsmiddel());
    }
}
