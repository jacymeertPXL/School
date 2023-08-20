function getRandomInt() {
    return Math.floor(Math.random() * 10 + 1);
}
let randomgetal = getRandomInt();

if (randomgetal % 3 === 0 && randomgetal % 5 !== 0){
    console.log('Fizz');
}

if (randomgetal % 5 === 0 && randomgetal % 3 !== 0){
    console.log('Buzz');
}

if (randomgetal % 5 === 0 && randomgetal % 3 === 0){
    console.log('Buzz');
}