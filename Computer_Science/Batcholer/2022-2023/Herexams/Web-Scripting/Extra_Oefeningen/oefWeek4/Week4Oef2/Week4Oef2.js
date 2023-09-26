'use strict'

const handleClick = (event) => {
    let array_inputs = document.querySelectorAll("input");
    let num1 = parseInt(array_inputs[0].value);
    let num2 = parseInt(array_inputs[1].value);
    array_inputs[2].value = `Het product van ${num1} en ${num2} is ${num1*num2}`;
}

const handleOninput = (event) => {
    let array_inputs = document.querySelectorAll("input");
    if (Number.isNaN(parseInt(event.target.value))) {
        array_inputs[2].value = "dit is geen getal";
        alert(parseInt(event.target.value));
    } else {
        array_inputs[2].value = "";
    }
}


const handleLoad = () => {
    let output_var = document.querySelector("output");
    let input_tag = document.createElement("input");
    input_tag.style.width = "100px";
    input_tag.oninput = handleOninput;
    //input_tag.addEventListener("oninput", handleOninput);
    output_var.appendChild(input_tag);
    let x_tag = document.createTextNode("X");
    output_var.appendChild(x_tag);
    input_tag = document.createElement("input");
    input_tag.style.width = "100px";
    input_tag.oninput = handleOninput;
    //input_tag.addEventListener("oninput", handleOninput);
    output_var.appendChild(input_tag);
    let button_tag = document.createElement("button");
    button_tag.addEventListener("click", handleClick);
    output_var.appendChild(button_tag);
    let button_content = document.createTextNode("Bereken");
    button_tag.appendChild(button_content);
    let br_tag = document.createElement("br");
    output_var.appendChild(br_tag);
    input_tag = document.createElement("input");
    input_tag.style.width = "293px";
    output_var.appendChild(input_tag);
}




window.addEventListener("load", handleLoad);