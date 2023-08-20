Als je een woord in een array hebt en elke letter in dat woord met 2 plaatsen wilt verschuiven in de ASCII-tabel, kun je dat doen met behulp van stringmanipulatie en de ingebouwde functies van Python. Hier is een voorbeeld:

````python
word = "wortel"
shift = 2
encrypted_word = ""

for letter in word:
    # Controleren of het een hoofdletter is
    if letter.isupper():
        encrypted_letter = chr(((ord(letter) - ord('A') + shift) % 26) + ord('A'))
    # Controleren of het een kleine letter is
    elif letter.islower():
        encrypted_letter = chr(((ord(letter) - ord('a') + shift) % 26) + ord('a'))
    else:
        encrypted_letter = letter  # Onveranderde tekens (bv. spaties, leestekens)

    encrypted_word += encrypted_letter

print(encrypted_word)  # Output: "yqtvgn"

`````

In dit voorbeeld wordt elke letter in het woord "wortel" met 2 plaatsen verschoven in de ASCII-tabel. Hoofdletters worden naar hoofdletters omgezet en kleine letters naar kleine letters. Andere tekens, zoals spaties of leestekens, blijven onveranderd.

Dit is slechts een eenvoudige verschuiving van tekens en geen veilige vorm van versleuteling. Voor echte versleuteling moet je gebruikmaken van cryptografische methoden en bibliotheken.