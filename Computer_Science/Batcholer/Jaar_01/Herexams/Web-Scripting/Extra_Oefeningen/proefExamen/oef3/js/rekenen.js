// naam: 

// hint: if( ! /^\d+$/.test(ingave) )

window.addEventListener("load", handleLoad);

function handleLoad() {
    let button_start_rekenen = document.getElementById("button_start_rekenen");
    button_start_rekenen.addEventListener("click", handleClick);
}


function handleClick() {
    let div_output = document.querySelector("#vermenigvuldigingen");
    makeElementEmpty(div_output);
    let hr;
    let div;
    let input;
    let getal1;
    let getal2;
    let aantal = document.getElementById("input_aantal");
    for (let i = 0; i < aantal.value; i++) {
        getal1 = parseInt(10 * Math.random());
        getal2 = parseInt(10 * Math.random());
        hr = document.createElement("hr");
        div_output.appendChild(hr);
        div = document.createElement("div");
        div_output.appendChild(div);
        div_content = document.createTextNode(`${getal1} * ${getal2} = `);
        div.appendChild(div_content);
        input = document.createElement("input");
        input.addEventListener("keyup", handleKeyupInput);
        div.appendChild(input);
    }

}

function handleKeyupInput(event) {
    if (!/^\d+$/.test(event.target.value)) {
        event.target.style.color = "red";
    } else {
        event.target.style.color = "black";
    }
}

function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
}