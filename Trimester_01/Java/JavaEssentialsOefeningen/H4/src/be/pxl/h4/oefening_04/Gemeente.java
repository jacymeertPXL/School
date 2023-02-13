package be.pxl.h4.oefening_04;

public class Gemeente {
    private int postcode;
    private String gemeenteNaam;

    public Gemeente(){

    }

    public Gemeente(int postcode, String gemeenteNaam){
        this.setPostcode(postcode);
        this.setGemeenteNaam(gemeenteNaam);
    }

    public int getPostcode() {
        return postcode;
    }

    public void setPostcode(int postcode) {
        this.postcode = postcode;
        postcodeControle();
    }

    public String getGemeenteNaam() {
        return gemeenteNaam;
    }

    public void setGemeenteNaam(String gemeenteNaam) {
        this.gemeenteNaam = gemeenteNaam;
        gemeenteNaamControle();
    }

    public void postcodeControle(){
        String postcode = Integer.toString(this.postcode);
        postcode = postcode.concat("0000");
        postcode = postcode.substring(0,4);
        this.postcode = Integer.parseInt(postcode);
    }

    public void gemeenteNaamControle(){
        String tekst = this.gemeenteNaam;
        String nieuwTekst = "";
        int count = 0;
        for (int begin = 0; begin < tekst.length(); begin++) {
            String temp = tekst.substring(begin, begin + 1);

            for (int guess = 0; guess < 9; guess++) {
                if (temp.equals(Integer.toString(guess))) {
                    count++;
                }
            }

            if (count == 0) {
                if (begin == 0) {
                    temp = temp.toUpperCase();
                } else {
                    if ((!tekst.substring(begin - 1, begin).equals("-")
                            && !tekst.substring(begin - 1, begin).equals(" "))) {
                        temp = temp.toLowerCase();
                    }

                }
                nieuwTekst = nieuwTekst.concat(temp);
            }
            count = 0;

        }
        this.gemeenteNaam = nieuwTekst;
    }

    public String toString() {
        return this.postcode + " " + this.gemeenteNaam;
    }
}
