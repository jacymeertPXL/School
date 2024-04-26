// demo json date naar javascript var
let persoonJSON = '{"naam":"Rik", "Leeftijd": 21, "stad":"Genk"}';
let persoon = JSON.parse(persoonJSON);
document.getElementById("demo") = persoon.naam;

// Demo fetch
// fetch(‘URL’) // pad van de bron ingeven
// .then(function(response) { // Response (data) in JSON-formaat ophalen.return response.json()})
//     .then(function(data) { // Response (data) in de console weergeven.console.log(data)})
//         .catch(function(error) { // Eventuele error in console weergeven.console.log(error)})

// Demo fetch 02
fetch('URL') // pad van de bron ingeven

.then(response => response.json()) // Response (data) in JSON-formaat ophalen.return response.json()})

.then(data => console.log(data)) // Response (data) in de console weergeven.console.log(data)})

.catch(error => console.log(error)) // Eventuele error in console weergeven.console.log(error)})