````python
# Aantal plaatsen om te verschuiven
shift = 2

# Een array van woorden
word_array = ["wortel", "patat", "jacy", "wang"]

# Invoer van de gebruiker
user_word = input("Voer een woord in om te versleutelen en te decoderen: ")
encrypted_word = ''
decrypted_word = ''

# Encryptie en decryptie van het ingevoerde woord
for letter in user_word:
    encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
    encrypted_word += encrypted_letter

for letter in encrypted_word:
    decrypted_letter = chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
    decrypted_word += decrypted_letter

# Piramide weergave
def pyramid_display(text):
    for i in range(1, len(text) + 1):
        print(text[:i])

def reversed_pyramid_display(text):
    for i in range(len(text), 0, -1):
        print(text[:i])

print("Versleuteld:")
pyramid_display(encrypted_word)
reversed_pyramid_display(encrypted_word)

print("\nOpgelost:")
pyramid_display(decrypted_word)
reversed_pyramid_display(decrypted_word)

`````

![[Pasted image 20230820004042.png]]

 ````python
 # Aantal plaatsen om te verschuiven
shift = 2

# Invoer van de gebruiker
user_word = input("Voer een woord in om te versleutelen en te decoderen: ")
encrypted_word = ''
decrypted_word = ''

# Encryptie en decryptie van het ingevoerde woord
for letter in user_word:
    encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
    encrypted_word += encrypted_letter

for letter in encrypted_word:
    decrypted_letter = chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
    decrypted_word += decrypted_letter

# Piramide weergave
def pyramid_display(text):
    for i in range(len(text), 0, -1):
        print(text[:i])

print("Versleutelde piramide:")
pyramid_display(encrypted_word)

print("\nOntcijferde piramide:")
pyramid_display(decrypted_word)

`````

![[Pasted image 20230820004124.png]]

````python
# Aantal plaatsen om te verschuiven
shift = 2

# Invoer van de gebruiker
user_word = input("Voer een woord in om te versleutelen en te decoderen: ")
encrypted_word = ''
decrypted_word = ''

# Encryptie en decryptie van het ingevoerde woord
for letter in user_word:
    encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
    encrypted_word += encrypted_letter

for letter in encrypted_word:
    decrypted_letter = chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
    decrypted_word += decrypted_letter

# Piramide weergave
def reverse_custom_pyramid_display(text):
    for i in range(len(text), 0, -1):
        spaces = ' ' * (len(text) - i)
        print(spaces + text[:i])

print("Versleutelde piramide:")
reverse_custom_pyramid_display(encrypted_word)

print("\nOntcijferde piramide:")
reverse_custom_pyramid_display(decrypted_word)

`````

![[Pasted image 20230820005505.png]]


