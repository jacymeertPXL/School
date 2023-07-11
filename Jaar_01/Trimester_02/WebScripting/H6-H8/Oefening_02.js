class Persoon {
    constructor(naam, voornaam, geboortedatum) {
        this._naam = naam;
        this._voornaam = voornaam;
        this._geboortedatum = new Date(geboortedatum);
    }

    get naam() {
        return this._naam;
    }

    set naam(naam) {
        this._naam = naam;
    }

    get voornaam() {
        return this._voornaam;
    }

    set voornaam(voornaam) {
        this._voornaam = voornaam;
    }

    get geboortedatum() {
        return this._geboortedatum;
    }

    set geboortedatum(geboortedatum) {
        this._geboortedatum = new Date(geboortedatum);
    }

    berekenleeftijd() {
        let huidigeDatum = new Date();
        let geboortejaar = this.geboortedatum.getFullYear();
        let huidigJaar = huidigeDatum.getFullYear();
        let leeftijd = huidigJaar - geboortejaar;
        if (huidigeDatum < new Date(huidigJaar, this.geboortedatum.getMonth(), this.geboortedatum.getDate())) {
            leeftijd--;
        }
        return leeftijd;
    }

    print() {
        console.log("Naam: " + this.naam);
        console.log("Voornaam: " + this.voornaam);
        console.log("Leeftijd: " + this.berekenleeftijd());
    }
}

let persoon = new Persoon("Jacy", "meert", "2003-08-18");
persoon.print();
