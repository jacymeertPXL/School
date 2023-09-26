//a

let aantalLijnen = 7;
for (let i = 0; i < aantalLijnen; i++) {
    console.log("#".repeat(i));
}

console.log();

//c
let output = "";
let teken = "#";
for (let i = 0; i <= aantalLijnen; i++) {
    let spaces = "";
    for (let j = 0; j <= (aantalLijnen - i); j++) {
        spaces += " ";
    }
    console.log(spaces + teken);
    teken += "##";
}

console.log();

//d
output = "";
let interval = 5;
let teller = 5;
for (let i = 0; i <= aantalLijnen; i++) {
    spaces = "";
    for (let j = 0; j <= (aantalLijnen - i); j++) {
        spaces += " ";
    }
    for (let k = 1; k < 2 * i; k++) {
        if (teller == interval) {
            output += "@";
            teller = 0;
        } else {
            output += "#";
        }
        teller++;
    }
    console.log(spaces + output);
    output = "";
}