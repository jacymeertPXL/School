[[Basics]] 
[[Oppervlakte berekenen]]

1. **While-lus:**

Een `while`-lus wordt gebruikt om een bepaalde set instructies herhaaldelijk uit te voeren zolang een bepaalde voorwaarde waar is.

````python
count = 0 while count < 5:    
	print("Count is:", count)     
	count += 1
`````

2. **For-lus:**

Een `for`-lus wordt gebruikt om een bepaalde set instructies te herhalen over een reeks waarden, zoals een lijst of een bereik.

```python
fruits = ["apple", "banana", "cherry"] 
for fruit in fruits:     
	print(fruit)
`````

3. **If-else:**

`if` en `else` worden gebruikt voor het uitvoeren van verschillende stukken code op basis van voorwaarden.

````python
age = 18 
	if age >= 18:     
		print("You are an adult") 
	else:     
		print("You are a minor")
`````

4. **Conversie van int naar string en omgekeerd:**

Je kunt `str()` gebruiken om een getal naar een string te converteren en `int()` om een string naar een integer te converteren.

````python
number = 42 
string_number = "123"
number_as_string = str(number) print("Number as string:", number_as_string) 
string_as_int = int(string_number) print("String as int:", string_as_int)
`````

Dit zijn basisvoorbeelden om je op weg te helpen met deze concepten. Je kunt ze verder uitbreiden en aanpassen aan je behoeften.

[[Arrays Voorbeelden]]

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
	Voor 2-dimensionale arrays gebruik ik hier de populaire `numpy` library.

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

[[Splits in string van array]]
Als je wilt dat de `%` wordt verwijderd uit de resulterende lijst van componenten na het splitsen, kun je dat doen door elk element in de lijst te doorlopen en de `%` te verwijderen. Hier is hoe je dat kunt doen:

````python
import re

def split_apartment_data(apartment):
    components = re.split(r'%', apartment)
    components = [comp.strip() for comp in components if comp.strip()]
    
    # Verwijder '%' uit elk component
    components = [comp.replace('%', '') for comp in components]
    
    residence = components[0]
    stars = components[1]
    apartment_type = components[2]
    opp_index = components.index("opp:")

    opp = components[opp_index + 1]
    if "balkon" in components:
        balkon = "Ja"
        afstand_index = components.index("afstand:")
    else:
        balkon = "Nee"
        afstand_index = components.index("afstand:") - 1

    afstand = components[afstand_index + 1]
    prijs_index = components.index("prijs")
    prijs = components[prijs_index + 1]
    
    return {
        "residence": residence,
        "stars": stars,
        "apartment_type": apartment_type,
        "opp": opp,
        "balkon": balkon,
        "afstand": afstand,
        "prijs": prijs
    }

for apartment in apartment_list:
    data = split_apartment_data(apartment)
    print("Residence:", data["residence"])
    print("Stars:", data["stars"])
    print("Apartment Type:", data["apartment_type"])
    print("Oppervlakte:", data["opp"])
    print("Balkon:", data["balkon"])
    print("Afstand:", data["afstand"])
    print("Prijs:", data["prijs"])
    print("-------------------")

````

In dit voorbeeld gebruiken we een lijstverwerkingsstap 
`components = [comp.replace('%', '') for comp in components]` om elk element in de lijst te nemen en de `%` te verwijderen met behulp van de `replace`-methode. Dit zorgt ervoor dat de `%` uit de componenten wordt verwijderd voordat ze verder worden verwerkt.

[[Splits in string van array 2]]
Als je de gegevens wilt splitsen op elk nummer of elk uitroepteken (!), kun je de `re` (regular expression) module van Python gebruiken. Hier is hoe je de `split_apartment_data`-functie kunt aanpassen om op elk nummer of elk uitroepteken te splitsen

 ````python
 import re

def split_apartment_data(apartment):
    components = re.split(r'\d+|!', apartment)
    components = [comp.strip() for comp in components if comp.strip()]
    
    residence = components[0]
    stars = components[1]
    apartment_type = components[2]
    opp_index = components.index("opp:")

    opp = components[opp_index + 1]
    if "balkon" in components:
        balkon = "Ja"
        afstand_index = components.index("afstand:")
    else:
        balkon = "Nee"
        afstand_index = components.index("afstand:") - 1

    afstand = components[afstand_index + 1]
    prijs_index = components.index("prijs")
    prijs = components[prijs_index + 1]
    
    return {
        "residence": residence,
        "stars": stars,
        "apartment_type": apartment_type,
        "opp": opp,
        "balkon": balkon,
        "afstand": afstand,
        "prijs": prijs
    }

for apartment in apartment_list:
    data = split_apartment_data(apartment)
    print("Residence:", data["residence"])
    print("Stars:", data["stars"])
    print("Apartment Type:", data["apartment_type"])
    print("Oppervlakte:", data["opp"])
    print("Balkon:", data["balkon"])
    print("Afstand:", data["afstand"])
    print("Prijs:", data["prijs"])
    print("-------------------")

````

In dit voorbeeld gebruiken we de `re.split()`-functie van de `re`-module om de tekst te splitsen op elk nummer of elk uitroepteken (!). De `r'\d+|!'` reguliere expressie betekent dat we splitsen op elke reeks opeenvolgende cijfers (`\d+`) of elk uitroepteken (`!`). Daarna verwijderen we eventuele lege en overbodige spaties en splitsen we de tekst in de vereiste componenten voor elk appartement.

[[Splits in string van array 3]]
 ````python
apartment_list = [
    "Résidence Noeyms **** T0 opp:32 afstand:30  prijs 159",
    "Résidence Noemys **** T0 opp:28 balkon afstand:30 prijs 139",
    "Résidence Noemys **** T1 opp:34 afstand:30  prijs 148",
    "Résidence Noemys **** T3 opp:100 balkon afstand:30 prijs 431",
    "Résidence Noemys **** T1 opp:44 afstand:30 prijs 204",
    # ... andere appartementen hier ...
    "Résidence Pégase ** T0 opp:25 afstand:300 prijs 60"
]

def split_apartment_data(apartment):
    components = apartment.split()
    residence = components[0] + " " + components[1]
    stars = components[2]
    apartment_type = components[3]
    opp_index = components.index("opp:")

    opp = components[opp_index + 1]
    if "balkon" in components:
        balkon = "Ja"
        afstand_index = components.index("afstand:")
    else:
        balkon = "Nee"
        afstand_index = components.index("afstand:") - 1

    afstand = components[afstand_index + 1]
    prijs_index = components.index("prijs")
    prijs = components[prijs_index + 1]
    
    return {
        "residence": residence,
        "stars": stars,
        "apartment_type": apartment_type,
        "opp": opp,
        "balkon": balkon,
        "afstand": afstand,
        "prijs": prijs
    }

for apartment in apartment_list:
    data = split_apartment_data(apartment)
    print("Residence:", data["residence"])
    print("Stars:", data["stars"])
    print("Apartment Type:", data["apartment_type"])
    print("Oppervlakte:", data["opp"])
    print("Balkon:", data["balkon"])
    print("Afstand:", data["afstand"])
    print("Prijs:", data["prijs"])
    print("-------------------")


````

Dit zal de gesplitste gegevens van elk appartement in de lijst weergeven, met labels voor elk van de eigenschappen zoals residence, aantal sterren, appartementtype, oppervlakte, aanwezigheid van een balkon, afstand en prijs.

[[ASCII-Tabel 1D en 2D]]
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

[[ASCII-Table 1D en 2D beter]]
````python
import numpy as np

def encrypt_letter(letter, shift):
    if letter.isalpha(): #controleert of het een letter is 
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

````python
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


[[ASCII-Tabel 2 dimensionaal]]

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

In dit voorbeeld wordt het woord "wortel" in een 2D-array van woorden gezocht en alleen dat specifieke woord wordt versleuteld en ontcijferd. Andere woorden in de array blijven ongewijzigd. Dit is een wat complexere aanpak omdat we moeten controleren welk woord we moeten versleutelen en ontcijferen binnen de array, maar het idee blijft hetzelfde als in eerdere voorbeelden.c

[[ASCII-Tabel Wortel shift 2]]
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

[[ACSII-Tabel om de letter]] [[Enumarate]]
````python
def custom_encrypt(text, alternate_change):
    encrypted_text = ''
    for i, char in enumerate(text):#enumerate gaat uit een lijsthetwoordtpakken
        if i % 2 == alternate_change:
            encrypted_char = chr(ord('a') + ord(char) - ord('a') + 1)
        else:
            encrypted_char = char
        encrypted_text += encrypted_char
    return encrypted_text

def custom_decrypt(text, alternate_change):
    decrypted_text = ''
    for i, char in enumerate(text):
        if i % 2 == alternate_change:
            decrypted_char = chr(ord('a') + ord(char) - ord('a') - 1)
        else:
            decrypted_char = char
        decrypted_text += decrypted_char
    return decrypted_text

word = "wortel"
alternate_change = 0

encrypted_word = custom_encrypt(word, alternate_change)
decrypted_word = custom_decrypt(encrypted_word, alternate_change)

print("Original:", word)
print("Encrypted:", encrypted_word)
print("Decrypted:", decrypted_word)

`````

