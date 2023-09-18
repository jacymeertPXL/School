'use strict'
class InputError extends Error {}

class vector {
    constructor(x, y) {
        if (typeof x != 'number' || typeof y != 'number') {
            throw new InputError("not a number");
        }
        this.x = x;
        this.y = y;
    }
    set x(x) {
        this._x = x;
    }
    set y(y) {
        this._y = y;
    }
    get x() {
        return this._x;
    }
    get y() {
        return this._y;
    }
    get length() {
        return Math.sqrt(this._x * this._x + this._y * this._y);
    }
    minus(vec) {
        if (typeof vec != 'object' || !vec instanceof vector) {
            throw new InputError("not a vector");
        }
        return new vector(this._x - vec.x, this._y - vec.y);
    }
    plus(vec) {
        if (typeof vec != 'object' || !vec instanceof vector) {
            throw new InputError("not a vector");
        }
        return new vector(this._x + vec.x, this._y + vec.y);
    }
    toString() {
        return `(${this._x},${this._y})`;
    }
};

try {
    let vector1 = new vector(11, 15);
    let vector2 = new vector(6, 3);
    console.log(vector1.toString());
    let vector3 = vector1.minus(vector2);
    console.log(vector3.toString());
    vector3 = vector1.plus(vector2)
    console.log(vector3.toString());
} catch (error) {
    if (error instanceof InputError) {
        console.log(`InputError: ${error.message}`);
    }
}

try {
    let vector1 = new vector("15", "abc");
    let vector2 = new vector(6, 3);
    console.log(vector1.toString());
    let vector3 = vector1.minus(vector2);
    console.log(vector3.toString());
    vector3 = vector1.plus(vector2)
    console.log(vector3.toString());
} catch (error) {
    if (error instanceof InputError) {
        console.log(`InputError: ${error.message}`);
    }
}

try {
    let vector1 = new vector(11, 15);
    let vector2 = new vector(6, 3);
    console.log(vector1.toString());
    let vector3 = vector1.minus("abc");
    console.log(vector3.toString());
    vector3 = vector1.plus(vector2)
    console.log(vector3.toString());
} catch (error) {
    if (error instanceof InputError) {
        console.log(`InputError: ${error.message}`);
    }
}