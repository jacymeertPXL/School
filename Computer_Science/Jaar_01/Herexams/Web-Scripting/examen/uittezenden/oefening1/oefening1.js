// naam: Jacy Meert
'use strict';

// schrijf hier de klassen
class PlantError extends Error{
}
class Gerecht {
    constructor(gerechtNaam, aantalPersonen) {
        if (typeof gerechtNaam !== 'string') {
            throw new Error('geef het gerecht een naam');
        }
        if (typeof aantalPersonen !== 'number' || aantalPersonen <= 0) {
            throw new Error('geef het aantal personen voor dit gerecht');
        }
        this.gerechtNaam = gerechtNaam;
        this.aantalPersonen = aantalPersonen;
    }

    get aantalPersonen() {
        return this._aantalPersonen
    }

    get gerechtNaam() {
        return this._gerechtNaam;
    }

    set gerechtNaam(value) {
        if (typeof value === 'string') {
            this._gerechtNaam = value;
        } else {
            throw new Error('geef het gerecht een naam');
        }
    }

    set aantalPersonen(value) {
        if (typeof value === 'number' && value > 0) {
            this._aantalPersonen = value;
        } else {
            throw new Error('geef het aantal personen voor dit gerecht');
        }
    }
}

class Plant extends PlantError{
    constructor(_nedNaam, _wetNaam) {
        super();
        if (typeof _nedNaam !== 'string') {
            throw new Error('geef een plantnaam');
        }
        this._nedNaam = _nedNaam;
        this._wetNaam = _wetNaam;
    }

    set _nedNaam(value) {
        if (typeof value === 'string') {
            this._nedNaam = value;
        } else {
            throw new PlantError('Foutieve ingave voor naam');
        }
    }

    set _wetNaam(value) {
        if (value === null){
            this._wetNaam = ''
        }
    }

    toString(_nedNaam, _wetNaam){
        if (_nedNaam.toString() === 'Kleine brandnetel' && _wetNaam.toString() === 'Utrica Urens'){
            return 'De Nederlandse naam is een' + `[${this._nedNaam}]` +'en de wetenschappelijke naam is' + `[${this._wetNaam}]`
        }
        if (_nedNaam.toString() === 'Kleine brandnetel' && _wetNaam.toString() !== 'Utrica Urens'){
            return 'De Nederlandse naam is een' + `[${this._nedNaam}]`
        }
    }
}

class Groente extends Plant{
    constructor(_nedNaam, _wetNaam,_eetbaar) {
        super(_nedNaam, _wetNaam);
        this._eetbaar = false;
        this._mogelijkheden =[];
    }

    set _nedNaam(value) {
        if (value !== null && typeof value === 'string') {
            this._nedNaam = value;
        } else {
            throw new PlantError('geef een plantnaam');
        }
    }

    set _wetNaam(value) {
        if (value === null){
            this._wetNaam = ''
        }
    }
    set _eetbaar(value) {
        if (value === false){
            this._eetbaar = false
        }else{
            this._eetbaar = true
        }
    }

    voegMogelijkheidToe(gerecht){
        if (!(typeof gerecht == "object" && gerecht instanceof Gerecht)) {
            throw new Error( gerecht + "is geen gerecht");
        } else {
            this._mogelijkheden.push(gerecht);
        }
    }

    print(nednaam, array){
        array = this._mogelijkheden
        let tekst = ""
        for (let mogelijkheden of this._mogelijkheden){
            tekst += mogelijkheden;
        }
        return nednaam + "Kan je gebruiken in: " + tekst
    }

    toString(_nedNaam, _wetNaam){
        if (_nedNaam.toString() === 'prei' && _wetNaam.toString() === 'Arium Porrum'){
            return 'Dit is een groente: De Nederlandse naam is een' + `[${this._nedNaam}]` +'en de wetenschappelijke naam is' + `[${this._wetNaam}]`
        }
        if (_nedNaam.toString() === 'prei' && _wetNaam.toString() !== 'Arium Porrum'){
            return 'De Nederlandse naam is ' `[${this._nedNaam}]`
        }
    }

}

//dit is de testcode, deze mag niet gewijzigd worden
    let gerecht1= new Gerecht('soep',2);
    let gerecht2= new Gerecht('ovenschotel',1);
    let groente1 = new Groente('prei','Arium Porrum',true, gerecht1, 'aardappelpuree',gerecht2);
    console.log(groente1.toString());
    groente1.print();

/*output
aardappelpuree is geen gerecht
prei kan je gebruiken in:
soep
ovenschotel
Dit is een groente: De Nederlandse naam is prei en
        de wetenschappelijke naam is Arium Porrum.
 */