class Account {
    constructor(landcode, banknummer, nummer) {
        this.landcode = landcode;
        this.banknummer = banknummer;
        this.nummer = nummer;
        this.saldo = 0;
    }

    berekenControleGetal() {
        const nummerBigInt = BigInt(this.nummer);
        const controleGetal = 98n - nummerBigInt * 100n % 97n;
        return controleGetal.toString().padStart(2, '0');
    }

    print() {
        console.log(`${this.landcode} ${this.banknummer} ${this.nummer} ${this.berekenControleGetal()}`);
    }

    stortBedrag(bedrag) {
        this.saldo += bedrag;
    }

    haalBedragAf(bedrag) {
        if (this.saldo < bedrag) {
            console.log("Onvoldoende saldo L.");
            return;
        }
        this.saldo -= bedrag;
    }
}

// Voorbeeldgebruik
const account = new Account("BE", "76", "0012557909");
account.print(); // BE 76 0012557909 95

account.stortBedrag(1000);
console.log(account.saldo); // 1000

account.haalBedragAf(500);
console.log(account.saldo); // 500

account.haalBedragAf(1000); // Onvoldoende saldo

