let grootte = 8 ;
let output = '';
for (let i = 0; i <  grootte; i++) {
    if(grootte % 2 === 0){
        output += '#'
    }else {
        output += ' ';
    }
}

console.log(output)