//naam: Buyst Xander
//let op: in de opgave is er 1x sprake van de klasse Spaarrekening. Deze klasse moet niet aangemaakt worden.
'use strict';

class Bankrekening {
    constructor(rekeningnummer, saldo, klantnummer) {
        this.rekeningnummer = rekeningnummer;
        this.saldo = saldo;
        this.klantnummer = klantnummer;
    }

    set rekeningnummer(value) {
        if (Bankrekening.controleerRekeningnummer(value)) {
            this._rekeningnummer = value;
        } else {
            throw new RekeningError("Dit is geen juist rekeningnummer");
        }
    }
    set saldo(value) {
        if (Number.isInteger(value) && value >= 0) {
            this._saldo = value;
        } else {
            throw new RekeningError("Het bedrag moet een positief getal zijn");
        }
    }
    set klantnummer(value) {
        this._klantnummer = value;
    }
    get rekeningnummer() {
        return this._rekeningnummer;
    }
    get saldo() {
        return this._saldo;
    }
    get klantnummer() {
        return this._klantnummer;
    }

    wijzigSaldo(getal) {
        if (Number.isInteger(getal)) {
            if (this._saldo + getal >= 0) {
                this._saldo += getal;
            } else {
                throw new RekeningError("Saldo is ontoereikend");
            }
        } else {
            throw new RekeningError("Enkel getallen meegeven");
        }
    }

    overschrijving(rekeningnummer, bedrag) {
        if (Bankrekening.controleerRekeningnummer(rekeningnummer)) {
            let negatiefBedrag = 0 - bedrag;
            this.wijzigSaldo(negatiefBedrag);
            rekeningnummer.wijzigSaldo(bedrag);
        } else {
            throw new RekeningError("Dit is geen juist rekeningnummer");
        }
    }

    static controleerRekeningnummer(rekeningnummer) {
        if (typeof rekeningnummer == "string" && (/[A-Z]/.test(rekeningnummer.charAt(0)) && /[A-Z]/.test(rekeningnummer.charAt(1)))) {
            let nummers = rekeningnummer.slice(4, 14);
            Number.parseInt(nummers);
            let eindNummers = rekeningnummer.slice(14);
            Number.parseInt(eindNummers);
            if (nummers % 97 == eindNummers) {
                return true;
            } else {
                return false;
            }
        } else {
            throw new RekeningError("Landcode is niet juist");
        }
    }
}

class Zichtrekening extends Bankrekening {
    constructor(rekeningnummer, saldo, klantnummer, limiet) {
        super(rekeningnummer, saldo, klantnummer);
        this.limiet = limiet;
    }

    set rekeningnummer(value) {
        if (Bankrekening.controleerRekeningnummer(value)) {
            this._rekeningnummer = value;
        } else {
            throw new RekeningError("Dit is geen juist rekeningnummer");
        }
    }
    set saldo(value) {
        if (Number.isInteger(value) && value >= 0) {
            this._saldo = value;
        } else {
            throw new RekeningError("Het bedrag moet een positief getal zijn");
        }
    }
    set klantnummer(value) {
        this._klantnummer = value;
    }
    set limiet(value) {
        if (value == null) {
            this._limiet = 1500;
        } else if (value >= 500) {
            this._limiet = value;
        } else {
            throw new RekeningError("Te kleine limiet");
        }
    }
    get rekeningnummer() {
        return this._rekeningnummer;
    }
    get saldo() {
        return this._saldo;
    }
    get klantnummer() {
        return this._klantnummer;
    }
    get limiet() {
        return this._limiet;
    }

    overschrijving(rekeningnummer, bedrag) {
        if (bedrag < this._limiet) {
            let negatiefBedrag = 0 - bedrag;
            this.wijzigSaldo(negatiefBedrag);
            rekeningnummer.wijzigSaldo(bedrag);
        } else {
            throw new RekeningError("Te groot bedrag");
        }
    }
}

class Persoon {
    constructor(naamVoornaam, klantnummer) {
        this.naamVoornaam = naamVoornaam;
        this.klantnummer = klantnummer;
        this._arrayRekeningen = [];
    }

    set naamVoornaam(value) {
        this._naamVoornaam = value;
    }
    set klantnummer(value) {
        this._klantnummer = value
    }
    get naamVoornaam() {
        return this._naamVoornaam;
    }
    get klantnummer() {
        return this._klantnummer;
    }
    get arrayRekeningen() {
        return this._arrayRekeningen;
    }

    voegRekeningToe(bankRekening) {
        if (!(typeof bankRekening == "object" && bankRekening instanceof Bankrekening)) {
            throw new RekeningError("Dit is geen rekening");
        } else if (bankRekening.klantnummer != this.klantnummer) {
            throw new RekeningError("Deze rekening is niet van deze klant");
        } else {
            this._arrayRekeningen.push(bankRekening);
        }
    }
};

class RekeningError extends Error {

}

//testcode
try {
    let persoon1 = new Persoon('DerkoningenCarine', 4567);
    let persoon2 = new Persoon('WillekensJan', 1234);
    let persoon3 = new Persoon('DoumenLuc', 3698);
    let zichtrekening1 = new Zichtrekening('BE12564897128940', 0, 4567);
    let zichtrekening2 = new Zichtrekening('BE96369852147031', 50, 1234);
    let zichtrekening3 = new Zichtrekening('BE56741258963077', 500, 3698);

    persoon1.voegRekeningToe(zichtrekening1);
    persoon2.voegRekeningToe(zichtrekening2);
    persoon3.voegRekeningToe(zichtrekening3);

    zichtrekening3.overschrijving(zichtrekening1, 250);
} catch (ex) {
    console.log(ex);
}

   //errors genereren
    //let rekening = new Bankrekening('BE12564897128920',0,4567) //Rekeningerror: Dit is geen juist rekeningnummer
    //persoon1.voegRekeningToe(zichtrekening3); //Rekeningerror: Deze rekening is niet van deze klant
    //zichtrekening2.overschrijving(zichtrekening3,100);//Rekeningerror: Saldo is ontoereikend
