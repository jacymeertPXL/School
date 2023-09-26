let d = new Date(Date.now()).toUTCString();

console.log("On", d, "the imposter acted", sussy());

function sussy() {
    let a = Math.random(0, 1);
    if (a >= 0.5) {
        a = "SUS";
    } else {
        a = "normally";
    }
    return a;
}