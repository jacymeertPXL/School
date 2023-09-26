let punt1 = { x: 1, y: 1 };
let punt2 = { x: 2, y: 3 };
let afstand = berekenAfstand(punt1, punt2);
console.log(afstand);

function berekenAfstand(x, y) {
    return Math.sqrt(Math.pow(x.x - y.x, 2) + Math.pow(x.y - y.y, 2));
}