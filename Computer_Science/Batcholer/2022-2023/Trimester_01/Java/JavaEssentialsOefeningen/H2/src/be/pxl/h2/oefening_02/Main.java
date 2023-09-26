package be.pxl.h2.oefening_02;

public class Main {
    public static void main(String[] args) {
        Bankrekening bankrekening = new Bankrekening();
        bankrekening.setNaam("jacy meert");
        bankrekening.stort(50); // test of die zegt dat er nog geen rekening nummer is
        bankrekening.setRekeningsnummer("100-156461-515");
        bankrekening.stort(50);
        bankrekening.stort(50);
        bankrekening.neemOp(10);
        bankrekening.schrijfRenteBij();

        Bankrekening bankrekening2 = new Bankrekening("000-01574125-77", "Jef Klaf", 100, 1.8);
        bankrekening.stort(bankrekening2.getSaldo());
        bankrekening2.neemOp(bankrekening2.getSaldo());

        Bankrekening bankrekening3 = new Bankrekening();
        bankrekening3.setRekeningsnummer("100-156461-515");
        bankrekening2.stort(bankrekening3.getSaldo());
        bankrekening3.neemOp(bankrekening3.getSaldo());
    }
}
