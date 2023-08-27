
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

#java