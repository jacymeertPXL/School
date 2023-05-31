function telB(woord) {
    return telChar(woord, "B");
}

function telChar(woord, symbool) {
    let count = 0;
    for (let i = 0; i < woord.length; i++) {
        if (woord[i] === symbool) {
            count++;
        }
    }
    return count;
}

console.log(telB("BBBB"));
console.log(telChar("fenne", "e"));