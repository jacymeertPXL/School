// naam: 

class Persoon {
    constructor(id, naam) {
        this.id = id;
        this.naam = naam;

    }

    set id(value) {
        if (Number.isInteger(value) && value > 0) {
            this._id = value;
        } else {
            throw new error("dit is geen geldige id");
        }

    }

    set naam(value) {
        if (typeof value == "string") {
            this._naam = value;
        } else {
            throw new error("dit is geen geldige naam");
        }
    }

    get id() {
        return this._id;
    }

    get naam() {
        return this._naam;
    }

    toString() {
        return `[${this._id}] ${this._naam}`;
    }
}

class Loonwerker extends Persoon {
    constructor(id, naam, loonPerUur, aantalUrenGewerkt) {
        super(id, naam);
        this.loonPerUur = loonPerUur;
        this.aantalUrenGewerkt = aantalUrenGewerkt;
    }

    set loonPerUur(value) {
        if (Number.isInteger(value) && value > 0) {
            this._loonPerUur = value;
        } else {
            throw new error("dit is geen geldige loon per uur");
        }

    }

    set aantalUrenGewerkt(value) {
        if (Number.isInteger(value) && value > 0) {
            this._aantalUrenGewerkt = value;
        } else {
            throw new error("dit is geen geldige aantal uren gewerkt");
        }

    }

    get loonPerUur() {
        return this._loonPerUur;
    }

    get aantalUrenGewerkt() {
        return this._aantalUrenGewerkt;
    }

    berekenLoon() {
        return this._aantalUrenGewerkt * this._loonPerUur;
    }

    toString() {
        return `${super.toString()} = ${this.berekenLoon()}`;
    }

}

class Manager extends Persoon {
    constructor(id, naam) {
        super(id, naam);
        this._arrayLoonwerkers = [];
    }

    voegLoonWerkerToe(werker) {
        if (typeof werker == "object" && werker instanceof Loonwerker) {
            this._arrayLoonwerkers.push(werker);
        } else {
            throw new error("geen geldig loonwerker object");
        }
    }

    berekenLoon() {
        let loonSom = 0;
        for (let werker of this._arrayLoonwerkers) {
            loonSom += werker.berekenLoon();
        }
        return Math.round(loonSom * 0.2);
    }

    toString() {
        return `${super.toString()} = ${this.berekenLoon()}`;
    }

}

try {

    let persoon = new Persoon(1, "mieke");
    let manager = new Manager(2, "jan");
    let werker1 = new Loonwerker(3, "tim", 11, 13);
    let werker2 = new Loonwerker(4, "sofie", 2, 50);
    manager.voegLoonWerkerToe(werker1);
    manager.voegLoonWerkerToe(werker2);
    console.log(persoon.toString());
    // [1] mieke 
    console.log(werker1.toString());
    // [3] tim = 143
    console.log(werker2.toString());
    // [4] sofie = 100
    console.log(manager.toString());
    // [2] jan = 49
} catch (error) {
    console.log(error.message);
}