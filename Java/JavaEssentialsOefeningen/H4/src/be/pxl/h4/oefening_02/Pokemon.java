package be.pxl.h4.oefening_02;

public class Pokemon {
    private String naam;
    private String type;

    Pokemon(String naam, String type){
        this.naam = naam;
        this.type = type;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    @Override
    public String toString() {
        return String.format(naam + "(" + type + ")");
    }
}
