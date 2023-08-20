function maakRij(min, max, stap = 1) {
    const rij = [];
    if (stap > 0) {
        for (let i = min; i <= max; i += stap) {
            rij.push(i);
        }
    } else {
        for (let i = min; i >= max; i += stap) {
            rij.push(i);
        }
    }
    return rij;
}

console.log(maakRij(1,5,2));
console.log(maakRij(5,1,-2));