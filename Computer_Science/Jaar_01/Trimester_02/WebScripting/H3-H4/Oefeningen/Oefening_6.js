function reverseArray(arr) {
    let reversed = [];
    for (let i = arr.length - 1; i >= 0; i--) {
        reversed.push(arr[i]);
    }
    return reversed;
}

let a = [1, 2, 3];
let b = reverseArray(a);
console.log(a); // Output: [1, 2, 3]
console.log(b); // Output: [3, 2, 1]

