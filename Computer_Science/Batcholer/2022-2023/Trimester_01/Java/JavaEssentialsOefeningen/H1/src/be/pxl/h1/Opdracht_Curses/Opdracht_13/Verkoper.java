package be.pxl.h1.Opdracht_Curses.Opdracht_13;

public class Verkoper {
    private String naam;
    private double [] verkoopcijfers = new double[12];

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setVerkoopcijfers(int maandnr, double verkocht) {
        verkoopcijfers[maandnr -1] = verkocht;
    }

    public double getTotaalVerkocht(){
        double totaal = 0;
        for (double bedrag : verkoopcijfers){
            totaal += bedrag;
        }
        return totaal;
    }

    public double getGemiddeldeVerkocht(){
        return getTotaalVerkocht() / verkoopcijfers.length;
    }
}
