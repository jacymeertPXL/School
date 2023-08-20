window.addEventListener("load", loaded);

function loaded() {
    let button = document.getElementById("button_pokemon");
    button.addEventListener("click", handleGetPokemon);
}


function handleGetPokemon() {
    let id = document.getElementById("pokemon_id").value;
    let output = document.getElementById("ul_output");

    fetchPokemonName(id)
        .then((name) => {
            let li = document.createElement("li");
            li.appendChild(document.createTextNode(name))
            output.appendChild(li);
        })
        .catch((error) => {
            let li = document.createElement("li");
            li.appendChild(document.createTextNode(error.message));
            output.appendChild(li);
        });
}

function fetchPokemonName(id) {
    let promise = new Promise((resolve, reject) => {
        fetch(`https://pokeapi.co/api/v2/pokemon/${id}`)
            .then((response) => {
                if (response.ok) {
                    return response.json();
                } else {
                    return reject(new Error(`${id} -> Error with status code ${response.status}`));
                }
            })
            .then((pokemon) => {
                return resolve(pokemon.name);
            })
            .catch((error) => {
                return reject(error);
            })
    });
    return promise;
}


function makeElementEmpty(element) {
    element.replaceChildren();
}


