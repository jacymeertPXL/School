class Account {
    constructor(landcode, banknummer, uniekNummer) {
        this.landcode = landcode;
        this.banknummer = banknummer;
        this.uniekNummer = uniekNummer;
    }

    berekenControleGetal() {
        const eerste10 = this.landcode + this.banknummer + this.uniekNummer;
        const eerste9 = eerste10.slice(0, -2);
        const controlegetal = 97 - (eerste9 % 97);
        return controlegetal.toString().padStart(2, '0');
    }

    print() {
        console.log(`${this.landcode} ${this.banknummer} ${this.uniekNummer} ${this.berekenControleGetal()}`);
    }
}

const account = new Account('BE', '76', '0012557909');
account.print(); // output: BE 76 0012557909 95
