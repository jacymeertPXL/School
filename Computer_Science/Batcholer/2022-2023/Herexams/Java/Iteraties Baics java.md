**1. `while`-lus:**
````java
int i = 0;
while (i < 5) {
    System.out.println(i);
    i++;
}
`````

````java
int i = 0;
while (i < 5) {
    System.out.println("Iteratie " + i);
    i++;
}
`````

````java
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        ArrayList<String> names = new ArrayList<>();
        names.add("Alice");
        names.add("Bob");
        names.add("Charlie");

        int i = 0;
        while (i < names.size()) {
            System.out.println(names.get(i));
            i++;
        }
    }
}
`````

**2. `for`-lus:**
````java
for (int i = 0; i < 5; i++) {
    System.out.println(i);
}
`````

````java
for (int i = 0; i < 5; i++) {
    System.out.println("Iteratie " + i);
}
`````

````java
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        ArrayList<String> names = new ArrayList<>();
        names.add("Alice");
        names.add("Bob");
        names.add("Charlie");

        for (int i = 0; i < names.size(); i++) {
            System.out.println(names.get(i));
        }
    }
}
`````

**3. `if`- en `else`-statements:**
````java
int x = 10;
if (x > 5) {
    System.out.println("x is groter dan 5");
} else {
    System.out.println("x is niet groter dan 5");
}
`````

````java
String day = "woensdag";
if (day.equals("maandag")) {
    System.out.println("Het is maandag");
} else if (day.equals("dinsdag")) {
    System.out.println("Het is dinsdag");
} else if (day.equals("woensdag")) {
    System.out.println("Het is woensdag");
} else {
    System.out.println("Het is een andere dag");
}
`````

````java
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        ArrayList<String> fruits = new ArrayList<>();
        fruits.add("Apple");
        fruits.add("Banana");
        fruits.add("Orange");

        String fruitToFind = "Banana";
        if (fruits.contains(fruitToFind)) {
            System.out.println(fruitToFind + " is gevonden.");
        } else {
            System.out.println(fruitToFind + " is niet gevonden.");
        }
    }
}
`````

**4. `switch`-cases:**
````java
int day = 3;
switch (day) {
    case 1:
        System.out.println("Maandag");
        break;
    case 2:
        System.out.println("Dinsdag");
        break;
    case 3:
        System.out.println("Woensdag");
        break;
    default:
        System.out.println("Andere dag");
}
`````

````java
String day = "donderdag";
switch (day) {
    case "maandag":
        System.out.println("Het is maandag");
        break;
    case "dinsdag":
        System.out.println("Het is dinsdag");
        break;
    case "woensdag":
        System.out.println("Het is woensdag");
        break;
    default:
        System.out.println("Het is een andere dag");
}
`````

````java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        String[] daysOfWeek = {"Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag"};

        Scanner scanner = new Scanner(System.in);
        System.out.print("Voer een dag van de week in (1-7): ");
        int dayIndex = scanner.nextInt();

        if (dayIndex >= 1 && dayIndex <= 7) {
            String selectedDay = daysOfWeek[dayIndex - 1]; // Arrays zijn 0-geïndexeerd, dagen zijn 1-7
            switch (selectedDay) {
                case "Maandag":
                    System.out.println("Het is maandag");
                    break;
                case "Dinsdag":
                    System.out.println("Het is dinsdag");
                    break;
                case "Woensdag":
                    System.out.println("Het is woensdag");
                    break;
                case "Donderdag":
                    System.out.println("Het is donderdag");
                    break;
                case "Vrijdag":
                    System.out.println("Het is vrijdag");
                    break;
                case "Zaterdag":
                    System.out.println("Het is zaterdag");
                    break;
                case "Zondag":
                    System.out.println("Het is zondag");
                    break;
                default:
                    System.out.println("Ongeldige dag");
            }
        } else {
            System.out.println("Ongeldige invoer voor dagindex.");
        }
    }
}
`````

#java