package be.pxl.h5.exoef1;

public class ReisApp {

    public static void main(String[] args) {
        TreinReis t1 = new TreinReis("Brussel");
        VliegtuigReis v1 = new VliegtuigReis("Frankfurt", 70, "G4564");
        VliegtuigReis v2 = new VliegtuigReis("Peking", 200, "P-N11X");
        TreinReis t2 = new TreinReis("Diepenbeek");

        GeboekteReis reis = new GeboekteReis("Sam Vanderstraeten", 3);

        reis.voegReisToe(t1);
        reis.voegReisToe(v1);
        reis.voegReisToe(v2);
        reis.voegReisToe(t2);

        reis.print();
    }
}
