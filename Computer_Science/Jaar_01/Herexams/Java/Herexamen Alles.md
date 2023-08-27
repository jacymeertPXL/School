[[basics array java]]

**1. Creating an Array:**

````java
// Declare and initialize an array of integers 
int[] numbers = new int[5]; 
// Creates an array of size 5  // Initialize individual elements 
numbers[0] = 10; 
numbers[1] = 20; 
numbers[2] = 30; 
numbers[3] = 40; 
numbers[4] = 50;
`````

**2. Accessing Array Elements:**

````java
// Accessing elements using index 
int thirdNumber = numbers[2]; // Retrieves the element at index 2 (30)`
`````


**3. Updating Array Elements:**

````java
// Updating an element
numbers[1] = 25; // Changes the element at index 1 to 25
`````


**4. Adding Elements (Expanding Array):** In Java, arrays have a fixed size once created. If you want to add elements dynamically, you typically use other data structures like `ArrayList`. However, if you still want to expand an array, you need to create a new array and copy the elements from the old array to the new one.

````java
int newSize = numbers.length + 1; 
int[] newNumbers = new int[newSize];
for (int i = 0; i < numbers.length; i++) {
newNumbers[i] = numbers[i]; 
}  
newNumbers[newSize - 1] = 60; // Add a new element
numbers = newNumbers; // Update reference to the new array
`````


**5. Deleting Elements (Shrinking Array):** Similarly to adding elements, if you want to delete elements from an array, you'll need to create a new array and copy the desired elements.

````java
int elementToDelete = 30;
int newSize = numbers.length - 1;
int[] newNumbers = new int[newSize];
int newIndex = 0;
for (int i = 0; i < numbers.length; i++) {
   if (numbers[i] != elementToDelete) {
   newNumbers[newIndex] = numbers[i];         
   newIndex++;
  } 
}
numbers = newNumbers; // Update reference to the new array
`````

**1. Gebruiker geeft het element om te verwijderen:**
````java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int[] numbers = {10, 20, 30, 40, 50};

        Scanner scanner = new Scanner(System.in);
        System.out.print("Voer het element in dat je wilt verwijderen: ");
        int elementToDelete = scanner.nextInt();

        boolean found = false;
        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] == elementToDelete) {
                // Shift elements to the left to overwrite the element to be deleted
                for (int j = i; j < numbers.length - 1; j++) {
                    numbers[j] = numbers[j + 1];
                }
                found = true;
                break;
            }
        }

        if (found) {
            System.out.println("Element verwijderd.");
        } else {
            System.out.println("Element niet gevonden.");
        }

        // Rest van de code
    }
}
`````

**2. Gebruiker geeft index om te verwijderen:**
````java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int[] numbers = {10, 20, 30, 40, 50};

        Scanner scanner = new Scanner(System.in);
        System.out.print("Voer de index in van het element dat je wilt verwijderen: ");
        int indexToDelete = scanner.nextInt();

        if (indexToDelete >= 0 && indexToDelete < numbers.length) {
            // Shift elements to the left to overwrite the element to be deleted
            for (int i = indexToDelete; i < numbers.length - 1; i++) {
                numbers[i] = numbers[i + 1];
            }
            System.out.println("Element verwijderd.");
        } else {
            System.out.println("Ongeldige index.");
        }

        // Rest van de code
    }
}
`````

**1. Een 2D-array maken:**
````java
// Een 2D-array van integers declareren en initialiseren
int[][] matrix = new int[3][3]; // Maakt een 3x3 matrix

// Individuele elementen initialiseren
matrix[0][0] = 1;
matrix[0][1] = 2;
matrix[0][2] = 3;
matrix[1][0] = 4;
matrix[1][1] = 5;
matrix[1][2] = 6;
matrix[2][0] = 7;
matrix[2][1] = 8;
matrix[2][2] = 9;
`````

**2. Toegang tot elementen in een 2D-array:**
````java
// Elementen benaderen met rij- en kolomindices
int element = matrix[1][1]; // Haalt het element in rij 1 en kolom 1 op (5)
`````

**3. 2D-array elementen bijwerken:**
````java
// Een element bijwerken
matrix[0][1] = 10; // Verandert het element in rij 0 en kolom 1 naar 10
`````

**4. Elementen toevoegen (2D-array uitbreiden):**
````java
int newRows = matrix.length + 1;
int newCols = matrix[0].length + 1;
int[][] newMatrix = new int[newRows][newCols];

for (int i = 0; i < matrix.length; i++) {
    for (int j = 0; j < matrix[i].length; j++) {
        newMatrix[i][j] = matrix[i][j];
    }
}

newMatrix[newRows - 1][newCols - 1] = 11; // Voeg een nieuw element toe
matrix = newMatrix; // Update de referentie naar de nieuwe matrix
`````

