package be.pxl.h4.oefening_04;

import java.util.Arrays;

public class Huwelijk {
    private Persoon persoon01 = new Persoon();
    private Persoon persoon02 = new Persoon();
    private Datum huwelijkdsDatum = new Datum();

    public Huwelijk(){

    }

   // public Huwelijk(){
   //     persoon02.getAdres().setStraat(persoon01.getAdres().getStraat());
   //     persoon02.getAdres().setHuisnr(persoon01.getAdres().getHuisnr());
   //     persoon02.getAdres().getGemeente().setGemeenteNaam(persoon01.getAdres().getGemeente().getGemeenteNaam());
   //     persoon02.getAdres().getGemeente().setPostcode(persoon01.getAdres().getGemeente().getPostcode());
   //     System.out.println(persoon01.getVoornaam() + " " + persoon01.getNaam() + " en " + persoon02.getVoornaam() + " "
   //             + persoon02.getNaam() + " zijn gehuwd op " + huwelijkdsDatum.getDag() + " " + Arrays.toString(huwelijkdsDatum.getMaandNamen()) + " "
   //             + huwelijkdsDatum.getJaar() + ". Proficiat!");
   // }

    public Huwelijk(Persoon persoon01, Persoon persoon02, int dag, int maand, int jaar){
        this.persoon01 = persoon01;
        this.persoon02 = persoon02;
        huwelijkdsDatum.setDag(dag);
        huwelijkdsDatum.setMaand(maand);
        huwelijkdsDatum.setJaar(jaar);
    }

    public void adresWijziging(String straat, String huisnummer, int postcode, String gemeente) {
        persoon01.getAdres().setStraat(straat);
        persoon01.getAdres().setHuisnr(huisnummer);
        persoon01.getAdres().getGemeente().setGemeenteNaam(gemeente);
        persoon01.getAdres().getGemeente().setPostcode(postcode);
        persoon02.getAdres().setStraat(straat);
        persoon02.getAdres().setHuisnr(huisnummer);
        persoon02.getAdres().getGemeente().setGemeenteNaam(gemeente);
        persoon02.getAdres().getGemeente().setPostcode(postcode);
    }

    public void print() {
        System.out.println(persoon01.toString());
        System.out.println("Geboren op " + persoon01.getGeboortedatum().getDag() + " "
                + Arrays.toString(persoon01.getGeboortedatum().getMaandNamen()) + " " + persoon01.getGeboortedatum().getJaar() + "\n");
        System.out.println(persoon02.toString());
        System.out.println("Geboren op " + persoon02.getGeboortedatum().getDag() + " "
                + Arrays.toString(persoon02.getGeboortedatum().getMaandNamen()) + " " + persoon02.getGeboortedatum().getJaar() + "\n");
        System.out.println("het huwelijk vond plaats op " + huwelijkdsDatum.getDag() + " " + Arrays.toString(huwelijkdsDatum.getMaandNamen()) + " "
                + huwelijkdsDatum.getJaar());
    }

    public Persoon getPersoon01() {
        return persoon01;
    }

    public void setPersoon01(Persoon persoon01) {
        this.persoon01 = persoon01;
    }

    public Persoon getPersoon02() {
        return persoon02;
    }

    public void setPersoon02(Persoon persoon02) {
        this.persoon02 = persoon02;
    }

    public Datum getHuwelijkdsDatum() {
        return huwelijkdsDatum;
    }

    public void setHuwelijkdsDatum(Datum huwelijkdsDatum) {
        this.huwelijkdsDatum = huwelijkdsDatum;
    }
}
