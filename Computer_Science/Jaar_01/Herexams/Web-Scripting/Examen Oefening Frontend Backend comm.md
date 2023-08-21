 ````javascript
const ToonBtn = document.getElementById('button_toon_filter');  
const VerstopBtn = document.getElementById('button_verstop_filter');  
const RegestratieBtn = document.getElementById('button_get_registraties');  
  
ToonBtn.addEventListener('click', () => {  
    ToonBtn.style.display = 'none';  
    VerstopBtn.style.display = 'block';  
});  
VerstopBtn.addEventListener('click', () => {  
    ToonBtn.style.display = 'block';  
    VerstopBtn.style.display = 'none';  
});  
  
RegestratieBtn.addEventListener('click', () => {  
    toongebruiker();  
});  
  
function toongebruiker() {  
    let naam = document.getElementById("test").value;  
  
    if (naam !== null && naam !== "") {  
        fetch(`http://localhost:3000/gebruiker/?naam=${naam}`)  
            .then((response) => {  
                if (response.ok) {  
                    return response.json();  
                } else {  
                    throw new Error(`Error with status ${response.status}`);  
                }  
            })  
            .then((personen) => {  
                for (let persoon of personen) {  
                    let id = persoon.id;  
                    fetch(`http://localhost:3000/registratie?gebruiker_id=${id}`)  
                        .then((response) => {  
                            if (response.ok) {  
                                return response.json();  
                            } else {  
                                throw new Error(`Error with status ${response.status}`);  
                            }  
                        })  
                        .then((registraties) => {  
                            console.log(id, registraties); // Log the ID and registraties  
                            for (let registratie of registraties) {  
                                console.log(registratie); // Log each registratie  
                            }  
                        })  
                        .catch((error) => {  
                            console.log(error);  
                        });  
                }  
            })  
            .catch((error) => {  
                console.log(error);  
            });  
    } else {  
        fetch('http://localhost:3000/gebruiker/')  
            .then((response) => {  
                if (response.ok) {  
                    return response.json();  
                } else {  
                    throw new Error(`Error with status ${response.status}`);  
                }  
            })  
            .then((personen) => {  
                for (let persoon of personen) {  
                    let id = persoon.id;  
                    fetch(`http://localhost:3000/registratie?gebruiker_id=${id}`)  
                        .then((response) => {  
                            if (response.ok) {  
                                return response.json();  
                            } else {  
                                throw new Error(`Error with status ${response.status}`);  
                            }  
                        })  
                        .then((registraties) => {  
                            console.log(id, registraties); // Log the ID and registraties  
                            for (let registratie of registraties) {  
                                console.log(registratie); // Log each registratie  
                            }  
                        })  
                        .catch((error) => {  
                            console.log(error);  
                        });  
                }  
            })  
            .catch((error) => {  
                console.log(error);  
            });  
    }  
}  
  
window.addEventListener("load", loaded);  
  
function loaded() {  
}  
  
function makeElementEmpty(element) {  
    while (element.hasChildNodes()) {  
        element.removeChild(element.firstChild);  
    }  
}
	 
`````

````html
<!DOCTYPE html>  
<html lang="en">  
<head>  
   <meta charset="UTF-8">  
   <meta name="viewport" content="width=device-width, initial-scale=1.0">  
   <title>Gebruiker Registratie</title>  
   <link rel="stylesheet" href="css/styles.css">  
</head>  
<body>  
<h1>Gebruiker Registratie</h1>  
  
<div class="filter-buttons">  
   <button id="button_toon_filter">Toon Filter</button>  
   <button id="button_verstop_filter">Verstop Filter</button>  
</div>  
  
<label for="test">Naam:</label>  
<input type="text" id="test" placeholder="Vul naam in">  
  
<button id="button_get_registraties">Toon Registraties</button>  
  
<div id="output" class="output"></div>  
  
<script src="script.js"></script>  
</body>  
</html>
`````

````Css
body {  
    font-family: Arial, sans-serif;  
    margin: 0;  
    padding: 0;  
    background-color: #f0f0f0;  
}  
  
h1 {  
    text-align: center;  
    padding: 20px;  
}  
  
.filter-buttons {  
    text-align: center;  
    margin-bottom: 20px;  
}  
  
button {  
    margin: 5px;  
    padding: 10px 20px;  
    background-color: #007bff;  
    color: white;  
    border: none;  
    border-radius: 4px;  
    cursor: pointer;  
}  
  
button:hover {  
    background-color: #0056b3;  
}  
  
label {  
    display: block;  
    margin-top: 10px;  
}  
  
input {  
    width: 100%;  
    padding: 10px;  
    margin-top: 5px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    box-sizing: border-box;  
}  
  
.output {  
    margin-top: 20px;  
    padding: 10px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    background-color: white;  
}
`````

````javascript
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
`````

````html
<!DOCTYPE html>  
<html lang="en">  
<head>  
    <meta charset="UTF-8">  
    <meta name="viewport" content="width=device-width, initial-scale=1.0">  
    <title>Gebruiker Registratie</title>  
    <link rel="stylesheet" href="css/style2b.css">  
</head>  
<body>  
<h1>Gebruiker Registratie</h1>  
  
<label for="input_naam">Naam:</label>  
<input type="text" id="input_naam" placeholder="Vul naam in">  
  
<label for="input_nummerplaat">Nummerplaat:</label>  
<input type="text" id="input_nummerplaat" placeholder="Vul nummerplaat in">  
  
<button id="button_nieuwe_gebruiker">Registreer Gebruiker</button>  
  
<div id="div_output"></div>  
  
<script src=""></script>  
</body>  
</html>
`````

````css
body {  
    font-family: Arial, sans-serif;  
    margin: 0;  
    padding: 0;  
    background-color: #f0f0f0;  
}  
  
h1 {  
    text-align: center;  
    padding: 20px;  
}  
  
label {  
    display: block;  
    margin-top: 10px;  
}  
  
input {  
    width: 100%;  
    padding: 10px;  
    margin-top: 5px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    box-sizing: border-box;  
}  
  
button {  
    display: block;  
    margin: 10px auto;  
    padding: 10px 20px;  
    background-color: #007bff;  
    color: white;  
    border: none;  
    border-radius: 4px;  
    cursor: pointer;  
}  
  
button:hover {  
    background-color: #0056b3;  
}  
  
#div_output {  
    margin-top: 20px;  
    padding: 10px;  
    border: 1px solid #ccc;  
    border-radius: 4px;  
    background-color: white;  
}
`````

#Web-Scripting