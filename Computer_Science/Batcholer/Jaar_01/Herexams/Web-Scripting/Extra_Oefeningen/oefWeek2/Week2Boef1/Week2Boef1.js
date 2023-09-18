function minimum(...getallen) {
    let min = getallen[0];
    for (let getal of getallen) {
        if (getal < min) {
            min = getal;
        }
    }
    return min;
}
console.log(minimum(4, 2, 13, 14, 15, 1, 999));