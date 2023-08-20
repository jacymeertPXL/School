function fibonacci(num) {
    if (num === 0 || num === 1) {
        return 1;
    } else {
        return fibonacci(num - 2) + fibonacci(num - 1);
    }
}

console.log(fibonacci(0));
console.log(fibonacci(1));
console.log(fibonacci(4));