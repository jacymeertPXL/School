console.log(8 * null); // 0 (number)
console.log("5" - 1); // 4 (number)
console.log("5" + 1); // 51 (string)
console.log("five" * 2); // NaN (number)
console.log(false == 0); // true (boolean)
console.log(false === 0); // false (boolean)

if ("a") {
    console.log("de string a is truthy");
}
if (!null) {
    console.log("null is not truthy");
}

let result = a || b;
// als a truthy dan result = a
// anders result = b
function assignName( name ){
return name || "unknown";
}
let person1 = assignName( null );
let person2 = assignName( "sofie" );
console.log( person1 ); // unknown
console.log( person2 ); // sofie