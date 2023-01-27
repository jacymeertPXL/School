package be.pxl.h9.oef2; 


public abstract class Bouwgrond implements Verkoopbaar {
    private String perceelNummer;
    private String bouwVoorschrift;
    private double perceelGrootte;

    public Bouwgrond(String perceelNummer, double perceelGrootte) {
        setPerceelNummer(perceelNummer);
        setPerceelGrootte(perceelGrootte);
    }

    public String getPerceelNummer() {
        return perceelNummer;
    }

    public void setPerceelNummer(String perceelNummer) {
        this.perceelNummer = perceelNummer;
    }

    public String getBouwVoorschrift() {
        return bouwVoorschrift;
    }

    public void setBouwVoorschrift(String bouwVoorschrift) {
        this.bouwVoorschrift = bouwVoorschrift;
    }

    public double getPerceelGrootte() {
        return perceelGrootte;
    }

    public void setPerceelGrootte(double perceelGrootte) {
        this.perceelGrootte = perceelGrootte;
    }



}
