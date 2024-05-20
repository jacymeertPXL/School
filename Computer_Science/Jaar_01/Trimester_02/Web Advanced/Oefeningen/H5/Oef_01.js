// document.getElementById("knop").onclick = toondatum;

// function toondatum(){
//     document.getElementById("datumparagraaf").innerHTML = Date();
// }

let nummerclicks = 0;

document.getElementById("knop").addEventListener("click", aantalClicks);

function aantalClicks(){
    nummerclicks++;
    document.getElementById("clicksparagraaf").innerHTML = "Je hebt " + nummerclicks + " keer geclicked!";
}