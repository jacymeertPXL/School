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
for user_word in word_array:
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

````python
word_list = ["patat", "jacy", "jaylene", "wortel"]

# Gebruiker kiest een woord uit de lijst
selected_word = input("Kies een woord uit de lijst: ")

if selected_word in word_list:
    shift = 2
    encrypted_word = ""

    # Versleuteling
    for char in selected_word:
        encrypted_char = chr(ord(char) + shift)
        encrypted_word += encrypted_char

    decrypted_word = ""

    # Ontsleuteling
    for char in encrypted_word:
        decrypted_char = chr(ord(char) - shift)
        decrypted_word += decrypted_char

    print("Oorspronkelijk woord:", selected_word)
    print("Versleuteld woord:", encrypted_word)
    print("Ontsleuteld woord:", decrypted_word)
else:
    print("Woord niet gevonden in de lijst.")

`````

[[Belangrijk ASCII]]

````python
word_list = ["patat", "jacy", "jaylene", "wortel", "PATAt1"]

selected_word = "jacy"

# Zoek het geselecteerde woord in de lijst en vervang het door het versleutelde woord
if selected_word.lower() in [word.lower() for word in word_list]:
    shift = 2
    encrypted_word = ""

    # Versleuteling
    for char in selected_word:
        if char.islower():
            encrypted_char = chr(((ord(char) - ord('a') + shift) % 26) + ord('a'))
        else:
            encrypted_char = chr(((ord(char) - ord('A') + shift) % 26) + ord('A'))
        encrypted_word += encrypted_char

    # Zoek de index van het geselecteerde woord in de lijst en vervang het door het versleutelde woord
    index = [word.lower() for word in word_list].index(selected_word.lower())
    word_list[index] = encrypted_word

    decrypted_word = ""

    # Ontsleuteling
    for char in encrypted_word:
        if char.islower():
            decrypted_char = chr(((ord(char) - ord('a') - shift) % 26) + ord('a'))
        else:
            decrypted_char = chr(((ord(char) - ord('A') - shift) % 26) + ord('A'))
        decrypted_word += decrypted_char

    # Zoek de index van het versleutelde woord in de lijst en vervang het door het ontcijferde woord
    index = [word.lower() for word in word_list].index(encrypted_word.lower())
    word_list[index] = decrypted_word

    print("Oorspronkelijk woord:", selected_word)
    print("Versleuteld woord:", encrypted_word)
    print("Ontsleuteld woord:", decrypted_word)
else:
    print("Woord niet gevonden in de lijst.")

# Toon de bijgewerkte lijst na de encryptie en ontcijfering
print("Lijst na encryptie en ontcijfering:", word_list)

`````

#Python