`Original: wortel Encrypted: wsrtfl Decrypted: wortel`

Dit aangepaste voorbeeld past de encryptie en decryptie toe zoals je hebt beschreven: om de één index in het woord wordt aangepast en om de andere niet. De letter op de even index (0, 2, 4, enz.) wordt met één verschoven in de ASCII-waarde tijdens de encryptie, en bij de ontcijfering wordt deze verschuiving teruggenomen. De letter op de oneven index (1, 3, 5, enz.) blijft ongewijzigd.

[[ASCII-Tabel woord decryptie]]
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

[[ASCII-Tabel User input]]
user geeft een woord in en die wordt met de ascii table gerbuikt 

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

````python
word_list = ["patat", "jacy", "jaylene", "wortel"]

# Gebruiker kiest een woord uit de lijst
selected_word = input("Kies een woord uit de lijst: ")

if selected_word.lower() in word_list:  # Gebruik .lower() om hoofdletters te negeren
    shift = 2
    encrypted_word = ""

    # Versleuteling
    for char in selected_word:
        if char.islower():
            encrypted_char = chr(((ord(char) - ord('a') + shift) % 26) + ord('a'))
        else:
            encrypted_char = chr(((ord(char) - ord('A') + shift) % 26) + ord('A'))
        encrypted_word += encrypted_char

    decrypted_word = ""

    # Ontsleuteling
    for char in encrypted_word:
        if char.islower():
            decrypted_char = chr(((ord(char) - ord('a') - shift) % 26) + ord('a'))
        else:
            decrypted_char = chr(((ord(char) - ord('A') - shift) % 26) + ord('A'))
        decrypted_word += decrypted_char

    print("Oorspronkelijk woord:", selected_word)
    print("Versleuteld woord:", encrypted_word)
    print("Ontsleuteld woord:", decrypted_word)
