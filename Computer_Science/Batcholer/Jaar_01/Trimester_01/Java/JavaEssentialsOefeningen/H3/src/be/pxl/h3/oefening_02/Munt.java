package be.pxl.h3.oefening_02;

public class Munt {
    private String naam;

    private double koers;
    private static final int AFRONDING = 3;

    private int aantal;

    public Munt(String naam, double koers){
        this.naam = naam;
        this.koers = koers;
        aantal++;
    }

    public Munt(){
        this("euro", 1.000);
    }

    public String getNaam() {
        return naam.toUpperCase();
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public double getKoers() {
        return koers;
    }

    public void setKoers(double koers) {
        this.koers = koers;
    }

    public int getAfronding() {
        return AFRONDING;
    }

    public int getAantal() {
        return aantal;
    }
}
