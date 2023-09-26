// naam: Jacy Meert 1 TINB

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