**5. Elementen verwijderen (2D-array verkleinen):**
````java
int rowToDelete = 1;
int colToDelete = 1;
int newRows = matrix.length - 1;
int newCols = matrix[0].length - 1;
int[][] newMatrix = new int[newRows][newCols];
int newRow = 0;
int newCol;

for (int i = 0; i < matrix.length; i++) {
    if (i != rowToDelete) {
        newCol = 0;
        for (int j = 0; j < matrix[i].length; j++) {
            if (j != colToDelete) {
                newMatrix[newRow][newCol] = matrix[i][j];
                newCol++;
            }
        }
        newRow++;
    }
}

matrix = newMatrix; // Update de referentie naar de nieuwe matrix
`````

**1. Gebruiker geeft het element om te verwijderen:**
````java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int[][] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Scanner scanner = new Scanner(System.in);
        System.out.print("Voer het element in dat je wilt verwijderen: ");
        int elementToDelete = scanner.nextInt();

        boolean found = false;
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                if (matrix[i][j] == elementToDelete) {
                    matrix[i][j] = 0; // Je kunt het element markeren met een waarde of iets dergelijks
                    found = true;
                }
            }
        }

        if (found) {
            System.out.println("Element verwijderd.");
        } else {
            System.out.println("Element niet gevonden.");
        }

        // Rest van de code
    }
}
`````

**2. Gebruiker geeft rij- en kolomindices om te verwijderen:**
````java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int[][] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Scanner scanner = new Scanner(System.in);
        System.out.print("Voer de rij-index in: ");
        int rowToDelete = scanner.nextInt();
        System.out.print("Voer de kolom-index in: ");
        int colToDelete = scanner.nextInt();

        if (rowToDelete >= 0 && rowToDelete < matrix.length && colToDelete >= 0 && colToDelete < matrix[0].length) {
            matrix[rowToDelete][colToDelete] = 0; // Verwijder het element door het te markeren
            System.out.println("Element verwijderd.");
        } else {
            System.out.println("Ongeldige rij- of kolomindex.");
        }

        // Rest van de code
    }
}
`````

[[Iteraties Baics java]]

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

[[Classes java]]
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
        retu

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

[[Interface en abstract classes]]
**1. Let’s create an Interface at first:**
````java
// creating an interface named GFG
interface GFG {
	void learnCoding();
	void learnProgrammingLanguage();
	void contribute();
}
`````
Here the three  non-implemented methods are the abstract methods

**2. Now let’s implement the interface in an Abstract class named Student:**
````java
// creating an abstract class named Student which is
// implementing the interface,GFG
abstract class Student implements GFG {

	// Overriding two methods of the interfacem,GFG
	@Override public void learnCoding()
	{
		System.out.println(
			"Let's make coding a habit with GFG");
	}
	@Override public void learnProgrammingLanguage()
	{
		System.out.println(
			"Let's master all fundamentals of java with the help of GFG");
	}
}
`````
Here we have overridden two abstract methods of the interface  GFG.

**3. Now let’s create a class GEEK which extends the abstract class, Student:**

As previously mentioned, we can’t create an instance of our abstract class therefore we need to make a non-abstract class.
````java
// creating an non-abstract class
// GEEK which is extending Student
class GEEK extends Student {

	// overriding the remaining method of the interface,GFG
	@Override public void contribute()
	{
		System.out.println(
			"Now let's help others by contributing in GFG");
	}
}
`````

Here we have overridden the remaining method of the interface GFG.

Below is the overall implementation of the problem statement:

````java
// Implementation of Interface using Abstract Class in Java

// Interface GFG
interface GFG {
	void learnCoding();
	void learnProgrammingLanguage();
	void contribute();
}

// Abstract class Student implementing from GFG interface
abstract class Student implements GFG {

	// Overriding the methods
	@Override public void learnCoding()
	{
		System.out.println(
			"Let's make coding a habit with GFG");
	}
	@Override public void learnProgrammingLanguage()
	{
		System.out.println(
			"Let's master all fundamentals of java with the help of GFG");
	}
}

// Extend the GEEK class by Student abstract class
class GEEK extends Student {
	@Override public void contribute()
	{
		System.out.println(
			"Now let's help others by contributing in GFG");
	}
}

// Driver code
public class Main {
	public static void main(String[] args)
	{
		// New GEEK object is created
		GEEK gfgStudent = new GEEK();

		// Calls to the multiple functions
		gfgStudent.learnCoding();
		gfgStudent.learnProgrammingLanguage();
		gfgStudent.contribute();
	}
}
`````

**Output:**

	Let's make coding a habit with GFG
	Let's master all fundamentals of java with the help of GFG
	Now let's help others by contributing in GFG

#java