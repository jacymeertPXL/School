Natuurlijk, hier is een voorbeeld waarin we `appendChild`, `createElement` en `createTextNode` gebruiken om een lijst met items in de DOM op te bouwen:

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

Hier wordt het gedaan dat er text wordt gead na een button click met addtextnode
dus wanneer er op de button wordt geclicked geef het de string mee naar de functie
en die wal een nieuwe html ellement aanmaken en daarin zal dan de tekst worden gezet 

#Web-Scripting