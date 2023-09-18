let lijn;
for (let i = 0; i < 8; i++) {
    lijn = "";
    if (i % 2 == 0) {

        for (let j = 0; j < 8; j++) {
            if (j % 2 == 0) {
                lijn += "#";
            } else {
                lijn += " ";
            }
        }
    } else {
        for (let j = 0; j < 8; j++) {
            if (j % 2 == 0) {
                lijn += " ";
            } else {
                lijn += "#";
            }
        }
    }
    console.log(lijn);

}