package be.pxl.h3.oefening_01;

import java.util.Random;

public class Persoon {
    private String voornaam;
    private String naam;
    private double lengte;
    private double gewicht;
    private int geboortejaar;

    public Persoon(String naam, String voornaam){
        this.voornaam = voornaam;
        this.naam = naam;
    }

    public Persoon(){
        this("onbekend", "onbekend");
    }

    public Persoon(Persoon persoon){
        this(persoon.naam, persoon.voornaam);
        persoon.geboortejaar = geboortejaar;
        persoon.gewicht = gewicht;
        persoon.lengte = lengte;
    }

    public String geefNaamAfgekort(){
        StringBuilder stringBuilder = new StringBuilder();
        String afkorting = String.valueOf(this.voornaam.charAt(0));
        stringBuilder.append(afkorting.toUpperCase()).append(".").append(this.naam.substring(0, 1).toUpperCase());
        return stringBuilder.toString();
    }

    public String encrypteerNaam(){
        Random random = new Random();
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append(voornaam).append(" ").append(voornaam);
        int value = random.nextInt(21);
        for (int i = 0; i < stringBuilder.length(); i++) {
            stringBuilder.charAt(i);
        }
        return stringBuilder.toString();
    }

    public String toString() {
        StringBuilder tekst = new StringBuilder(String.format("Deze persoon is %s %s\n", this.voornaam.toUpperCase(), this.naam.toUpperCase()));
        tekst.append(String.format("%-15s : %.1f\n", "gewicht", this.gewicht));
        tekst.append(String.format("%-15s : %.2f\n", "lengte", this.lengte));
        tekst.append(String.format("%-15s : %d\n", "geboortejaar", this.geboortejaar));
        return tekst.toString();
    }

    public String getVoornaam() {
        return voornaam;
    }

    public void setVoornaam(String voornaam) {
        this.voornaam = voornaam;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public double getLengte() {
        return lengte;
    }

    public void setLengte(double lengte) {
        this.lengte = lengte;

        if (this.lengte > 2.4){
            this.lengte = 2.4;
        }
    }
    public double getGewicht() {
        return gewicht;
    }

    public void setGewicht(double gewicht) {
        this.gewicht = gewicht;
    }

    public int getGeboortejaar() {
        return geboortejaar;
    }

    public void setGeboortejaar(int geboortejaar) {
        this.geboortejaar = geboortejaar;
    }

    public double bekerenBmi(){
        double bmi = (this.gewicht / (this.lengte * this.lengte));
        return bmi;
    }

    public int getLeeftijd() {
        return (2022- this.geboortejaar);
    }

    public void voegVoornamenToe(String... voornamen){
        StringBuilder tekst = new StringBuilder(this.getVoornaam());
        for (int i = 0; i < voornamen.length; i++){
            tekst.append(" ");
            tekst.append(voornamen[i]);
        }
        this.setVoornaam(tekst.toString());
    }

    public String geefOmschrijving() {
        if (this.bekerenBmi() < 18) {
            return "ondergewicht";
        } else {
            if (this.bekerenBmi() < 25) {
                return "normaal";
            } else {
                if (this.bekerenBmi() < 30) {
                    return "overgewicht";
                } else {
                    if (this.bekerenBmi() < 40) {
                        return "obesitas";
                    } else {
                        return "morbide obesitas";
                    }
                }
            }
        }
    }

    public void groei() {
        this.setLengte(this.lengte + 0.01);
    }

    public void groei(int cm) {
        this.setLengte(this.lengte + (cm / 100.0));
    }

}
