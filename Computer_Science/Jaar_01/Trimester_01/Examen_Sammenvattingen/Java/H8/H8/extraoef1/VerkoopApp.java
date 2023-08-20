package be.pxl.h9.oef2;

import java.time.LocalDate; 

public class VerkoopApp {

    public static void main(String[] args) {
        TeVerkopenBouwGrond bouw = new TeVerkopenBouwGrond("12ER", 12.4, "Open Bebouwing");
        bouw.doeEenBod(10000, LocalDate.of(2021, 12, 7));  //nog geen notaris ==> bod wordt niet geregistreerd
        bouw.wijsEenNotarisToe("Dirk Peeters", LocalDate.of(2021, 12, 7));
        bouw.doeEenBod(100000, LocalDate.of(2021, 12, 10));  // bod te vroeg
        bouw.doeEenBod(150000, LocalDate.of(2021, 12, 23));
        bouw.doeEenBod(120000, LocalDate.of(2021, 12, 27)); // bod is lager ==> bod wordt niet geregistreerd
        bouw.doeEenBod(175000, LocalDate.of(2022, 1, 4));
        System.out.println("Het hoogste bod is " + bouw.getHoogsteBod());
        System.out.println("De notaris is " + bouw.getNotaris());
        bouw.wijsEenNotarisToe("Ken Jans", LocalDate.now());

    }

}
