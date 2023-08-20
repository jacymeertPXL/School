let number1 = 12;
let pi = 3.14;
let expnumber = 6.03214e23;
let tooBignumber= 1e1000;

console.log(number1, pi, expnumber, tooBignumber)
console.log(number1)
console.log(number1 / 6) // geeft 2
console.log(typeof number1)
console.log(pi)
console.log(typeof pi)
console.log(expnumber)
console.log(typeof expnumber)
console.log(tooBignumber) // te groot getal word weergegeven als infinity
console.log(1 / tooBignumber) // wordt weergegeven als 0
console.log(tooBignumber / tooBignumber) // NaN not a number kan niet infinity delen door infinity
console.log(typeof tooBignumber)
console.log(52/12*3-4+2%1); // reken operators

let text1 = 'Hello World';

console.log(typeof text1); // string
console.log(text1); // geeft de let weer
console.log(text1 + "\n verwelkoming" ); // geeft de let weer met de extra text maar voegt het er niet aan toe
console.log('text1 fenne is een stinkbeer') // geeft de teskte weer
console.log(`${text1} verwelmont jou!`) // geeft de let weer en je tekst
console.log(`${text1}              verwelmont jou!`) // geeft de let weer en je tekst en de juiste formaat in de backtics ``

let getal1 = 100;
let getal2= 200;
console.log(`${getal1} dit is getal 1 ${getal2} dit is getal 2 en samen zijn ze gelijk aan ${getal1/getal2}`); // formaat met berekingen er in

let text2 = String("Everybody")
console.log(typeof  text2);
console.log(text1 + text2); // gaat de teksten gezamelijk weer geven

let text3 = String("Everybody")
console.log(typeof  text3);
console.log(text1 + text2 + text3); // gaat de teksten gezamelijk weer geven
console.log(text3.toUpperCase()); // gaat het uppercase maken

console.log(1 == "1");
console.log(1 === "1");

let age = 6;
if (age < 18){ // if else statement
    console.log('minor')
}else{
    console.log('adult')
}

console.log(age < 18? 'minor' : 'adult'); // heel korte if else gaat ook alleen als je alleen maar 1 if else hebt woals hierboven


let getalstring = "6";
getalstring = Number(getalstring); // maakt er een getal van
console.log(typeof getalstring); // zegt nu dat het een number is ja kan nu ook berekiningen doen

let getalNumber = 6;
getalNumber = String(getalNumber); // maakt er een string van
console.log(typeof getalNumber); // zegt nu dat het een string is

let undifined;
let nullwaarde = null;

console.log(nullwaarde); // null
console.log(typeof nullwaarde); // null waarde gaat als type object zijn
console.log(undifined); // undefined
console.log(typeof undifined); // type undifined

let a;
let b = "tekst";

// || of of voor de waarde
// && and and allebij moeten true

let result1 = a && b; // gaat het undifined maaken omdat niet allebij true zijn
console.log(result1); // undifined

let result2 = a || b; // geeft de eerste die true is zelfs al is de andere false
console.log(result2); // tekst

let a2 = 'tekst1';
let b2 = "tekst2";

let result3 = a2 && b2; // als allebij true zijn  pakt het de laaste waarden
console.log(result3); // gaat tekst 2 zijn

const PROMPT = require('prompt-sync')();

let naam = PROMPT('geef een naam');
console.log(`welkom ${naam}`);