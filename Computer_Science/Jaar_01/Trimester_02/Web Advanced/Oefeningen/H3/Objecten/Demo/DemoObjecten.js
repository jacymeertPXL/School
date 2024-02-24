let game = { // aanmaken van object
    titel: 'League of legends',
    genre: 'Moba',
    id: 3307216169116,
    prijs: getGamePrice(0),
    pegi: { leeftijf: 18, inhoud: 'rage'},
    voledige_titel: function(){
        return this.titel + ' - ' + this.genre;
    }
};

console.log('De naam van deze game is' + game.titel) // Oproepen van object element
console.log(voledige_titel() + ' ' + getGamePrice()) // Oproepen van object functie / get