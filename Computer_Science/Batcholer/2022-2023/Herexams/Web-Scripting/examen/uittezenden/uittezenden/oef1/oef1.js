class Produkt {
    constructor(_naam, _prijs) {
        if (!Number.isInteger(_prijs) || _prijs <= 0) {
            throw new Error('Foutieve ingave voor prijs');
        }
        if (typeof _naam !== 'string' || _naam.length > 2) {
            throw new Error('Foutieve ingave voor naam');
        }
        this._naam = _naam;
        this._prijs = _prijs;
    }
    get prijs() {
        return this._prijs;
    }
    get naam() {
        return this._naam;
    }
    set naam(value) {
        this._naam = value;
    }
    set prijs(value) {
        this._prijs = value;
    }
}

class Bestellingsonderdeel extends Produkt {
    // Inherits properties and methods from Produkt
}

class Aankoop extends Bestellingsonderdeel {
    constructor(_aantal, _produkt) {
        super(_produkt.naam, _produkt.prijs);
        if (!Number.isInteger(_aantal) || _aantal <= 0) {
            throw new Error('Foutieve ingave voor aantal');
        }
        this._aantal = _aantal;
        this._produkt = _produkt;
    }
    get aantal() {
        return this._aantal;
    }
    get produkt() {
        return this._produkt;
    }
    set produkt(value) {
        this._produkt = value;
    }
    set aantal(value) {
        this._aantal = value;
    }
}

class ProcentueleKorting extends Bestellingsonderdeel {
    constructor(_kortingProcent) {
        super("", 0);
        if (!Number.isInteger(_kortingProcent) || _kortingProcent < 0 || _kortingProcent > 100) {
            throw new Error('Invalid korting percentage');
        }
        this._kortingProcent = _kortingProcent;
    }
    set kortingProcent(value) {
        this._kortingProcent = value;
    }
}

class Bestelling extends Bestellingsonderdeel {
    constructor() {
        super("", 0);
        this._Bestellingsonderdeel = [];
    }

    voegToe(_Bestellingsonderdeel) {
        if (!(_Bestellingsonderdeel instanceof Bestellingsonderdeel)) {
            throw new Error('Foutieve ingave voor Bestellingsonderdeel');
        }
        this._Bestellingsonderdeel.push(_Bestellingsonderdeel);
    }

    berekenPrijs() {
        let totaleKorting = 0;
        for (const _Bestellingsonderdeel of this._Bestellingsonderdeel) {
            if (_Bestellingsonderdeel instanceof ProcentueleKorting) {
                totaleKorting += _Bestellingsonderdeel.kortingProcent;
            }
        }
        const aantal = this._Bestellingsonderdeel.filter(item => item instanceof Aankoop).reduce((acc, curr) => acc + curr.aantal, 0);
        const prijs = this._Bestellingsonderdeel.filter(item => item instanceof Aankoop).reduce((acc, curr) => acc + (curr.produkt.prijs * curr.aantal), 0);
        let totalePrijs = prijs;
        let resultaat = totalePrijs * (1 - totaleKorting / 100);
        if (resultaat <= 0) {
            resultaat = 0;
        }
        return resultaat;
    }
}

// Create instances of the classes
let produkt1 = new Produkt("krant", 3.55);
let produkt2 = new Produkt("snoep", 2.33);
let bestelling = new Bestelling();
let bestellingsonderdeel1 = new Aankoop(2, produkt1);
let bestellingsonderdeel2 = new Aankoop(14, produkt2);
let bestellingsonderdeel3 = new ProcentueleKorting(22);
let bestellingsonderdeel4 = new ProcentueleKorting(11);

bestelling.voegToe(bestellingsonderdeel1);
bestelling.voegToe(bestellingsonderdeel2);
bestelling.voegToe(bestellingsonderdeel3);
bestelling.voegToe(bestellingsonderdeel4);

// Calculate and print the total price of the order
console.log(bestelling.berekenPrijs());
