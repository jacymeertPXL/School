// de hekjes ### moet je nog vervangen door eigen code om het
// programma werkend te krijgen

function hint() {
    fetch('http://localhost:3000/gebruiker/?naam=tim')
        .then((response) => {
            if (response.ok) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((personen) => {
            for (let persoon of personen) {
                let id = persoon.id; // Use the ID of the current person
                fetch(`http://localhost:3000/registratie?gebruiker_id=${id}`)
                    .then((response) => {
                        if (response.ok) {
                            return response.json();
                        } else {
                            throw `error with status ${response.status}`;
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

hint();
