let a = Math.random();
let b = Math.random();

console.log(minimum(a, b));

function minimum(a, b) {
    if (a > b){
        return b;
    } else if (a < b) {
        return a;
    } else{
        return "gelijk aan elkaar"
    }
}