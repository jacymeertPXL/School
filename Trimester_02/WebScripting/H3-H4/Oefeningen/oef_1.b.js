/*function minimum() {
    let min = arguments[0];
    for (let i = 1; i < arguments.length; i++) {
        if (arguments[i] < min) {
            min = arguments[i];
        }
    }
    return min;
}

let a = 3;
let b = 6;
let min = minimum(a, b);
console.log(min);*/

function minimum(...numbers) {
    let min = numbers[0];
    for (let i = 1; i < numbers.length; i++) {
        if (numbers[i] < min) {
            min = numbers[i];
        }
    }
    return min;
}

let a = 3;
let b = 6;
let c = -5;
let min = minimum(a, b, c);
console.log(min);