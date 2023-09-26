// naam: 
let select;
let div_output;

window.addEventListener("load", handleWindowload);


function handleWindowload() {
    let url = 'http://localhost:3000/country/';
    let div_select = document.getElementById("div_select");
    let button = document.getElementById("get_ships");
    button.addEventListener("click", handleGetShips);
    div_output = document.querySelector("#div_output");

    select = document.createElement("select");
    div_select.appendChild(select);
    fetch(url)
        .then((response) => {
            if (response.status == 200) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((countries) => {
            let option;
            let option_content;
            for (land of countries) {
                option = document.createElement("option");
                select.appendChild(option);
                option.value = land.id;
                option_content = document.createTextNode(land.name);
                option.appendChild(option_content);
            }
        })
        .catch((error) => {
            div_output.appendChild(document.createTextNode(error));
        });
}

function handleGetShips() {
    makeElementEmpty(div_output);
    let url = 'http://localhost:3000/ship';
    url += '?country_id=' + select.value;
    //alert(select.value);
    fetch(url)
        .then((response) => {
            if (response.status == 200) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((ships) => {
            let speed = getFastedValue(ships);
            let ul = document.createElement("ul");
            let li, li_content;
            console.log(ships);
            div_output.appendChild(ul);
            for (ship of ships) {
                li = document.createElement("li");
                if (ship.speed == speed) {
                    li.style.color = "red";
                }
                li_content = document.createTextNode(ship.name);
                li.appendChild(li_content);
                ul.appendChild(li);
            }
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });

}

function getFastedValue(ships) {
    let speed = 0;
    for (let ship of ships) {
        if (speed < ship.speed) {
            speed = ship.speed;
        }
    }
    return speed;
}

function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
}