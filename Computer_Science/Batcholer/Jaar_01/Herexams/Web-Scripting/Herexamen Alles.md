
[[Examen Oefening Classes]]
````javascript
class Produkt {  
    constructor(naam, prijs) {  
        if (typeof naam !== 'string' || naam.length <= 2) {  
            throw new Error('Foutieve ingave voor naam');  
        }  
        if (typeof prijs !== 'number' || prijs <= 0) {  
            throw new Error('Foutieve ingave voor prijs');  
        }  
        this._naam = naam;  
        this._prijs = prijs;  
    }  
  
    get prijs() {  
        return this._prijs;  
    }  
  
    get naam() {  
        return this._naam;  
    }  
  
    set naam(value) {  
        if (typeof value === 'string' && value.length > 2) {  
            this._naam = value;  
        } else {  
            throw new Error('Foutieve ingave voor naam');  
        }  
    }  
  
    set prijs(value) {  
        if (typeof value === 'number' && value > 0) {  
            this._prijs = value;  
        } else {  
            throw new Error('Foutieve ingave voor prijs');  
        }  
    }  
}  
  
class Bestellingsonderdeel {  
    constructor() {  
        this.product = null;  
    }  
}  
  
class Aankoop extends Bestellingsonderdeel {  
    constructor(aantal, product) {  
        super();  
        if (!Number.isInteger(aantal) || aantal <= 0) {  
            throw new Error('Foutieve ingave voor aantal');  
        }  
        this._aantal = aantal;  
        this.product = product;  
    }  
  
    get aantal() {  
        return this._aantal;  
    }  
  
    set aantal(value) {  
        if (Number.isInteger(value) && value > 0) {  
            this._aantal = value;  
        } else {  
            throw new Error('Foutieve ingave voor aantal');  
        }  
    }  
  
    berekenPrijs() {  
        return this.aantal * this.product.prijs;  
    }  
}  
  
class ProcentueleKorting extends Bestellingsonderdeel {  
    constructor(kortingProcent) {  
        super();  
        if (typeof kortingProcent !== 'number' || kortingProcent <= 0) {  
            throw new Error('Foutieve ingave voor korting percentage');  
        }  
        this._kortingProcent = kortingProcent;  
    }  
  
    get kortingProcent() {  
        return this._kortingProcent;  
    }  
  
    berekenPrijs(totaalPrijs) {  
        if (typeof totaalPrijs !== 'number' || totaalPrijs <= 0) {  
            throw new Error('Ongeldige totaalprijs');  
        }  
        return -(this.kortingProcent / 100) * totaalPrijs;  
    }  
}  
  
  
class Bestelling extends Bestellingsonderdeel {  
    constructor() {  
        super();  
        this._bestellingsonderdelen = [];  
    }  
  
    voegToe(onderdeel) {  
        this._bestellingsonderdelen.push(onderdeel);  
    }  
  
    berekenPrijs() {  
        let totalePrijs = 0;  
        for (const onderdeel of this._bestellingsonderdelen) {  
            totalePrijs += onderdeel.berekenPrijs(totalePrijs);  
        }  
        return totalePrijs;  
    }  
}  
  
// Voorbeeldgebruik  
const product1 = new Produkt("krant", 3.55);  
const product2 = new Produkt("snoep", 2.33);  
const bestelling = new Bestelling();  
const bestellingsonderdeel1 = new Aankoop(2, product1);  
const bestellingsonderdeel2 = new Aankoop(14, product2);  
const bestellingsonderdeel3 = new ProcentueleKorting(22, bestelling);  
const bestellingsonderdeel4 = new ProcentueleKorting(11, bestelling);  
  
  
bestelling.voegToe(bestellingsonderdeel1);  
bestelling.voegToe(bestellingsonderdeel2);  
bestelling.voegToe(bestellingsonderdeel3);  
bestelling.voegToe(bestellingsonderdeel4);  
  
