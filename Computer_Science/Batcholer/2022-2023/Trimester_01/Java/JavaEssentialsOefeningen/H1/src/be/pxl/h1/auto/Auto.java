package be.pxl.h1.auto;

public class Auto {
    private String merk;
    private String kleur;
    private int kilimeterstand;
    private int aantalDeuren;

    public String getMerk() {
        return merk;
    }

    public void setMerk(String merk) {
        this.merk = merk;
    }

    public String getKleur() {
        return kleur;
    }

    public void setKleur(String kleur) {
        this.kleur = kleur;
    }

    public int getKilimeterstand() {
        return kilimeterstand;
    }

    public void setKilimeterstand(int kilimeterstand) {
        this.kilimeterstand = kilimeterstand;
    }

    public int getAantalDeuren() {
        return aantalDeuren;
    }

    public void setAantalDeuren(int aantalDeuren) {
        this.aantalDeuren = aantalDeuren;
    }

    public void rijden (int[] afstandan){
        kilimeterstand += afstandan;
    }
}

