package be.pxl.h1.oef4;

public class Hotel {
    private String hotelcode;
    private int aantalSterren;
    private char kindercode;

    public String getSterren(){
        String sterren = "";
        for (int i = 1; i <= aantalSterren; i++) {
            sterren += "*";
        }
        return sterren;
    }

    public double getPrijs(){
        double prijsVolwassene = 48;
        if (hotelcode.equals("HI")) {
            prijsVolwassene = 70;
        } else if (aantalSterren == 4 || aantalSterren == 5) {
            prijsVolwassene = 60;
        } else if (aantalSterren == 3) {
            if (hotelcode.equals("BR") || hotelcode.equals("AN")) {
                prijsVolwassene = 60;
            } else {
                prijsVolwassene = 56;
            }
        }
        return prijsVolwassene;
    }

    public void setHotelcode(String hotelcode) {
        this.hotelcode = hotelcode;
    }

    public void setAantalSterren(int aantalSterren) {
        this.aantalSterren = aantalSterren;
    }

    public void setKindercode(char kindercode) {
        this.kindercode = kindercode;
    }

    public double getPrijsKind(){
        double prijsKind = getPrijs() / 2.0;
        if (kindercode == 'A') {
            if (hotelcode.equals("HA") || aantalSterren == 1 || aantalSterren == 2) {
                prijsKind = 0;
            }
        }
        return prijsKind;
    }
}
