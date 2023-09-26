package be.pxl.h4.oefening_04;

public class Persoon {

    private String naam;
    private String voornaam;
    private Datum geboortedatum = new Datum();
    private Adres adres = new Adres();

    public Persoon() {
        this("Meert", "Jacy", 18, 8, 2003, "teststraat", "11", 3500, "Hasselt");
    }

    public Persoon(String naam, String voornaam, int dag, int maand, int jaar, String straat, String huisnummer, int postcode, String gemeente) {
        this.naam = naam;
        this.voornaam = voornaam;
        geboortedatum.setDag(dag);
        geboortedatum.setMaand(maand);
        geboortedatum.setJaar(jaar);
        adres.setStraat(straat);
        adres.setHuisnr(huisnummer);
        adres.getGemeente().setGemeenteNaam(gemeente);
        adres.getGemeente().setPostcode(postcode);
    }

    public Persoon(String naam, String voornaam, Datum datum, Adres adres) {
        this.naam = naam;
        this.voornaam = voornaam;
        geboortedatum = datum;
        adres = adres;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getVoornaam() {
        return voornaam;
    }

    public void setVoornaam(String voornaam) {
        this.voornaam = voornaam;
    }

    public Datum getGeboortedatum() {
        return geboortedatum;
    }

    public Adres getAdres() {
        return adres;
    }

    public void setAdres(Adres adres) {
        this.adres = adres;
    }

    public void voegVoornamenToe(String... voornamen) {
        for (int i = 0; i < voornamen.length; i++) {
            this.voornaam = this.voornaam.concat(" ").concat(voornamen[i]);
        }
    }

    public String toString() {
        return this.voornaam + " " + this.naam + "\n" + adres.getStraat() + " " + adres.getHuisnr() + "\n"
                + adres.getGemeente().getPostcode() + " " + adres.getGemeente().getGemeenteNaam();
    }
}
