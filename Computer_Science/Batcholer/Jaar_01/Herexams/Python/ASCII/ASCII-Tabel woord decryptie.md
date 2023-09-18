````python
def vigenere_encrypt(text, keyword):
    encrypted_text = ''
    keyword_length = len(keyword)
    for i, char in enumerate(text):
        if char.isalpha():
            shift = ord(keyword[i % keyword_length].upper()) - ord('A')
            if char.isupper():
                encrypted_char = chr(((ord(char) - ord('A') + shift) % 26) + ord('A'))
            elif char.islower():
                encrypted_char = chr(((ord(char) - ord('a') + shift) % 26) + ord('a'))
        else:
            encrypted_char = char
        encrypted_text += encrypted_char
    return encrypted_text

def vigenere_decrypt(text, keyword):
    decrypted_text = ''
    keyword_length = len(keyword)
    for i, char in enumerate(text):
        if char.isalpha():
            shift = ord(keyword[i % keyword_length].upper()) - ord('A')
            if char.isupper():
                decrypted_char = chr(((ord(char) - ord('A') - shift) % 26) + ord('A'))
            elif char.islower():
                decrypted_char = chr(((ord(char) - ord('a') - shift) % 26) + ord('a'))
        else:
            decrypted_char = char
        decrypted_text += decrypted_char
    return decrypted_text

text = "HELLO"
keyword = "KEY"

encrypted_text = vigenere_encrypt(text, keyword)
decrypted_text = vigenere_decrypt(encrypted_text, keyword)

print("Original:", text)
print("Encrypted:", encrypted_text)
print("Decrypted:", decrypted_text)

`````
![[Pasted image 20230820011105.png]]
In dit voorbeeld wordt de Vigenère-codering gebruikt, waarbij elke letter van het tekstbericht wordt gecodeerd met de bijbehorende letter uit het trefwoord. Dit proces wordt weergegeven voor het woord "HELLO" met het trefwoord "KEY".

#Python