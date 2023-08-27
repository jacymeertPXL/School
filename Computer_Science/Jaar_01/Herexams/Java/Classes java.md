````java
public class ExampleClass {
    private String stringValue;
    private int intValue;
    private boolean booleanValue;
    private int[] intArray;

    public ExampleClass(String stringValue, int intValue, boolean booleanValue, int[] intArray) {
        this.stringValue = stringValue;
        this.intValue = intValue;
        this.booleanValue = booleanValue;
        this.intArray = intArray;
    }
    
    // Setters
    public void setStringValue(String stringValue) {
        this.stringValue = stringValue;
    }

    public void setIntValue(int intValue) {
        this.intValue = intValue;
    }

    public void setBooleanValue(boolean booleanValue) {
        this.booleanValue = booleanValue;
    }

    public void setIntArray(int[] intArray) {
        this.intArray = intArray;
    }

    // Getters
    public String getStringValue() {
        return stringValue;
    }

    public int getIntValue() {
        return intValue;
    }

    public boolean getBooleanValue() {
        return booleanValue;
    }

    public int[] getIntArray() {
        return intArray;
    }
    
    // controleren als het een string is
    private String validateString(String value) {
        if (value == null || value.trim().isEmpty()) {
            throw new IllegalArgumentException("Ongeldige stringwaarde.");
        }
        return value;
    }
    
    // controleren als het een int is
    private int validateInt(int value) {
        if (value < 0) {
            throw new IllegalArgumentException("Ongeldige int-waarde.");
        }
        return value;
    }
    
    // controleren als het een boolean is
     private boolean validateBoolean(boolean value) {
        if (value != true && value != false) {
            throw new IllegalArgumentException("Ongeldige boolean-waarde.");
        }
        return value;
    }

    // String naar int converteren
    public int convertStringToInt(String str) {
        try {
            return Integer.parseInt(str);
        } catch (NumberFormatException e) {
            return -1; // Onjuiste invoer
        }
    }

    // Int naar string converteren
    public String convertIntToString(int value) {
        return Integer.toString(value);
    }

    // toString-methode om objectinformatie terug te geven als een string
    @Override
    public String toString() {
        return "stringValue: " + stringValue +
               ", intValue: " + intValue +
               ", booleanValue: " + booleanValue +
               ", intArray: " + java.util.Arrays.toString(intArray);
    }

    public static void main(String[] args) {
        int[] numbers = {1, 2, 3};
        ExampleClass example = new ExampleClass("Hello", 42, true, numbers);

        System.out.println("Conversie van string naar int: " + example.convertStringToInt("123"));
        System.out.println("Conversie van int naar string: " + example.convertIntToString(456));

        System.out.println("Objectinformatie: " + example.toString());
    }
}
`````

**Abstracte klasse in Java:** 
Een abstracte klasse is een klasse die niet direct kan worden geïnstantieerd (je kunt er geen objecten van maken), maar het kan worden uitgebreid door andere klassen. Het wordt vaak gebruikt als een basis voor andere klassen om gemeenschappelijke eigenschappen en methoden te definiëren. Een abstracte klasse kan zowel concrete methoden (met implementatie) als abstracte methoden (zonder implementatie) bevatten.

````java
abstract class Shape {
    abstract double area(); // Abstracte methode zonder implementatie
}

class Circle extends Shape {
    double radius;

    public Circle(double radius) {
        this.radius = radius;
    }

    @Override
    double area() {
        return Math.PI * radius * radius;
    }
}

public class Main {
    public static void main(String[] args) {
        Circle circle = new Circle(5.0);
        System.out.println("Cirkelgebied: " + circle.area());
    }
}
`````

````java
abstract class AbstractShape {
    abstract double calculateArea(double data, double data2);
}

class Rectangle extends AbstractShape {
    double length;
    double width;

    public Rectangle(double length, double width) {
        this.length = length;
        this.width = width;
    }

    @Override
    double calculateArea(double data, double data2) {
        return length * width;
    }
}

public class Main {
    public static void main(String[] args) {
        Rectangle rectangle = new Rectangle(5.0, 3.0);
        double area = rectangle.calculateArea(rectangle.length, rectangle.width);
        System.out.println("Het gebied van het rechthoek: " + area);
    }
}
`````

#java