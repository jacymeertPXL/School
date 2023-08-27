let a = 1;
let b = 0;

for (let i = 0; i < 100; i++){
    a += b;
    console.log(a);
    b = a - b;
}