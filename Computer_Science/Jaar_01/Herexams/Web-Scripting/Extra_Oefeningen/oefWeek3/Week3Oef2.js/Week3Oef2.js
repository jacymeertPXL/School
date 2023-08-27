class person {

    constructor(firstname, lastname, dateBirth) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.dateBirth = dateBirth;
    }

    set firstname(firstname) {
        this._firstname = firstname;
    }
    set lastname(lastname) {
        this._lastname = lastname;
    }
    set dateBirth(dateBirth) {
        this._dateBirth = dateBirth;
    }
    get firstname() {
        return this._firstname;
    }
    get lastname() {
        return this._lastname;
    }
    get dateBirth() {
        return this._dateBirth;
    }

    print() {
        console.log(`name: ${this._firstname} lastname: ${this._lastname}, birthday: ${this.berekenLeeftijd()}`);
    }
    berekenLeeftijd() {
        return Math.floor((Date.now() - this._dateBirth) / 1000 / 60 / 60 / 24 / 365);
    }
};

let person1 = new person("Quinten", "Blommen", new Date(2000, 04, 22))

console.log(person1.berekenLeeftijd());
person1.print();