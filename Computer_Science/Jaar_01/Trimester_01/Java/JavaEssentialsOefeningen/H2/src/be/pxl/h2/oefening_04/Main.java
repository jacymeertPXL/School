package be.pxl.h2.oefening_04;

public class Main {
    public static void main(String[] args) {
        Scanner Input = new Scanner();
        String naam = Input.readline("jacy");
        int leeftijd = Input.readint(19);
        System.out.println("Welkom, " + naam);
        System.out.println("Wauw, al " + leeftijd + "?");
    }
}
