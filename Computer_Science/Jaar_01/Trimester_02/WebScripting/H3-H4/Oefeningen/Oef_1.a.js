function minimum(num1, num2) {
    if (num1 < num2) {
        return num1;
    } else {
        return num2;
    }
}

let a = 3;
let b = 6;
let min = minimum(a, b);
console.log(min);