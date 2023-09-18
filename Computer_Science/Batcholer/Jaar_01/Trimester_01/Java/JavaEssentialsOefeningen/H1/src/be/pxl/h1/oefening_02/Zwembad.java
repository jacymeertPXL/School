package be.pxl.h1.oefening_02;

public class Zwembad {
    private double breedte;
    private double lengte;
    private double diepte;

    public double getBreedte() {
        return breedte;
    }

    public void setBreedte(double breedte) {
        this.breedte = breedte;
    }

    public double getLengte() {
        return lengte;
    }

    public void setLengte(double lengte) {
        this.lengte = lengte;
    }

    public double getDiepte() {
        return diepte;
    }

    public void setDiepte(double diepte) {
        this.diepte = diepte;
    }

    public double getVolume(){
        return breedte * lengte * diepte * 1000;
    }

    public double getVolumeWater(){
        return (getVolume() * 0.98);
    }

    public double getVolumeOnstmettingsmiddel(){
        return (getVolume() * 0.02);
    }
}
