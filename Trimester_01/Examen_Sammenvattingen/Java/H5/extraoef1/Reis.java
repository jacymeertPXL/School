package be.pxl.h5.exoef1;

public abstract class Reis {

    private String bestemming;
    private double prijs;

    public static final double MINIMUM_PRIJS = 5.0;

    public Reis(String bestemming) {
        this(bestemming, MINIMUM_PRIJS);
    }

    public Reis(String bestemming, double prijs) {
        this.setBestemming(bestemming);
        this.setPrijs(prijs);
    }

    public String getBestemming() {
        return bestemming;
    }

    public void setBestemming(String bestemming) {
        while(Character.isDigit(bestemming.charAt(0))) {
            bestemming = bestemming.substring(1);
        }
        this.bestemming = bestemming;
    }

    public double getPrijs() {
        return prijs;
    }

    public void setPrijs(double prijs) {
        this.prijs = Math.max(prijs, MINIMUM_PRIJS);
    }

    public String toString() {
        return String.format("Reis met bestemming %s kost %.2f euro", bestemming, prijs);
    }
}
