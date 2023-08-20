user geeft een woord in en die wordt met de ascii table gerbuikt 

````python
# Aantal plaatsen om te verschuiven
shift = 2

# Een array van woorden
word_array = ["wortel", "patat", "jacy", "wang"]

# Invoer van de gebruiker
user_word = input("Voer een woord in om te versleutelen en te decoderen: ")

# Encryptie en decryptie van het ingevoerde woord
encrypted_word = ''
for letter in user_word:
    encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
    encrypted_word += encrypted_letter

decrypted_word = ''
for letter in encrypted_word:
    decrypted_letter = chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
    decrypted_word += decrypted_letter

print("Origineel woord:", user_word)
print("Versleuteld woord:", encrypted_word)
print("Opgelost woord:", decrypted_word)

`````

Met dit voorbeeld kan de gebruiker een willekeurig woord invoeren dat moet worden versleuteld en ontcijferd. Alleen het ingevoerde woord wordt verwerkt en het resultaat wordt weergegeven. Dit maakt het mogelijk om elk willekeurig woord in te voeren voor encryptie en decryptie.

USER WORD kan bv ook gewoon W worden waardoor het alle woorden doet met als eerste letterlijk W !!!!!!