const totalePrijs = bestelling.berekenPrijs();  
console.log("Totaalprijs van bestelling:", totalePrijs);
`````

Door in de constructor van de superklasse `Bestellingsonderdeel` de eigenschap `this.product` aan te maken en deze te initialiseren met `null`, kunnen de subklassen (`Aankoop` en `ProcentueleKorting`) deze eigenschap gebruiken en toegang krijgen tot het `Product`-object dat aan het bestellingsonderdeel is gekoppeld. Dit stelt de subklassen in staat om berekeningen uit te voeren op basis van de eigenschappen van het product, zoals de naam en prijs.

In de subklassen kun je dan specifieke methoden implementeren om functionaliteit toe te voegen die gebruikmaakt van het `this.product`-object, zoals het berekenen van de prijs voor aankopen of het toepassen van procentuele kortingen op de totaalprijs van de bestelling. Hierdoor wordt de code modulair en kunnen gemeenschappelijke functies en eigenschappen efficiënt worden gedeeld tussen de subklassen.

[[Examen Oefening Frontend Backend comm]]

 ````javascript
const ToonBtn = document.getElementById('button_toon_filter');  
const VerstopBtn = document.getElementById('button_verstop_filter');  
const RegestratieBtn = document.getElementById('button_get_registraties');  
  
ToonBtn.addEventListener('click', () => {  
    ToonBtn.style.display = 'none';  
    VerstopBtn.style.display = 'block';  
});  
VerstopBtn.addEventListener('click', () => {  
    ToonBtn.style.display = 'block';  
    VerstopBtn.style.display = 'none';  
});  
  
RegestratieBtn.addEventListener('click', () => {  
    toongebruiker();  
});  
  
function toongebruiker() {  
    let naam = document.getElementById("test").value;  
  
    if (naam !== null && naam !== "") {  
        fetch(`http://localhost:3000/gebruiker/?naam=${naam}`)  
            .then((response) => {  
                if (response.ok) {  
                    return response.json();  
                } else {  
                    throw new Error(`Error with status ${response.status}`);  
                }  
            })  
            .then((personen) => {  
                for (let persoon of personen) {  
                    let id = persoon.id;  
                    fetch(`http://localhost:3000/registratie?gebruiker_id=${id}`)  
                        .then((response) => {  
                            if (response.ok) {  
                                return response.json();  
                            } else {  
                                throw new Error(`Error with status ${response.status}`);  
                            }  
                        })  
                        .then((registraties) => {  
                            console.log(id, registraties); // Log the ID and registraties  
                            for (let registratie of registraties) {  
                                console.log(registratie); // Log each registratie  
                            }  
                        })  
                        .catch((error) => {  
                            console.log(error);  
                        });  
                }  
            })  
            .catch((error) => {  
                console.log(error);  
            });  
    } else {  
        fetch('http://localhost:3000/gebruiker/')  
            .then((response) => {  
                if (response.ok) {  
                    return response.json();  
                } else {  
                    throw new Error(`Error with status ${response.status}`);  
                }  
            })  
            .then((personen) => {  
                for (let persoon of personen) {  
                    let id = persoon.id;  
                    fetch(`http://localhost:3000/registratie?gebruiker_id=${id}`)  
                        .then((response) => {  
                            if (response.ok) {  
                                return response.json();  
                            } else {  
                                throw new Error(`Error with status ${response.status}`);  
                            }  
                        })  
                        .then((registraties) => {  
                            console.log(id, registraties); // Log the ID and registraties  
                            for (let registratie of registraties) {  
                                console.log(registratie); // Log each registratie  
                            }  
                        })  
                        .catch((error) => {  
                            console.log(error);  
                        });  
                }  
            })  
            .catch((error) => {  
                console.log(error);  
            });  
    }  
}  
  
window.addEventListener("load", loaded);  
  
function loaded() {  
}  
  
function makeElementEmpty(element) {  
    while (element.hasChildNodes()) {  
        element.removeChild(element.firstChild);  
    }  
}
	 
`````

````html
<!DOCTYPE html>  
<html lang="en">  
<head>  
   <meta charset="UTF-8">  
   <meta name="viewport" content="width=device-width, initial-scale=1.0">  
   <title>Gebruiker Registratie</title>  
   <link rel="stylesheet" href="css/styles.css">  
</head>  
<body>  
<h1>Gebruiker Registratie</h1>  
  
<div class="filter-buttons">  
   <button id="button_toon_filter">Toon Filter</button>  
   <button id="button_verstop_filter">Verstop Filter</button>  
</div>  
  
<label for="test">Naam:</label>  
<input type="text" id="test" placeholder="Vul naam in">  
  
<button id="button_get_registraties">Toon Registraties</button>  
  
<div id="output" class="output"></div>  
  
<script src="script.js"></script>  
</body>  
</html>
`````

