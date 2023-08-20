package be.pxl.h1.oefening_03;

import java.util.Objects;

public class voetbalploeg {
    private int leeftijd;
    private int gemiddeldBeoordelingCijfer;
    private String typespeler;
    private int doelpunten;

    public int getLeeftijd() {
        return leeftijd;
    }

    public void setLeeftijd(int leeftijd) {
        this.leeftijd = leeftijd;
    }

    public int getGemiddeldBeoordelingCijfer() {
        return gemiddeldBeoordelingCijfer;
    }

    public void setGemiddeldBeoordelingCijfer(int gemiddeldBeoordelingCijfer) {
        this.gemiddeldBeoordelingCijfer = gemiddeldBeoordelingCijfer;
    }

    public String getTypespeler() {
        return typespeler;
    }

    public void setTypespeler(String typespeler) {
        this.typespeler = typespeler;
    }

    public int getDoelpunten() {
        return doelpunten;
    }

    public void setDoelpunten(int doelpunten) {
        this.doelpunten = doelpunten;
    }

    public double berekeningPrijs() {
        double basisprijs;
        int bonusPrijs = 0;

        if (Objects.equals(typespeler, "aanvaller")) {

            if (doelpunten <= 5) {
                bonusPrijs += 10000 * doelpunten;
            } else {
                bonusPrijs += 50000 * (doelpunten - 5) * 20000;
            }

            basisprijs = 30000;

        } else if (Objects.equals(typespeler, "middenvelder")) {
            bonusPrijs += 10000 * gemiddeldBeoordelingCijfer;
            basisprijs = 29000; // andere basis prijs

        } else if (Objects.equals(typespeler, "verdediger")) {

            bonusPrijs += 10000 * gemiddeldBeoordelingCijfer;
            basisprijs = 28000; // andere basis prijs

        } else {
            bonusPrijs += 10000 * gemiddeldBeoordelingCijfer;
            basisprijs = 25000; // andere basis prijs
            bonusPrijs -= 9000;

        }

        if (leeftijd <= 25) {
            basisprijs = (basisprijs * 1.10);

        } else if (leeftijd >= 30) {
            basisprijs -= (basisprijs * 0.95);
        }

        return basisprijs + bonusPrijs;
    }
}
