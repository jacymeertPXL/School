package be.pxl.h1.oef3;

public class Voetballer {
    private String naam;
    private int leeftijd;
    private int beoordelingscijfer;
    private String typeSpeler;
    private int aantalDoelpunten;

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setLeeftijd(int leeftijd) {
        this.leeftijd = leeftijd;
    }

    public void setBeoordelingscijfer(int beoordelingscijfer) {
        this.beoordelingscijfer = beoordelingscijfer;
    }

    public void setTypeSpeler(String typeSpeler) {
        this.typeSpeler = typeSpeler;
    }

    public void setAantalDoelpunten(int aantalDoelpunten) {
        this.aantalDoelpunten = aantalDoelpunten;
    }

    public double berekenPrijs(){
        double basisprijs;

        if (typeSpeler.equals("aanvaller")){
            basisprijs = 30000;
        } else if (typeSpeler.equals("middenvelder")){
            basisprijs = 28000;
        } else if (typeSpeler.equals("verdediger")){
            basisprijs = 29000;
        } else {
            basisprijs = 25000;
        }

        if (leeftijd < 25) {
            basisprijs = basisprijs * 1.1;
        } else if (leeftijd > 30) {
            basisprijs = basisprijs * 0.95;
        }

        if (typeSpeler.equals("Aanvaller")) {
            if (aantalDoelpunten > 5) {
                basisprijs += (5 * 10000) + ((aantalDoelpunten - 5) * 20000);
            } else {
                basisprijs += aantalDoelpunten * 10000;
            }
        } else {
            basisprijs += 10000 * beoordelingscijfer;
            if (typeSpeler.equals("Doelman") && aantalDoelpunten >= 20) {
                basisprijs -= 9000;
            }
        }

        return basisprijs;
    }

}