````Css
body {  
    font-family: Arial, sans-serif;  
    margin: 0;  
    padding: 0;  
    background-color: #f0f0f0;  
}  
  
h1 {  
    text-align: center;  
    padding: 20px;  
}  
  
.filter-buttons {  
    text-align: center;  
    margin-bottom: 20px;  
}  
  
button {  
    margin: 5px;  
    padding: 10px 20px;  
    background-color: #007bff;  
    color: white;  
    border: none;  
    border-radius: 4px;  
    cursor: pointer;  
}  
  
button:hover {  
    background-color: #0056b3;  
}  
  
label {  
    display: block;  
    margin-top: 10px;  
}  
  
input {  
    width: 100%;  
    padding: 10px;  
    margin-top: 5px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    box-sizing: border-box;  
}  
  
.output {  
    margin-top: 20px;  
    padding: 10px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    background-color: white;  
}
`````

````javascript
// naam: Jacy Meert 1TINB  
  
const RegestratieBtn = document.getElementById('button_nieuwe_gebruiker');  
RegestratieBtn.addEventListener('click', () => {  
    Regestratiebruiker();  
});  
  
window.addEventListener("load", loaded);  
function loaded() {  
}  
  
function makeElementEmpty(element) {  
    while (element.hasChildNodes()) {  
        element.removeChild(element.firstChild);  
    }  
}  
  
function Regestratiebruiker(){  
    let url = 'http://localhost:3000/gebruiker/';  
    let output = document.getElementById("div_output");  
    makeElementEmpty(output);  
    let nummerplaat = document.getElementById("input_nummerplaat").value;  
    let name = document.getElementById("input_naam").value;  
    if (name.length > 2){  
        let person = { naam: name, nummerplaat: nummerplaat };  
        fetch(url, {  
            method: "POST",  
            body: JSON.stringify(person),  
            headers: {  
                'Accept': 'application/json',  
                'Content-Type': 'application/json'  
            }  
        })  
            .then((response) => {  
                if (response.status == 201) {  
                    return response.json();  
                } else {  
                    throw new Error(`error with status ${response.status}`);  
                }  
            })  
            .then((person) => {  
                let data = [person.id, person.naam, person.nummerplaat];  
                let informatie = document.createElement("p");  
                informatie.appendChild(document.createTextNode(data.join(', ')));  
                output.appendChild(informatie);  
            })  
            .catch((error) => {  
                output.appendChild(document.createTextNode(error));  
            });  
    } else {  
        let tekst = "Foutieve ingave";  
        let informatie = document.createElement("p");  
        informatie.appendChild(document.createTextNode(tekst));  
        output.appendChild(informatie);  
    }  
}
`````

````html
<!DOCTYPE html>  
<html lang="en">  
<head>  
    <meta charset="UTF-8">  
    <meta name="viewport" content="width=device-width, initial-scale=1.0">  
    <title>Gebruiker Registratie</title>  
    <link rel="stylesheet" href="css/style2b.css">  
</head>  
<body>  
<h1>Gebruiker Registratie</h1>  
  
<label for="input_naam">Naam:</label>  
<input type="text" id="input_naam" placeholder="Vul naam in">  
  
<label for="input_nummerplaat">Nummerplaat:</label>  
<input type="text" id="input_nummerplaat" placeholder="Vul nummerplaat in">  
  
<button id="button_nieuwe_gebruiker">Registreer Gebruiker</button>  
  
<div id="div_output"></div>  
  
<script src=""></script>  
</body>  
</html>
`````

````css
body {  
    font-family: Arial, sans-serif;  
    margin: 0;  
    padding: 0;  
    background-color: #f0f0f0;  
}  
  
h1 {  
    text-align: center;  
    padding: 20px;  
}  
  
label {  
    display: block;  
    margin-top: 10px;  
}  
  
input {  
    width: 100%;  
    padding: 10px;  
    margin-top: 5px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    box-sizing: border-box;  
}  
  
button {  
    display: block;  
    margin: 10px auto;  
    padding: 10px 20px;  
    background-color: #007bff;  
    color: white;  
    border: none;  
    border-radius: 4px;  
    cursor: pointer;  
}  
  
button:hover {  
    background-color: #0056b3;  
}  
  
#div_output {  
    margin-top: 20px;  
    padding: 10px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    background-color: white;  
}
`````

