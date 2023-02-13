package be.pxl.h5.exoef1;

public class VliegtuigReis extends Reis {

    private String vluchtnummer;

    public static final int MINIMUM_PRIJS = 25;

    public VliegtuigReis(String bestemming) {
        this(bestemming, MINIMUM_PRIJS, bestemming.charAt(0) + "999");
    }

    public VliegtuigReis(String bestemming, double prijs, String vluchtnummer) {
        super(bestemming, prijs);
        this.vluchtnummer = vluchtnummer;
    }

    public String getVluchtnummer() {
        return vluchtnummer;
    }

    public void setVluchtnummer(String vluchtnummer) {
        if(vluchtnummer.charAt(0) != getBestemming().charAt(0)) {
            vluchtnummer = getBestemming().charAt(0) + vluchtnummer;
        }
        this.vluchtnummer = vluchtnummer;
    }

    public String toString() {
        StringBuilder builder = new StringBuilder();
        builder.append(super.toString());
        builder.append(System.lineSeparator());
        builder.append(String.format("Vliegtuigreis (vluchtnr %s)", vluchtnummer));

        return builder.toString();
    }
}
