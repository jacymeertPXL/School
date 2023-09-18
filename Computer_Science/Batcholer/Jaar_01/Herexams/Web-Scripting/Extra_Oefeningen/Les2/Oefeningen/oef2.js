function isEven(a) {
    if (a === 0) {
        return true;
    } else if (a === 1) {
        return false;
    }
    return isEven(a - 2);
}

console.log(isEven(0));
console.log(isEven(1));
console.log(isEven(16));