[[`appendChild`, `createElement` en `createTextNode`]]
HTML:
`````html
<!DOCTYPE html>
<html>
<head>
    <title>DOM Manipulation Example</title>
</head>
<body>
    <h1>Shopping List</h1>
    <ul id="item-list">
        <!-- Hier worden de items weergegeven -->
    </ul>
    <form id="add-form">
        <input type="text" id="new-item" placeholder="Voeg een nieuw item toe">
        <button type="submit">Voeg toe</button>
    </form>
    <script src="script.js"></script>
</body>
</html>

`````

JavaScript (`script.js`):

````javascript
const itemList = document.getElementById('item-list');
const addForm = document.getElementById('add-form');
const newItemInput = document.getElementById('new-item');

function createListItem(text) {
    const listItem = document.createElement('li');
    const textNode = document.createTextNode(text);
    listItem.appendChild(textNode);
    return listItem;
}

function addItem(text) {
    const newItem = createListItem(text);
    itemList.appendChild(newItem);
}

addForm.addEventListener('submit', function(event) {
    event.preventDefault();
    const newItemText = newItemInput.value;
    if (newItemText.trim() !== '') {
        addItem(newItemText);
        newItemInput.value = '';
    }
});

`````

In dit voorbeeld gebruiken we `createElement` om een nieuw `li`-element te maken en `createTextNode` om de tekst aan dat element toe te voegen. Vervolgens gebruiken we `appendChild` om het nieuwe `li`-element aan de `ul` met id 'item-list' toe te voegen.

Dit voorbeeld voldoet aan de richtlijnen die je hebt ontvangen en maakt gebruik van de genoemde DOM-methoden voor het opbouwen van de DOM-structuur en het manipuleren van tekstinhoud.

````html
<!doctype html>
<html lang="en">
  <head>
    <title>createTextNode example</title>
    <script>
      function addTextNode(text) {
        const newtext = document.createTextNode(text);
        const p1 = document.getElementById("p1");

        p1.appendChild(newtext);
      }
    </script>
  </head>

  <body>
    <button onclick="addTextNode('YES! ');">YES!</button>
    <button onclick="addTextNode('NO! ');">NO!</button>
    <button onclick="addTextNode('WE CAN! ');">WE CAN!</button>

    <hr />

    <p id="p1">First line of paragraph.</p>
  </body>
</html>

`````

Hier wordt het gedaan dat er text wordt ge add na een button click met addtextnode
dus wanneer er op de button wordt geclicked geef het de string mee naar de functie
en die wal een nieuwe html ellement aanmaken en daarin zal dan de tekst worden gezet 


[[Get, Push, Put, Delete]] 
**GET-verzoek:**
````javascript
// Een GET-verzoek om gegevens op te halen
fetch('https://jsonplaceholder.typicode.com/posts/1')
    .then(response => response.json())
    .then(data => console.log('GET Response:', data))
    .catch(error => console.error('Fout bij GET-verzoek:', error));

`````

**POST-verzoek:**
````javascript
const newPost = {
    title: 'Nieuwe post',
    body: 'Dit is de inhoud van de nieuwe post',
    userId: 1
};

// Een POST-verzoek om gegevens te maken
fetch('https://jsonplaceholder.typicode.com/posts', {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json'
    },
    body: JSON.stringify(newPost)
})
    .then(response => response.json())
    .then(data => console.log('POST Response:', data))
    .catch(error => console.error('Fout bij POST-verzoek:', error));

`````

**PUT-verzoek:**
````javascript
const updatedPost = {
    id: 1,
    title: 'Bijgewerkte post',
    body: 'Dit is de bijgewerkte inhoud van de post'
};

// Een PUT-verzoek om gegevens bij te werken
fetch('https://jsonplaceholder.typicode.com/posts/1', {
    method: 'PUT',
    headers: {
        'Content-Type': 'application/json'
    },
    body: JSON.stringify(updatedPost)
})
    .then(response => response.json())
    .then(data => console.log('PUT Response:', data))
    .catch(error => console.error('Fout bi.j PUT-verzoek:', error));

`````

**DELETE-verzoek:**
````javascript
// Een DELETE-verzoek om gegevens te verwijderen
fetch('https://jsonplaceholder.typicode.com/posts/1', {
    method: 'DELETE'
})
    .then(response => {
        if (response.status === 200) {
            console.log('DELETE Succesvol');
        } else {
            console.log('DELETE Mislukt');
        }
    })
    .catch(error => console.error('Fout bij DELETE-verzoek:', error));

`````

