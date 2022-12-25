package be.pxl.h4.oefening_04;

import java.util.Arrays;

public class Datum {
    private int dag;
    private int maand;
    private int jaar;

    private String[] maandNamen = {"januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus",
            "september", "oktober", "november", "december"};

    public Datum() {
        this(1, 1, 2020);
    }

    public Datum(int dag, int maand, int jaar) {
        this.dag = dag;
        this.setMaand(maand); // ge doet dit omdat ge moet gaan controleren bij de setmaaad
        this.jaar = jaar;
    }

    public String toString() {
        return "" + this.dag + " " + Arrays.toString(this.getMaandNamen()) + " " + this.jaar;
    }

    public int getDag() {
        return dag;
    }

    public void setDag(int dag) {
        this.dag = dag;
    }

    public int getMaand() {
        return maand;
    }

    public void setMaand(int maand) {
        this.maand = maand;
        if (maand < 1) {
            this.maand = 1;
        } else if (maand > 12) {
            this.maand = 12;
        }
    }

    public int getJaar() {
        return jaar;
    }

    public void setJaar(int jaar) {
        this.jaar = jaar;
    }

    public String[] getMaandNamen() {
        return maandNamen;
    }

    public void setMaandNamen(String[] maandNamen) {
        this.maandNamen = maandNamen;
    }

    public void drukKalender(int[] kalanderdag, String[] kalenderNaam) {
        System.out.println("**** Kalender voor " + Arrays.toString(this.getMaandNamen()) + " " + this.jaar + " ****");
        for (int i = 0; i < 10; i++) {
            if (kalanderdag[i] == 0) {
                i = 10;
            }
            if (i != 10) {
                System.out.printf("%-2d %s %-15d %s\n", kalanderdag[i], Arrays.toString(this.getMaandNamen()), this.getJaar(), kalenderNaam[i]);
            }
        }
    }
}
