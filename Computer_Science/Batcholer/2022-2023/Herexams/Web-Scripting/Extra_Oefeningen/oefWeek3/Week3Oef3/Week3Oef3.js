class person {

    constructor(countyCode, bankNumber, uniqueNumber) {
        this.countyCode = countyCode;
        this.bankNumber = bankNumber;
        this.uniqueNumber = uniqueNumber;
    }

    set countyCode(countyCode) {
        this._countyCode = countyCode;
    }
    set bankNumber(bankNumber) {
        this._bankNumber = bankNumber;
    }
    set uniqueNumber(uniqueNumber) {
        this._uniqueNumber = uniqueNumber;
    }
    get countyCode() {
        return this._countyCode;
    }
    get bankNumber() {
        return this._bankNumber;
    }
    get uniqueNumber() {
        return this._uniqueNumber;
    }

    print() {
        console.log(`${this._countyCode} ${this._bankNumber} ${this._uniqueNumber}${this.calculateCheckNumber()}`);
    }
    calculateCheckNumber() {
        return this._uniqueNumber % 97;
    }
};

let person1 = new person("BE", "76", "0012557909");
person1.print();