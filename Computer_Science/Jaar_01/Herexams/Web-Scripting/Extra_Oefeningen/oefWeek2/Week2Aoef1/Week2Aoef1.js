function minimum(x, y) {
    if (x < y) {
        return x;
    } else if (y < x) {
        return y;
    } else {
        return "getallen zijn gelijk";
    }
}
let x = 11,
    y = 11
console.log(minimum(x, y));