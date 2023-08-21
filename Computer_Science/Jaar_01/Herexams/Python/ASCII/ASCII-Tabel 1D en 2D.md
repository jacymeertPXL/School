````python
# Het woord dat we willen encrypteren en decrypteren
word = "wortel"

# Aantal plaatsen om te verschuiven
shift = 2

# 1-dimensionale array (lijst)
word_list = list(word)
encrypted_word_list = []

# Encryptie van 1D-array
for letter in word_list:
    # Verschuiven van de letter met de gegeven shift
    encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
    encrypted_word_list.append(encrypted_letter)

encrypted_word_1d = ''.join(encrypted_word_list)

# Decryptie van 1D-array
decrypted_word_list = []
for letter in encrypted_word_1d:
    decrypted_letter = chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
    decrypted_word_list.append(decrypted_letter)

decrypted_word_1d = ''.join(decrypted_word_list)

print("1D encrypted:", encrypted_word_1d)
print("1D decrypted:", decrypted_word_1d)

# 2-dimensionale array (numpy array)
word_matrix = np.array([[word[i+j] for j in range(3)] for i in range(0, len(word), 3)])
encrypted_matrix = np.empty_like(word_matrix, dtype='str')

# Encryptie van 2D-array
for i in range(word_matrix.shape[0]):
    for j in range(word_matrix.shape[1]):
        letter = word_matrix[i, j]
        encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
        encrypted_matrix[i, j] = encrypted_letter

encrypted_word_2d = ''.join(encrypted_matrix.flatten())

# Decryptie van 2D-array
decrypted_matrix = np.empty_like(encrypted_matrix, dtype='str')
for i in range(encrypted_matrix.shape[0]):
    for j in range(encrypted_matrix.shape[1]):
        letter = encrypted_matrix[i, j]
        decrypted_letter = chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
        decrypted_matrix[i, j] = decrypted_letter

decrypted_word_2d = ''.join(decrypted_matrix.flatten())

print("2D encrypted:", encrypted_word_2d)
print("2D decrypted:", decrypted_word_2d)

`````

`word_matrix = np.array([[word[i+j] for j in range(3)] for i in range(0, len(word), 3)])` in meer detail uitleggen.

Deze code wordt gebruikt om het woord in een 2-dimensionale array te verdelen (matrix) waarbij elke rij 3 letters bevat (tenzij er minder dan 3 letters over zijn aan het einde). Hier is een gedetailleerde uitleg:

1. `range(0, len(word), 3)` - Dit is een reeks getallen die begint bij 0 en gaat tot de lengte van het woord, met stappen van 3. Dit zorgt ervoor dat we starten bij elke 3e letter van het woord.
    
2. `for i in range(0, len(word), 3)` - Dit is een for-lus die door de reeks getallen loopt die we hierboven hebben gedefinieerd. Bij elke iteratie neemt `i` de waarde van het huidige getal in de reeks.
    
3. `for j in range(3)` - Dit is een geneste for-lus die door de reeks van 0 tot 2 loopt. Dit zorgt ervoor dat we elke keer drie letters in een rij plaatsen.
    
4. `word[i+j]` - Dit haalt de letter op uit het woord op de positie `i+j`. Omdat we eerst bij de 3e letter beginnen (vanwege `i`), halen we de letters op de positie `i`, `i+1` en `i+2` op. Dit zijn de letters voor één rij in de 2D-array.
    
5. De buitenste vierkante haken `[[...]]` creëren een lijst van lijsten, wat de structuur is van een 2D-array of matrix.
    
6. `np.array(...)` - Hier gebruiken we de functie `np.array()` van de numpy library om de gemaakte lijst van lijsten om te zetten in een numpy array.
    

Kortom, deze enkele regel code verdeelt het woord in een 2D-array waarbij elke rij maximaal 3 letters bevat. Het gebruikt `i` om de startpositie van elke rij te bepalen en `j` om de posities van de letters binnen elke rij te bepalen. Dit is handig om later de encryptie en decryptie op een matrix van letters toe te passen.

#Python