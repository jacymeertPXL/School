// de hekjes ### moet je nog vervangen door eigen code om het
// programma werkend te krijgen
function hint() {
    fetch('http://localhost:3000/gebruiker/')
        .then((response) => {
            if (response.ok) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((personen) => {
            for (let persoon of personen) {
                let id = persoon.id; // Replace ### with the correct code to get the person's ID
                fetch(`http://localhost:3000/registratie?gebruiker_id=${id}`)
                    .then((response) => {
                        if (response.ok) {
                            return response.json();
                        } else {
                            throw `error with status ${response.status}`;
                        }
                    })
                    .then((registraties) => {
                        console.log(id, registraties); // Replace ###,### with the correct code to log the ID and registraties
                        for (let registratie of registraties) {
                            console.log(registratie); // Replace ### with the correct code to log the registratie
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

hint();
