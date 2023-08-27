let aantal, teken = "@",
    tot = 3,
    teller = 1;
for (let i = 7; i > 0; i--) {
    aantal = "";
    for (let j = 1; j <= 7; j++) {
        if (j < i) {
            aantal += " ";
        } else if (j === i) {
            aantal += teken;
        }
    }
    console.log(aantal);
    teken = "";
    for (let k = 0; k < tot; k++) {
        if (teller % 5 === 0) {
            teken += "@"
        } else {
            teken += "#"
        }
        teller++;
    }
    tot += 2;
}