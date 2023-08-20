/*
const persoon = {
    voornaam: 'Jacy',
    naam: 'Meert',
    geboortedatum: new Date('2003-08-18'),

    berekenLeeftijd() {
    const vandaag = new Date();
    const geboortejaar = this.geboortedatum.getFullYear();
    const huidigJaar = vandaag.getFullYear();
    return huidigJaar - geboortejaar - 1;
},

print() {
    console.log(`${this.naam} ${this.voornaam} (${this.berekenLeeftijd()} jaar)`);
}
}

persoon.print();
*/

let persoon = {
    naam: "jacy",
    voornaam: "meert",
    geboortedatum: new Date("2003-08-18"),

    berekenleeftijd: function() {
        let huidigeDatum = new Date();
        let geboortejaar = this.geboortedatum.getFullYear();
        let huidigJaar = huidigeDatum.getFullYear();
        let leeftijd = huidigJaar - geboortejaar;
        if (huidigeDatum < new Date(huidigJaar, this.geboortedatum.getMonth(), this.geboortedatum.getDate())) {
            leeftijd--;
        }
        return leeftijd;
    },

    print: function() {
        console.log(this.voornaam + " " + this.naam + " is " + this.berekenleeftijd() + " jaar oud.");
    }
};

persoon.print();
