package be.pxl.h9.oef2;

import java.time.LocalDate;

public interface Verkoopbaar {
    // constante 
    public static final int MINPRIJSM2 = 83;

    // methoden
    public abstract void wijsEenNotarisToe(String naam, LocalDate datumTeKoop);
    void doeEenBod(double bod, LocalDate datumBod);

}
