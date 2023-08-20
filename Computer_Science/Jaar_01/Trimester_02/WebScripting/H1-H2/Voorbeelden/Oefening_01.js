const PROMPT = require('prompt-sync')();
let getal = Number(PROMPT('geef een getal in: '));

if (typeof getal == 'number' && getal <= 10 && getal >= 0) {
    const randomgetal = getRandomInt();
    for (let number = 0; number >= 3; number++) {
        if (getal === randomgetal) {
            console.log('Proficiat');
        } else {
            getal = Number(PROMPT('geef een nieuwe getal in: '));
            number++;
        }
        if (number === 3 ){
            console.log('Sorry niet geraden');
        }
    }
}

function getRandomInt() {
    return Math.floor(Math.random() * 10 + 1);
}

