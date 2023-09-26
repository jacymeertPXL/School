package be.pxl.h1.Opdracht_Curses.Opdracht_12;

public class Thermomter {
    private double temperatuur;

    public double getTemperatuur() {
        return temperatuur;
    }

    public Object setTemperatuur(double temperatuur) {
        this.temperatuur = temperatuur;
        return null;
    }

    public double getFahrenheit(){
        double f = 9.0 / 5 * temperatuur + 32;
        return f;
    }
}