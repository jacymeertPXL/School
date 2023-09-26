package be.pxl.h1.oefening_04;

public class Hotel {
    private String hotelcode;
    private int aantalSterren;
    private char kindercode;

    public String getHotelcode() {
        return hotelcode;
    }

    public void setHotelcode(String hotelcode) {
        this.hotelcode = hotelcode;
    }

    public int getAantalSterren() {
        return aantalSterren;
    }

    public void setAantalSterren(int aantalSterren) {
        this.aantalSterren = aantalSterren;
    }

    public char getKindercode() {
        return kindercode;
    }

    public void setKindercode(char kindercode) {
        this.kindercode = kindercode;
    }

    public String getSterren() {
        String symbolen;
        if (aantalSterren == 1) {
            symbolen = "*";
        } else if (aantalSterren == 2) {
            symbolen = "**";
        } else if (aantalSterren == 3) {
            symbolen = "***";
        } else if (aantalSterren == 4) {
            symbolen = "****";
        } else {
            symbolen = "";
        }
        return symbolen;
    }

    public double getPrijs() {
        double prijs;
        if (hotelcode.equals("HI")) {
            prijs = 70;
        } else {
            if (aantalSterren >= 4) {
                prijs = 60;
            } else if (aantalSterren == 3) {
                if (hotelcode.equals("BR") || hotelcode.equals("AN")) {
                    prijs = 60;
                } else {
                    prijs = 56;
                }
            } else {
                prijs = 48;
            }
        }
        return prijs;
    }

    public double getPrijsKinderen() {
        double kinderPrijs = 0;
        if (kindercode == ('A') && (aantalSterren < 3||hotelcode.equals("HA"))){
            kinderPrijs = 0;
        }else{
            kinderPrijs = getPrijs() / 2;
        }
        return kinderPrijs;
    }
}

