let number1 = prompt('Geeft het eerste getal. ');
let number2 = prompt('Geeft het eerste getal. ');

let vermenigvuldigen = number1 * number2;
let Delen = number1 / number2;
let Optellen = number1 + number2;
let aftrekken = number1 - number2;

var TestOp = document.getElementById('Vermenigvuldigen');
TestOp.firstChild.nodeValue = Optellen;

var TekstDelen = document.getElementById('Vermenigvuldigen');
TestOp.firstChild.nodeValue = Delen;

var TekstVermenig = document.getElementById('Vermenigvuldigen');
TestOp.firstChild.nodeValue = vermenigvuldigen;

var TekstAftrekken = document.getElementById('Vermenigvuldigen');
TestOp.firstChild.nodeValue = aftrekken;