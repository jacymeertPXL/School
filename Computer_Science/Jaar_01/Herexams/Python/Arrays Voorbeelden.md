
### 1-dimensionale array (lijst) bewerkingen:

````python
my_list = [1, 2, 3]
my_list.append(4) #Toevoegen
print(my_list)  # Output: [1, 2, 3, 4]

#vervangen
my_list[1] = 5
print(my_list)  # Output: [1, 5, 3, 4]

my_list.remove(3)  # Verwijdert het element met waarde 3
del my_list[0]     # Verwijdert het eerste element
print(my_list)     # Output: [5, 4]

# Omgekeerd, van lijst van strings naar lijst van integers:
string_list = ["1", "2", "3"]
int_list = [int(x) for x in string_list]
print(int_list)  # Output: [1, 2, 3]

# Omgekeerd, van lijst van integers naar lijst van strings:
int_list = [1, 2, 3]
string_list = [str(x) for x in int_list]
print(string_list)  # Output: ["1", "2", "3"]

`````

### 1-dimensionale array (lijst) bewerkingen:
	Voor 2-dimensionale arrays gebruik ik hier de populaire `numpy` library

````python
import numpy as np

# Een 2-dimensionale numpy array aanmaken
my_2d_array = np.array([[1, 2, 3], [4, 5, 6]])

# Toevoegen van een rij aan het einde van de array
new_row = np.array([7, 8, 9])
my_2d_array = np.vstack((my_2d_array, new_row))

# Vervangen van een element
my_2d_array[1, 1] = 10

# Verwijderen van een rij
my_2d_array = np.delete(my_2d_array, 1, axis=0)

# Converten van string naar int en omgekeerd
string_array = np.array([["1", "2", "3"], ["4", "5", "6"]])
int_array = string_array.astype(int)

# Omgekeerd, van int naar string
int_array = np.array([[1, 2, 3], [4, 5, 6]])
string_array = int_array.astype(str)

	`````