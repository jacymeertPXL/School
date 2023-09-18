let person = {
    _firstname: 'tim',
    _lastname: 'vandenbroek',
    _dateBirth: new Date(2000, 04, 22),
    print: function() {
        console.log(`name: ${this._firstname} lastname: ${this._lastname}, birthdate: ${this.berekenLeeftijd()}`);
    },
    berekenLeeftijd: function() {
        return Math.floor((Date.now() - this._dateBirth) / 1000 / 60 / 60 / 24 / 365);
    }
};

console.log(person.berekenLeeftijd());
console.log(person.print());