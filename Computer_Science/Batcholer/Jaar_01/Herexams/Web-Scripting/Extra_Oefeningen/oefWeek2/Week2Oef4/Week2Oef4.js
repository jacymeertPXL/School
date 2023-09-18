function telB(woord) {
    return telChar(woord, "b");
}

function telChar(woord, char) {
    let aantal = 0;
    for (let letter of woord) {
        if (letter === char) {
            aantal++;
        }
    }
    return aantal;
}


let woord = "b fefefzebfzfzef"
let woord2 = "c fcefefzecbfzcfzef"
console.log(telB(woord.toLowerCase()))

console.log(telChar(woord2.toLowerCase(), "c"))