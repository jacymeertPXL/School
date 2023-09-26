package be.pxl.h1.extraopdrachten;

import java.util.Scanner;

public class ExtraOpdracht_02 {
    public static void main(String[] args) {
        // toon alle veelvouden van 10 die kleinr of gelijk is aan 100
        for (int veelvoud = 0; veelvoud <= 100; veelvoud += 10){
            System.out.printf("%-4d", veelvoud);
        }
        System.out.println();

        Scanner scanner = new Scanner(System.in);
        System.out.println("Geef de grootte van de driehoek in");
        int grootte = scanner.nextInt();
        System.out.println("Geef de beginletter in");

        char letterChar = scanner.next().charAt(0); // om een karakter in te lewen String inlezen en eerste letter opvragen
        for (int index = 1; index <= grootte; index++){
            for (int teller = 1; teller <= index; teller++){
                System.out.printf("%-3c", letterChar);
                letterChar++;
                if (letterChar > 'Z'){
                    letterChar = 'A';
                }
            }
            System.out.println();
        }
        // toon alle lettersr van het alfabet (in kleine letters)
        for (char lettersChar = 'a'; lettersChar <= 'z'; lettersChar++){
            System.out.printf("%c", lettersChar);
        }
        System.out.println();
    }
}
