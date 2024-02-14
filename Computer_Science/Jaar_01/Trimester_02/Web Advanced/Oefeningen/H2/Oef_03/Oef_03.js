// Definieer de variabele met de stringwaarde
var mijnString = 'Ik wil een koekje';

// Toon informatie in de console
console.log('Karakter op positie 0: ' + mijnString.charAt(0));
console.log('Karakter op positie 3: ' + mijnString.charAt(3));

// Zoek positie van karakter 'k' voor de laatste keer
var laatsteKeerK = mijnString.lastIndexOf('k');
console.log('Positie van karakter \'k\' voor de laatste keer: ' + laatsteKeerK);

// Zoek positie van karakter 'e' voor de laatste keer
var laatsteKeerE = mijnString.lastIndexOf('e');
console.log('Positie van karakter \'e\' voor de laatste keer: ' + laatsteKeerE);

// Toon het aantal karakters in de stringwaarde
console.log('Aantal karakters in de stringwaarde: ' + mijnString.length);
