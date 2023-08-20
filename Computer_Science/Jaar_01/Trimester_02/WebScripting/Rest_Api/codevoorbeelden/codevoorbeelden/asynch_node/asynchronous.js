const fetch = require('node-fetch');

console.log('start program');

function fetchPokemon(id){
  console.log(`GET-request https://pokeapi.co/api/v2/pokemon/${id}`);
  fetch(`https://pokeapi.co/api/v2/pokemon/${id}`)
  .then((response) => {
               if(response.status==200) {
                    return response.json();
                } else {
                    throw `error ${response.status}`;
                }
        })
  .then((pokemon) => {console.log(id, pokemon.name);})
  .catch((error) => {console.log(id, error);})
}
for (let i = 0; i < 10; i++){
    fetchPokemon(i);
}

console.log('end program');
