````javascript
class Produkt {  
    constructor(naam, prijs) {  
        if (typeof naam !== 'string' || naam.length <= 2) {  
            throw new Error('Foutieve ingave voor naam');  
        }  
        if (typeof prijs !== 'number' || prijs <= 0) {  
            throw new Error('Foutieve ingave voor prijs');  
        }  
        this._naam = naam;  
        this._prijs = prijs;  
    }  
  
    get prijs() {  
        return this._prijs;  
    }  
  
    get naam() {  
        return this._naam;  
    }  
  
    set naam(value) {  
        if (typeof value === 'string' && value.length > 2) {  
            this._naam = value;  
        } else {  
            throw new Error('Foutieve ingave voor naam');  
        }  
    }  
  
    set prijs(value) {  
        if (typeof value === 'number' && value > 0) {  
            this._prijs = value;  
        } else {  
            throw new Error('Foutieve ingave voor prijs');  
        }  
    }  
}  
  
class Bestellingsonderdeel {  
    constructor() {  
        this.product = null;  
    }  
}  
  
class Aankoop extends Bestellingsonderdeel {  
    constructor(aantal, product) {  
        super();  
        if (!Number.isInteger(aantal) || aantal <= 0) {  
            throw new Error('Foutieve ingave voor aantal');  
        }  
        this._aantal = aantal;  
        this.product = product;  
    }  
  
    get aantal() {  
        return this._aantal;  
    }  
  
    set aantal(value) {  
        if (Number.isInteger(value) && value > 0) {  
            this._aantal = value;  
        } else {  
            throw new Error('Foutieve ingave voor aantal');  
        }  
    }  
  
    berekenPrijs() {  
        return this.aantal * this.product.prijs;  
    }  
}  
  
class ProcentueleKorting extends Bestellingsonderdeel {  
    constructor(kortingProcent) {  
        super();  
        if (typeof kortingProcent !== 'number' || kortingProcent <= 0) {  
            throw new Error('Foutieve ingave voor korting percentage');  
        }  
        this._kortingProcent = kortingProcent;  
    }  
  
    get kortingProcent() {  
        return this._kortingProcent;  
    }  
  
    berekenPrijs(totaalPrijs) {  
        if (typeof totaalPrijs !== 'number' || totaalPrijs <= 0) {  
            throw new Error('Ongeldige totaalprijs');  
        }  
        return -(this.kortingProcent / 100) * totaalPrijs;  
    }  
}  
  
  
class Bestelling extends Bestellingsonderdeel {  
    constructor() {  
        super();  
        this._bestellingsonderdelen = [];  
    }  
  
    voegToe(onderdeel) {  
        this._bestellingsonderdelen.push(onderdeel);  
    }  
  
    berekenPrijs() {  
        let totalePrijs = 0;  
        for (const onderdeel of this._bestellingsonderdelen) {  
            totalePrijs += onderdeel.berekenPrijs(totalePrijs);  
        }  
        return totalePrijs;  
    }  
}  
  
// Voorbeeldgebruik  
const product1 = new Produkt("krant", 3.55);  
const product2 = new Produkt("snoep", 2.33);  
const bestelling = new Bestelling();  
const bestellingsonderdeel1 = new Aankoop(2, product1);  
const bestellingsonderdeel2 = new Aankoop(14, product2);  
const bestellingsonderdeel3 = new ProcentueleKorting(22, bestelling);  
const bestellingsonderdeel4 = new ProcentueleKorting(11, bestelling);  
  
  
bestelling.voegToe(bestellingsonderdeel1);  
bestelling.voegToe(bestellingsonderdeel2);  
bestelling.voegToe(bestellingsonderdeel3);  
bestelling.voegToe(bestellingsonderdeel4);  
  
const totalePrijs = bestelling.berekenPrijs();  
console.log("Totaalprijs van bestelling:", totalePrijs);
`````

Door in de constructor van de superklasse `Bestellingsonderdeel` de eigenschap `this.product` aan te maken en deze te initialiseren met `null`, kunnen de subklassen (`Aankoop` en `ProcentueleKorting`) deze eigenschap gebruiken en toegang krijgen tot het `Product`-object dat aan het bestellingsonderdeel is gekoppeld. Dit stelt de subklassen in staat om berekeningen uit te voeren op basis van de eigenschappen van het product, zoals de naam en prijs.

In de subklassen kun je dan specifieke methoden implementeren om functionaliteit toe te voegen die gebruikmaakt van het `this.product`-object, zoals het berekenen van de prijs voor aankopen of het toepassen van procentuele kortingen op de totaalprijs van de bestelling. Hierdoor wordt de code modulair en kunnen gemeenschappelijke functies en eigenschappen efficiënt worden gedeeld tussen de subklassen.

#Web-Scripting