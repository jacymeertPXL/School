let game = { // aanmaken van object
    naam: 'Meert',
    voornaam: 'Jacy',
    telefoonnummer: '04 22 22 22',
    geboortedatum: '18-08-2003',
    mailadres: '12200178@student.pxl.be',
    Lengte: '175 cm',
    Gewicht: ' xx kg',
    Leeftijd: 20,
    Huidskleur: 'blank',
    Oogkleur: 'groen - bruin',
    zinvorm_Tostring: function(){
        return this.voornaam + ' - ' + this.naam + this.telefoonnummer + ' - ' + this.geboortedatum + this.mailadres;
    }
    // prijs: getGamePrice(0),
    // pegi: { leeftijf: 18, inhoud: 'rage'},
};

// manier om door een object te loopen
// value is neit nodig hier ja kan drek key afdrukken
Object.keys(game).forEach(keys => {
    let value = game[keys];
    console.log(`Key: ${keys}, Value: ${value}`);
})

// array maken met object
let array = Object.keys(game).map((key) => [key, game[key]]);
console.log(array);

