function maakRij(ondergrens, bovengrens, stap) {
    let array = [];
    if (ondergrens < bovengrens) {
        for (let i = ondergrens; i <= bovengrens; i += stap) {
            array.push(i);
        }
    } else {
        for (let i = ondergrens; i >= bovengrens; i -= stap) {
            array.push(i);
        }
    }
    return array;
}

console.log(maakRij(1, 5, 1));
console.log(maakRij(5, 1, 1));