package be.pxl.h5.exoef1;

public class GeboekteReis {

    private String naam;
    private Reis[] reizen;

    public GeboekteReis(String naam, int aantal) {
        this.naam = naam;
        this.reizen = new Reis[aantal];
    }

    public void voegReisToe(Reis reis) {
        for(int i=0;i<reizen.length;i++) {
            if (reizen[i] == null) {
                reizen[i] = reis;
                return;
            }
        }
        System.out.println("Reis kan niet toegevoegd worden...");
    }

    public void print() {
        for(Reis reis:reizen) {
            if(reis != null) {
                System.out.println(reis);
            }
        }
    }
}
