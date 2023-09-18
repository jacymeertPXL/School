// naam: Jacy Meert
'use strict';
const btnGetWandeling = document.getElementById('button_nieuwe_wandeling');
const loadHandler= function (){

}

window.addEventListener('load', loadHandler);

//function maakWandeling(datum, naam, postcode, kms){
//    return { id: 5, datum: "nieuw", naam: "nieuw", postcode: 0, kms:[] }
//}
function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
}

function datawandeling(){
    let naam = document.getElementById("input_naam");
    let datum = document.getElementById("input_datum");
    let kms = [];
    let data_kms = document.getElementById("input_km");
    kms.push(data_kms.split(" "));
    const wandeling = {
        naam,
        datum,
        kms
    };
    nieuwewandeling(wandeling);
}

function nieuwewandeling(wandeling){
    let output = document.getElementsByTagName("output")[0];
    let p

    fetch('http://localhost:3000/wandelingen/', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(wandeling)
    })
        .then((response) => {
            if (response.status === 200) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((data) => {
            console.log('POST Response:', data);
            p = document.createElement("p");
            let p_content = document.createTextNode(data.id, data.naam, data.datum, datum.kms);
            output.appendChild(p.appendChild(p_content));
        })
        .catch(error => console.error('Fout bij POST-verzoek:', error));
}

btnGetWandeling.addEventListener('click', datawandeling);