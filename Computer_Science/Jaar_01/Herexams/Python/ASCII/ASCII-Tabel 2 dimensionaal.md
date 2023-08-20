
````python
import numpy as np

# Het woord dat we willen encrypteren en decrypteren
word = "wortel"

# Aantal plaatsen om te verschuiven
shift = 2

# Een array van woorden
word_array = ["wortel", "patat", "jacy"]

# 2-dimensionale array (numpy array) voor de woorden
word_matrix = np.array([list(word) for word in word_array])

# Encryptie van 2D-array voor "wortel" alleen
for i in range(word_matrix.shape[0]):
    current_word = ''.join(word_matrix[i])
    if current_word == word:
        encrypted_word = ''
        for letter in word:
            encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
            encrypted_word += encrypted_letter
        word_matrix[i] = list(encrypted_word)

print("Encrypted 2D array:")
print(word_matrix)

# Decryptie van 2D-array voor "wortel" alleen
for i in range(word_matrix.shape[0]):
    current_word = ''.join(word_matrix[i])
    if current_word == word:
        decrypted_word = ''
        for letter in word:
            decrypted_letter = chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
            decrypted_word += decrypted_letter
        word_matrix[i] = list(decrypted_word)

print("Decrypted 2D array:")
print(word_matrix)

`````

In dit voorbeeld wordt het woord "wortel" in een 2D-array van woorden gezocht en alleen dat specifieke woord wordt versleuteld en ontcijferd. Andere woorden in de array blijven ongewijzigd. Dit is een wat complexere aanpak omdat we moeten controleren welk woord we moeten versleutelen en ontcijferen binnen de array, maar het idee blijft hetzelfde als in eerdere voorbeelden.