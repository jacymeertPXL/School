// naam: Jacy Meert
'use strict';

//const geefWandelingen = function () {
//    return [{id:1, datum:"07/08/2023",naam:"mijnwandeling", postcode:"3630",kms:[10]},
//        {id:2, datum:"01/07/2023",naam:"Kristoffeltocht", postcode:"3945",kms:[4,7,13,18,25]},
//        {id:3, datum:"01/07/2023",naam:"Kermistocht in de natuur", postcode:"8020",kms:[7,12,18,24,30]},
//        {id:4, datum:"07/08/2023",naam:"oogsttocht", postcode:"3590",kms:[4,6,12,18,21,42]}]
//}
const loadHandler= function (){

}

window.addEventListener('load', loadHandler);
function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
}

function geefWandelingen(){
    let table;
    let thead;
    let th;
    let th_content;
    let tr;
    let td;
    let td_content;
    fetch("http://localhost:3000/wandelingen/")
        .then((response) => {
            if (response.ok) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((wandelingen)=> {
            table = document.createElement("table");
            thead = document.createElement("thead");
            table.appendChild(thead);
            th = document.createElement("th");
            th_content = document.createTextNode("datum");
            th.appendChild(th_content);
            thead.appendChild(th);
            th_content = document.createTextNode("naam");
            th.appendChild(th_content);
            thead.appendChild(th);
            th_content = document.createTextNode("postcode");
            th.appendChild(th_content);
            thead.appendChild(th);

            let button;
            let button_content;
            let h1;
            let h1_content;
            let p;
            let p_content;

            for(let wandeling of wandelingen){
                console.log(wandeling.datum, wandeling.naam, wandeling.postcode ,wandeling.kms);
                tr = document.createElement("tr");
                table.appendChild(tr);

                td = document.createElement("td");
                button = document.createElement("button");
                button_content = document.createTextNode(wandeling.datum);
                // button.addEventListener("click", toondatum(wandeling.datum));
                button.appendChild(button_content);
                td.appendChild(button);
                tr.appendChild(td);

                td_content = document.createTextNode(wandeling.naam);
                td.appendChild(td_content)
                tr.appendChild(td);

                td_content = document.createTextNode(wandeling.postcode);
                td.appendChild(td_content)
                tr.appendChild(td);
            }
            //let keys = Object.keys(###);
            // console.log(keys);
        })
        .catch((error)=>{
            console.log(error.message);
        })
}

geefWandelingen();

function toondatum(wandeling.datum){
    function toondatumfetch(){
        fetch(`http://localhost:3000/wandelingen/?datum=` + wandeling.datum)
            .then((response) => {
                if (response.ok) {
                    return response.json();
                } else {
                    throw `error with status ${response.status}`;
                }
            })
            .then((wandelingen)=> {

                for( let wandeling of wandelingen){
                    console.log(#wandeling.datum, wandeling.kms)
                    let blockquote = document.createElement("blockquote");
                    let  h1 = document.createElement("h1");
                    let h1_content;
                    let p = document.createElement("p");
                    let p_content;

                    h1_content.createTextNode(wandeling.datum);
                    h1.appendChild(h1_content)
                    blockquote.appendChild(h1);

                    p_content.createTextNode(wandeling.kms);
                    p.appendChild(p_content)
                    blockquote.appendChild(p);
                    // body.appendChild(blockquote);
                }

            })
            .catch((error)=>{
                console.log(error.message);
            })
    }
    toondatumfetch();
}