else:
    print("Woord niet gevonden in de lijst.")

`````

````python
word_list = ["patat", "jacy", "jaylene", "wortel", "PATAt1"]

# Gebruiker kiest een woord uit de lijst
selected_word = input("Kies een woord uit de lijst: ")

if selected_word.lower() in [word.lower() for word in word_list]:  # Gebruik .lower() om hoofdletters te negeren
    shift = 2
    encrypted_word = ""

    # Versleuteling
    for char in selected_word:
        if char.islower():
            encrypted_char = chr(((ord(char) - ord('a') + shift) % 26) + ord('a'))
        else:
            encrypted_char = chr(((ord(char) - ord('A') + shift) % 26) + ord('A'))
        encrypted_word += encrypted_char

    decrypted_word = ""

    # Ontsleuteling
    for char in encrypted_word:
        if char.islower():
            decrypted_char = chr(((ord(char) - ord('a') - shift) % 26) + ord('a'))
        else:
            decrypted_char = chr(((ord(char) - ord('A') - shift) % 26) + ord('A'))
        decrypted_word += decrypted_char

    print("Oorspronkelijk woord:", selected_word)
    print("Versleuteld woord:", encrypted_word)
    print("Ontsleuteld woord:", decrypted_word)
else:
    print("Woord niet gevonden in de lijst.")

`````

Met dit voorbeeld kan de gebruiker een willekeurig woord invoeren dat moet worden versleuteld en ontcijferd. Alleen het ingevoerde woord wordt verwerkt en het resultaat wordt weergegeven. Dit maakt het mogelijk om elk willekeurig woord in te voeren voor encryptie en decryptie.

[[pyramids]]
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

```python
# Piramide weergave
def custom_pyramid_display(text):
    for i in range(len(text), 0, -1):
        spaces = ' ' * (len(text) - i)
        print(spaces + text[-i:])

gewoon tf dit doet dus 
w
	o
		r enz 
```

[[Extra]]


<mark style="background: #FFB8EBA6;">print specific character from string:</mark>

```python
mystring = "hello world"
lookingfor = "l"
for c in range(0, len(mystring)):
    if mystring[c] == lookingfor:
        print(str(c) + " " + mystring[c]);
```

Outputs: geeft u de index positie terug 
```python
2 l
3 l
9 l
```

<mark style="background: #FFB8EBA6;">And more along the lines of hangman:</mark>

```python
mystring = "hello world"
lookingfor = "l"
for c in range(0, len(mystring)):
    if mystring[c] == lookingfor:
        print(mystring[c], end="")
    elif mystring[c] == " ":
        print(" ", end="")
    else:
        print("-", end="")
```

produces: Haalt alles weg behalve de letter 
```python
--ll- ---l-
```

#Python