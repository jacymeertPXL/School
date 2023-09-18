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


`````python
def encrypt_letter(letter, shift):
    if letter.islower():
        return chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
    else:
        return chr(((ord(letter) - ord('A') + shift) % 26) + ord('A'))

def decrypt_letter(letter, shift):
    if letter.islower():
        return chr(((ord(letter) - ord('a') - shift) % 26) + ord('a'))
    else:
        return chr(((ord(letter) - ord('A') - shift) % 26) + ord('A'))

def encrypt_word(word, shift):
    encrypted_word = ""
    for char in word:
        encrypted_word += encrypt_letter(char, shift)
    return encrypted_word

def decrypt_word(word, shift):
    decrypted_word = ""
    for char in word:
        decrypted_word += decrypt_letter(char, shift)
    return decrypted_word

def main():
    word_list = ["patat", "jacy", "jaylene", "wortel", "PATAt1"]

    selected_word = "jacy" #kan gevraagd worden
    shift = 2 #kan gevraagd worden

    if selected_word.lower() in [word.lower() for word in word_list]:
        encrypted_word = encrypt_word(selected_word, shift)
        decrypted_word = decrypt_word(encrypted_word, shift)

        index = [word.lower() for word in word_list].index(selected_word.lower())
        word_list[index] = encrypted_word

        index = [word.lower() for word in word_list].index(encrypted_word.lower())
        word_list[index] = decrypted_word

        print("Oorspronkelijk woord:", selected_word)
        print("Versleuteld woord:", encrypted_word)
        print("Ontsleuteld woord:", decrypted_word)
        print("Lijst na encryptie en ontcijfering:", word_list)
    else:
        print("Woord niet gevonden in de lijst.")

if __name__ == '__main__':
    main()
`````

#Python