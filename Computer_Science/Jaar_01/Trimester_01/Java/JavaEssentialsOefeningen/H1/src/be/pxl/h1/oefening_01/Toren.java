package be.pxl.h1.oefening_01;

public class Toren {
    private String naam;
    private String locatie;
    private int voltooid;
    private int HoogteZonderAntenne;
    private int Verdieping;


    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getLocatie() {
        return locatie;
    }

    public void setLocatie(String locatie) {
        this.locatie = locatie;
    }

    public int getVoltooid() {
        return voltooid;
    }

    public void setVoltooid(int voltooid) {
        this.voltooid = voltooid;
    }

    public int getHoogteZonderAntenne() {
        return HoogteZonderAntenne;
    }

    public void setHoogteZonderAntenne(int hoogteZonderAntenne) {
        HoogteZonderAntenne = hoogteZonderAntenne;
    }

    public int getVerdieping() {
        return Verdieping;
    }

    public void setVerdieping(int verdieping) {
        Verdieping = verdieping;
    }

    public String weergeven(){
        return naam + " " + locatie + " " + voltooid + " " + HoogteZonderAntenne + " " + Verdieping;
    }
}
