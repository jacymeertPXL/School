class InputError extends Error {
    constructor(message) {
        super(message);
        this.name = "InputError";
    }
}

class Vec {
    constructor(x, y) {
        if (typeof x !== "number" || typeof y !== "number") {
            throw new InputError("x en y moeten numbers zijn");
        }
        this.x = x;
        this.y = y;
    }

    plus(other) {
        if (!(other instanceof Vec)) {
            throw new InputError("Input is not a Vec object");
        }
        return new Vec(this.x + other.x, this.y + other.y);
    }

    minus(other) {
        if (!(other instanceof Vec)) {
            throw new InputError("Input is not a Vec object");
        }
        return new Vec(this.x - other.x, this.y - other.y);
    }

    get length() {
        return Math.sqrt(this.x * this.x + this.y * this.y);
    }

    toString() {
        return (`${this.x},${this.y}`);
    }
}

// Testing
try {
    const vec1 = new Vec(1, 2);
    const vec2 = new Vec(3, 4);
    console.log(vec1.plus(vec2).toString()); // (4,6)
    console.log(vec1.minus(vec2).toString()); // (-2,-2)
    console.log(vec1.length); // 2.23606797749979
    console.log(vec2.length); // 5
    const vec3 = new Vec("a", 2);
} catch (error) {
    console.error(error);
}
