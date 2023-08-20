package be.pxl.h1.oefening_05;

public class spaceship {
    private String naam;
    private int hits;
    private boolean shieldOn;

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public int getHits() {
        return hits;
    }

    public void setHits(int hits) {
        this.hits = hits;
    }

    public boolean isShieldOn() {
        return shieldOn;
    }

    public void setShieldOn(boolean shieldOn) {
        this.shieldOn = shieldOn;
    }

    public boolean setShieldOn() {
        shieldOn = !shieldOn;
        return shieldOn;
    }

    public void fire(){
        if (shieldOn == true){
            System.out.println("Het shield staat aan");
        }else{
            hits++;
        }
    }
}
