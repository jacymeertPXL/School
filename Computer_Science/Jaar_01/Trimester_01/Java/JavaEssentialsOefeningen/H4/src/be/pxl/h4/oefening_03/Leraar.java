package be.pxl.h4.oefening_03;

public class Leraar {

    private String naam;
    private String voornaam;
    private int aanstellingsPerc;
    private Vak[] vakken = new Vak[MAXAANTALVAKKEN];
    private int aantalVakken;
    private static final int MAXAANTALVAKKEN = 5;

    public Leraar(String n, String vn, int a) {
        naam = n;
        voornaam = vn;
        setAanstelling(a);
    }

    public String getNaam() {
        return naam + " " + voornaam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setVoornaam(String voornaam) {
        this.voornaam = voornaam;
    }

    public void voegVakToe(Vak v) {
        if (aantalVakken < 5) {
            vakken[aantalVakken] = v;
            aantalVakken++;
        } else {
            System.out.println("Deze leraar heeft reeds " + getMAX() + " vakken");
        }
    }

    public Vak getVak(int i) {
        if (i >= aantalVakken) {
            System.out.println("deze leraar heeft niet zoveel vakken");
            return null;
        } else {
            return vakken[i];
        }
    }

    public int getAanstelling() {
        return aanstellingsPerc;
    }

    public void setAanstelling(int a) {
        if (a > 100) {
            aanstellingsPerc = 100;
        } else {
            aanstellingsPerc = (int) (Math.round(a / 10.0) * 10);
        }
    }

    public int getAantalVakken() {
        return aantalVakken;
    }

    public static int getMAX() {
        return MAXAANTALVAKKEN;
    }
}

