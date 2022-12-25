package be.pxl.h1.Opdracht_Curses.Opdracht_12;

import java.util.Scanner;

public class ThermometerApp {
    public static void main(String[] args) {

        Thermomter thermometer = new Thermomter();

        Scanner scanner = new Scanner(System.in);
        System.out.println("geef temp in graden celcius in");

        double celcius = scanner.nextDouble();
        thermometer.setTemperatuur(celcius);

        System.out.println("dit is " + thermometer.getFahrenheit() + " fahrenheit");
        System.out.printf("|%10s|%10s|%n", "Celsius", "Fahrenheit");

        for (double c = -10; c <= 25; c += 0.5){
            System.out.printf("|%10.2f|%-10.2f|%n", c , thermometer.getFahrenheit());
        }
    }
}
