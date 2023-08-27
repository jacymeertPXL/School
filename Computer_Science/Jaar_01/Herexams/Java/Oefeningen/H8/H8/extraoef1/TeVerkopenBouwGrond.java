package be.pxl.h9.oef2;

import java.time.LocalDate; 
import java.time.format.TextStyle;
import java.time.temporal.ChronoUnit;
import java.util.Locale;

public class TeVerkopenBouwGrond extends Bouwgrond {
    private String notaris;
    private LocalDate datumTeKoop;
    private double hoogsteBod;
    private LocalDate datumHoogsteBod;

    public TeVerkopenBouwGrond(String perceelNr, double perceelGrootte, String bouwVoorschrift) {
        super(perceelNr, perceelGrootte);
        super.setBouwVoorschrift(bouwVoorschrift);
    }

    public void doeEenBod(double bod, LocalDate datumBod) {
        if (notaris == null) {
            System.out.println("Er is nog geen notaris toegewezen, bod kan niet uitgebracht worden");
        } else if (ChronoUnit.DAYS.between(datumTeKoop, datumBod) < 10) {
            System.out.println("Bod werd te vroeg gedaan");
        } else if (bod > hoogsteBod) {
            if (bod > MINPRIJSM2 * 100 * super.getPerceelGrootte()) {
                print(bod, datumBod);
                hoogsteBod = bod;
                datumHoogsteBod = datumBod;
            }
        } else {
            System.out.println("bod is lager dan ander bod en dus niet geregistreerd");
        }
    }

    public void wijsEenNotarisToe(String naam, LocalDate datum) {
        if (notaris == null) {
            notaris = naam;
            datumTeKoop = datum;
        } else
            System.out.println("er is reeds een notaris toegewezen");
    }

    public String getNotaris() {
        return notaris;
    }

    public double getHoogsteBod() {
        return hoogsteBod;
    }

    private void print(double bod, LocalDate datum) {
        StringBuilder nieuw = new StringBuilder();
        nieuw.append("Perceelnummer: " + super.getPerceelNummer() + "\n");
        nieuw.append(String.format("Perceelgrootte: %.2f are\n", super.getPerceelGrootte()));
        nieuw.append("Bouwvoorschrift: " + super.getBouwVoorschrift() + "\n");
        nieuw.append(String.format("Te koop gesteld op %s %2$td %2$tB %2$tY",
                datumTeKoop.getDayOfWeek().getDisplayName(TextStyle.FULL, Locale.getDefault()), datumTeKoop));
        nieuw.append(String.format(" bij notaris %s \n", notaris));
        if (hoogsteBod != 0) {
            nieuw.append(String.format("Vorig hoogste bod %,.0f geregistreerd op %2$td/%2$tm/%2$ty\n", hoogsteBod,
                    datumHoogsteBod));
        }
        nieuw.append(String.format("Nieuw hoogste bod %,.0f geregistreerd op %2$td/%2$tm/%2$ty\n", bod, datum));
        System.out.println(nieuw.toString());
    }

    public LocalDate getDatumTeKoop() {
        return datumTeKoop;
    }

    public LocalDate getDatumHoogsteBod() {
        return datumHoogsteBod;
    }

}
