package be.pxl.h5.exoef1;

public class TreinReis extends Reis {

    private boolean nationaal;
    private String specificatie;

    private String[] specificaties = {"IC", "IR", "L", "P"};

    public TreinReis(String bestemming) {
        this(bestemming, Reis.MINIMUM_PRIJS, true, "IC");
    }

    public TreinReis(String bestemming, double prijs, boolean nationaal, String specificatie) {
        super(bestemming, prijs);
        this.nationaal = nationaal;
        this.setSpecificatie(specificatie);
    }

    public String getSpecificatie() {
        return specificatie;
    }

    public void setSpecificatie(String specificatie) {
        this.specificatie = "IC";
        for(String spec : specificaties) {
            if(spec.equals(specificatie)) {
                this.specificatie = spec;
            }
        }
    }

    public String toString() {
        StringBuilder builder = new StringBuilder();
        builder.append(super.toString());
        builder.append(System.lineSeparator());
        if(nationaal) {
            builder.append(String.format("Nationale treinreis (%s)", specificatie));
        } else {
            builder.append("Internationale treinreis");
        }
        return builder.toString();
    }
}
