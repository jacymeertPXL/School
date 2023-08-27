package be.pxl.h1.oefextra3;

public class Deelnemer {
    private String naam;
    private int[] puntenSfeer;
    private int[] puntenEten;
    private int positieSfeer = 0;
    private int positieEten = 0;

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam, int beoordelingen) {
        this.naam = naam;
        puntenSfeer = new int[beoordelingen];
        puntenEten = new int[beoordelingen];
    }

    public void setPuntenSfeer(int[] puntenSfeer) {
        this.puntenSfeer = puntenSfeer;
    }

    public void setPuntenEten(int[] puntenEten) {
        this.puntenEten = puntenEten;
    }

    public void voegPuntToe(String onderdeel, int punten) {
        if ("ETEN".equals(onderdeel)) {
            puntenEten[positieEten++] = punten;
        } else {
            puntenSfeer[positieSfeer++] = punten;
        }
    }

    public int getTotaal() {
        int totaal = 0;
        for (int punt: puntenEten) {
            totaal += punt;
        }
        for (int punt: puntenSfeer) {
            totaal += punt;
        }
        return totaal;
    }
}
