// naam: Jacy Meert 1TINB

const RegestratieBtn = document.getElementById('button_nieuwe_gebruiker');
RegestratieBtn.addEventListener('click', () => {
    Regestratiebruiker();
});

window.addEventListener("load", loaded);
function loaded() {
}

function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
}

function Regestratiebruiker(){
    let url = 'http://localhost:3000/gebruiker/';
    let output = document.getElementById("div_output");
    makeElementEmpty(output);
    let nummerplaat = document.getElementById("input_nummerplaat").value;
    let name = document.getElementById("input_naam").value;
    if (name.length > 2){
        let person = { naam: name, nummerplaat: nummerplaat };
        fetch(url, {
            method: "POST",
            body: JSON.stringify(person),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
            .then((response) => {
                if (response.status == 201) {
                    return response.json();
                } else {
                    throw new Error(`error with status ${response.status}`);
                }
            })
            .then((person) => {
                let data = [person.id, person.naam, person.nummerplaat];
                let informatie = document.createElement("p");
                informatie.appendChild(document.createTextNode(data.join(', ')));
                output.appendChild(informatie);
            })
            .catch((error) => {
                output.appendChild(document.createTextNode(error));
            });
    } else {
        let tekst = "Foutieve ingave";
        let informatie = document.createElement("p");
        informatie.appendChild(document.createTextNode(tekst));
        output.appendChild(informatie);
    }
}
