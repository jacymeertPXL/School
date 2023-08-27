function isEven(getal) {
    if (getal === 0) {
        return true;
    } else if (getal === 1) {
        return false;
    } else {
        getal -= 2;
        return isEven(getal);
    }
}
let output = isEven(7) ? "Even" : "Oneven";
console.log(output);