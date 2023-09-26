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