let aantal, teken = "#";
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
    teken += "##"
}