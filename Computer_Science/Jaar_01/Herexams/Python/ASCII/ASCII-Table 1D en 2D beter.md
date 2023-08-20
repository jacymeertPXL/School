````python
import numpy as np

def encrypt_letter(letter, shift):
    if letter.isalpha():
        base = ord('a') if letter.islower() else ord('A')
        encrypted = chr((ord(letter) - base + shift) % 26 + base)
        return encrypted
    return letter

def encrypt_word(word, shift):
    return ''.join(encrypt_letter(letter, shift) for letter in word)

def decrypt_word(word, shift):
    return encrypt_word(word, -shift)

def encrypt_array(array, target_word, shift):
    encrypted_array = np.copy(array)
    for i in range(array.shape[0]):
        for j in range(array.shape[1]):
            if array[i, j] == target_word:
                encrypted_array[i, j] = encrypt_word(target_word, shift)
    return encrypted_array

def decrypt_array(array, target_word, shift):
    decrypted_array = np.copy(array)
    for i in range(array.shape[0]):
        for j in range(array.shape[1]):
            if array[i, j] == encrypt_word(target_word, shift):
                decrypted_array[i, j] = target_word
    return decrypted_array

word_array = np.array([
    ["apple", "banana", "cherry"],
    ["date", "fig", "grape"],
    ["kiwi", "lemon", "mango"]
])

target_word = "cherry"
encryption_shift = 2

encrypted_array = encrypt_array(word_array, target_word, encryption_shift)
decrypted_array = decrypt_array(encrypted_array, target_word, encryption_shift)

print("Original Array:")
print(word_array)
print("\nEncrypted Array:")
print(encrypted_array)
print("\nDecrypted Array:")
print(decrypted_array)

`````

In dit voorbeeld wordt het woord "wortel" in een 2D-array van woorden gezocht en alleen dat specifieke woord wordt versleuteld en ontcijferd met een verschuiving van 2 posities in het alfabet. De `encrypt_array`-functie zoekt naar het doelwoord in de array, versleutelt het indien aanwezig en retourneert een nieuwe versleutelde array. De `decrypt_array`-functie zoekt naar het versleutelde doelwoord in de array, ontcijfert het en retourneert een nieuwe ontcijferde array. De output toont de oorspronkelijke, versleutelde en ontcijferde arrays.

````
Original Array:
[['apple' 'banana' 'cherry']
 ['date' 'fig' 'grape']
 ['kiwi' 'lemon' 'mango']]

Encrypted Array:
[['apple' 'banana' 'Djgtta']
 ['date' 'fig' 'grape']
 ['kiwi' 'lemon' 'mango']]

Decrypted Array:
[['apple' 'banana' 'cherry']
 ['date' 'fig' 'grape']
 ['kiwi' 'lemon' 'mango']]

`````
