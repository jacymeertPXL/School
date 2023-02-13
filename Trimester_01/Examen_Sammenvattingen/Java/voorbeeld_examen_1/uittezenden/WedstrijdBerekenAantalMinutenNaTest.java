package be.pxl.opgave;

import org.junit.Before;
import org.junit.Test;

import java.time.LocalDateTime;

import static org.junit.Assert.assertEquals;

public class WedstrijdBerekenAantalMinutenNaTest {

    private static final LocalDateTime WEDSTRIJDDATUM = LocalDateTime.of(2019, 8, 18, 20, 15);

    private Wedstrijd wedstrijd;

    @Before
    public void setUp() {
        wedstrijd = new Wedstrijd(null, null, null, WEDSTRIJDDATUM.getDayOfMonth(), WEDSTRIJDDATUM.getMonthValue(), WEDSTRIJDDATUM.getYear(), WEDSTRIJDDATUM.getHour(), WEDSTRIJDDATUM.getMinute());
    }

    @Test
    public void geeftPositiefAantalMinutenIndienTijdstipNaDeWedstrijd() {
        assertEquals(wedstrijd.berekenAantalMinutenNa(WEDSTRIJDDATUM.plusHours(1)), 60);
    }

    @Test
    public void geeftNegatiefAantalMinutenIndienTijdstipVoorDeWedstrijd() {
        assertEquals(wedstrijd.berekenAantalMinutenNa(WEDSTRIJDDATUM.minusHours(1)), -60);
    }

    @Test
    public void geeft0IndienZelfdeTijdstipAlsWedstrijddatum() {
        assertEquals(wedstrijd.berekenAantalMinutenNa(WEDSTRIJDDATUM), 0);
    }
}
