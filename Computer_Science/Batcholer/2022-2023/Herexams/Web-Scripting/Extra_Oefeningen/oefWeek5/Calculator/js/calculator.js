let calculation = "";
let ul_output;
let array_data = [
    [7, 8, 9],
    [4, 5, 6],
    [1, 2, 3],
    [0, ".", "="]
];

const button_click = (event) => {
    if (event.target.firstChild.nodeValue == "=") {
        let li_calculator = document.createElement("li");
        ul_output.appendChild(li_calculator);
        let li_textnode = document.createTextNode(calculation);
        li_calculator.appendChild(li_textnode);
        calculation = "";
    } else {
        calculation += event.target.firstChild.nodeValue;
    }
}

const handleLoad = () => {
    //Hier moet je de handels van de element nodes outputcalculator en 
    //outputresults definieren als een variable.
    //crieer dynamisch het element ul
    //ook niet vergeten aan het juiste output ellement koppelen met appendchild()
    let output_results = document.getElementById("output_results");
    ul_output = document.createElement("ul");
    output_results.appendChild(ul_output);
    let output_calculator = document.getElementById("output_calculator");
    let table_calculator = document.createElement("table");
    output_calculator.appendChild(table_calculator);
    for (let list_item of array_data) {
        let tr_calculator = document.createElement("tr");
        table_calculator.appendChild(tr_calculator);
        for (let item_calculator of list_item) {
            let button_calculator = document.createElement("button");
            button_calculator.addEventListener("click", button_click);
            button_calculator.classList.add("button");
            button_calculator.classList.add("button_x");
            let button_textnode = document.createTextNode(item_calculator);
            button_calculator.appendChild(button_textnode);
            let td_calculator = document.createElement("td");
            td_calculator.appendChild(button_calculator);
            tr_calculator.appendChild(td_calculator);
        }

    }
    //Gebruik hier de data van de array om je cijferbord te maken.
    //hint: createelement en createtextnode
    //hint: dubbele for gebruiken om je rijen te maken.
    //koppel aan iedere button met de eventlistener een functie button_click
    //die je extern beschrijft. 
}

window.addEventListener("load", handleLoad);