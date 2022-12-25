package be.pxl.h2.oefening_02;

import java.util.Scanner;

public class Bankrekening {
    private String rekeningsnummer;

    private String naam;

    private double saldo;

    private double renpercentage;

    public Bankrekening(String rekeningsnummer, String naam, double saldo, double renpercentage){
        this.rekeningsnummer = rekeningsnummer;
        this.naam = naam;
        this.saldo = saldo;
        this.renpercentage = renpercentage;
        this.controle();
    }

    public Bankrekening() {
        this("geen", "onbekend", 0, 1.2);
    }

    public void controle(){
        if (this.saldo < 0){
            this.saldo = 0;
        }
        if (this.renpercentage < 0){
            this.renpercentage = 0;
        }
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public void setRekeningsnummer(String rekeningsnummer) {
        this.rekeningsnummer = rekeningsnummer;
    }

    public double getSaldo() {
        return this.saldo;
    }

    public String print(){
        return " Saldo op spaarrekeing" + this.rekeningsnummer + " op naam van " + this.naam + " bedraagt " + this.saldo + " euro.";
    }

    public boolean controleRekening(){
        Scanner scanner = new Scanner(System.in);

        if (this.rekeningsnummer.equals("geen")) {
            System.out.println("sorry, geen rekeningnummer");
            return false;
        } else {
            if (this.naam.equals("onbekend")) {
                System.out.println("Voer uw naam in:");
                this.setNaam(scanner.nextLine());
            }
            return true;
        }
    }

    public String berichtOpname() {
        if (this.saldo == 0) {
            return "u kan geen geld opnemen";
        } else {
            return "u mag enkel " + this.saldo + " euro opnemen";
        }
    }

    public void stort(double storting) {
        if (this.controleRekening()) {
            this.saldo = this.saldo + storting;
            System.out.println("na storting van " + storting + " euro");
            System.out.println(this.print());
        }
    }

    public void neemOp(double opnemen) {
        if (this.controleRekening()) {
            if (opnemen > this.saldo) {
                this.berichtOpname();
                opnemen = this.saldo;
                this.saldo = 0;
            } else {
                this.saldo = this.saldo - opnemen;
            }
            System.out.println("na opname van " + opnemen + " euro");
            System.out.println(this.print());
        }
    }

    public void verichting(double... verichtingen){
        if (this.controleRekening()){
            for (double v : verichtingen) {
                if (v < 0) {
                    this.neemOp(v);
                } else {
                    this.stort(v);
                }
            }
        }
    }

    public void schrijfRenteBij() {
        if (this.controleRekening()) {
            double toevoegenRente = (this.saldo * this.renpercentage);
            this.saldo = this.saldo + toevoegenRente;

            System.out.println("rente wordt bijgeschreven voor " + toevoegenRente + " euro");
            System.out.println(this.print());
        }
    }




}
