function fetchPokemonName(id) {
    let promise = new Promise((resolve, reject) => {
        fetch(`https://pokeapi.co/api/v2/pokemon/${id}`)
            .then((response) => {
                if (response.ok) {
                    return response.json();
                } else {
                    return reject(`error status code ${response.status}`);

                }
            })
            .then((pokemon) => {
                resolve(pokemon.name);
            })
            .catch((error) => {
                return reject(error);
            })
    });
    return promise;
}

for (let i = 0; i < 10; i++) {
    fetchPokemonName(i)
        .then((name) => {
            console.log(i, name)
        })
        .catch((error) => {
            console.log(error)
        })
}
