package be.pxl.h1.oef4;

import java.util.Scanner;

public class HotelApp {
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Geef het aantal volwassenen:");
        int aantalVolwassenen = keyboard.nextInt();
        System.out.print("Geef het aantal kinderen:");
        int aantalKinderen = keyboard.nextInt();

        System.out.print("Geef een hotelcode:");
        String hotelcode = keyboard.next();

        String resultaat = "";  
        while (!hotelcode.equals("/")) {
            Hotel hotel = new Hotel();
            hotel.setHotelcode(hotelcode);
            System.out.print("Geef het aantal sterren: ");
            hotel.setAantalSterren(keyboard.nextInt());
            keyboard.nextLine();  // rariteit
            System.out.print("Geef een kindercode:");
            char kindercode = keyboard.nextLine().charAt(0);
            hotel.setKindercode(kindercode);
            //invoercontrole
            while (!(kindercode >= 'A' && kindercode <= 'Z')) {
                System.out.print("foutieve kindercode: moet tussen A en Z liggen");
                kindercode = keyboard.nextLine().charAt(0);
            }

            double totaalBedrag = aantalKinderen * hotel.getPrijsKind() + aantalVolwassenen * hotel.getPrijs();
            resultaat += String.format("%2s%-5s %5.2f %5.2f %5.2f\n", hotelcode, hotel.getSterren(), hotel.getPrijs(), hotel.getPrijsKind(), totaalBedrag);
            System.out.print("Geef een hotelcode:");
            hotelcode = keyboard.next();
        }
        System.out.println(resultaat);
        keyboard.close();
    }
}

