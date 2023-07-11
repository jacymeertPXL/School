package be.pxl.h1.extraopdrachten;

public class ExtraOpracht2 {
    public static void main(String[] args) {
        int[] array1 = new int[20]; // maakt 20 spots in de array list
        for (int i = 0; i < array1.length; i++) {
            array1[i] = i * 7;
        }
        for (int getal : array1) {
            System.out.printf("%-4d", getal);
        }
        System.out.println();

        int[] array2 = new int[10];
        for (int i = 0; i < array2.length; i++) {
            array2[i] = 1 + (i * 2);
        }

        for (int getal : array2){
            System.out.printf("%-4d", getal);
        }

        System.out.println();

        for (int i = array2.length -1; i >= 0; i--){
            System.out.print(array2[i] + "\t");
        }

        System.out.println();
    }
}
