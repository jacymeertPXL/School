package be.pxl.h4.oefening_03;

public class Vak {
    private String code;

    private String naam;
    private int aantalSTP;

    public Vak(String code, String naam, int stp) {
        setCode(code);
        this.naam = naam;
        setAantalSTP(stp);
    }

    public String getJaar() {
        return code.substring(1, 2);
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        String jaar = code.substring(1, 2);
        if (jaar.compareTo("1") < 0 || jaar.compareTo("3") > 0) {
            jaar = "1";
            this.code = code.charAt(0) + jaar + code.substring(2);
        } else {
            this.code = code;
        }
    }

    public int getAantalSTP() {
        return aantalSTP;
    }

    public void setAantalSTP(int stp) {
        if (stp > 18) {
            aantalSTP = 18;
        } else {
            int rest = stp % 3;
            switch (rest) {
                case 0:
                    aantalSTP = stp;
                    break;
                case 1:
                    aantalSTP = stp - 1;
                    break;
                case 2:
                    aantalSTP = stp + 1;
                    break;
            }
        }
    }
}