[[Basic arraylist]]

````javascript
// Een eenvoudige lijst met items
let itemList = ['Appel', 'Banaan', 'Sinaasappel'];

// 1. Item toevoegen aan de lijst
function addItem(item) {
    itemList.push(item);
    console.log(`${item} is toegevoegd aan de lijst.`);
}

addItem('Peer');

// 2. Item verwijderen uit de lijst
function removeItem(item) {
    const index = itemList.indexOf(item);
    if (index !== -1) {
        itemList.splice(index, 1);
        console.log(`${item} is verwijderd uit de lijst.`);
    } else {
        console.log(`${item} niet gevonden in de lijst.`);
    }
}

removeItem('Banaan');

// 3. Item vervangen in de lijst
function replaceItem(oldItem, newItem) {
    const index = itemList.indexOf(oldItem);
    if (index !== -1) {
        itemList[index] = newItem;
        console.log(`${oldItem} is vervangen door ${newItem} in de lijst.`);
    } else {
        console.log(`${oldItem} niet gevonden in de lijst.`);
    }
}

replaceItem('Sinaasappel', 'Mango');

// Lijst weergeven na bewerkingen
console.log('Uiteindelijke lijst:', itemList);

`````

Dit voorbeeld illustreert de basisconcepten van het toevoegen, verwijderen en vervangen van items in een JavaScript-lijst. De functies `addItem`, `removeItem` en `replaceItem` illustreren respectievelijk het toevoegen, verwijderen en vervangen van items in de lijst. Na elke bewerking wordt de lijst weergegeven om het resultaat te tonen.

Houd er rekening mee dat dit een eenvoudig voorbeeld is en dat de concepten kunnen worden toegepast op meer complexe situaties en gegevensstructuren.
### Removing the First Element of an Array

The `shift()` method removes and returns the first element of an array.
````javascript
const myArray = [1, 2, 3, 4, 5];

const x = myArray.shift();

console.log(`myArray values: ${myArray}`);
console.log(`variable x value: ${x}`);
`````

### Removing the Last Element of an Array

The `pop()` method removes and returns the last element of an array.
````javascript
const myArray = [1, 2, 3, 4, 5];

const x = myArray.pop();

console.log(`myArray values: ${myArray}`);
console.log(`variable x value: ${x}`);
`````
#### The `delete` Operator

The `delete` operator deletes the object property at the specified index, but does not update the length of the array, and the value at that index of the array will be `undefined`.
````javascript
const myArray = [1, 2, 3, 4, 5];

delete myArray[1];

console.log(`myArray values: ${myArray}`);
`````

```javascript
const myArray = [1, 2, 3, 4, 5];

const index = myArray.indexOf(2);

const x = myArray.splice(index, 1);

console.log(`myArray values: ${myArray}`);
console.log(`variable x value: ${x}`);
```

The `indexOf()` method returns the first index where the value matches the parameter passed into it, and `-1` if no value is found to match.

#### The `filter()` Method

The array `filter()` method takes in a function as a required argument. The function requires one parameter `currentValue`, which represents the element in the array the `filter()` method is currently on while looping through the array.

The function should perform a check that returns `true` if the `currentValue` is the value of the element you wish to remove, and `false` if not.

The `filter()` method then returns an array that contains the values from the array that match the `currentValue`.

The values the `filter()` method returns are not removed from the original array, but that functionality can be added to the function you pass into `filter(`)

```javascript
const myArray = [1, 2, 3, 4, 5];

function removeValue(value, index, arr) {
    // If the value at the current array index matches the specified value (2)
    if (value === 2) {
    // Removes the value from the original array
        arr.splice(index, 1);
        return true;
    }
    return false;
}

// Pass the removeValue function into the filter function to return the specified value
const x = myArray.filter(removeValue);

console.log(`myArray values: ${myArray}`);
console.log(`variable x value: ${x}`);
```

#### The `splice()` Method

The `splice()` method takes two arguments, the index of the element you wish to remove and the index you wish to remove up to.

The `splice()` method creates a new array that stores all the values that were removed from the original array. The original array will no longer contain the values removed, and its length will be updated.
```javascript
const myArray = [1, 2, 3, 4, 5];

const x = myArray.splice(1, 1);

console.log(`myArray values: ${myArray}`);
console.log(`variable x value: ${x}`);
```


#Web-Scripting