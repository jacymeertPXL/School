function factorial(number) {
    let promise = new Promise((resolve, reject) => {
        if (typeof number != 'number' || !Number.isInteger(number)) {
            return reject(`${number} is not a number`);
        }
        setTimeout(() => {
                let result = 1;
                for (let i = 1; i <= number; i++) {
                    result = result * i;
                    if (result == Infinity) {
                        return reject(`${number}! is Infinity`);
                    }
                }
                resolve(result);
            }, Math.floor(Math.random() * 10000)
        );
    });
    return promise;
}

function double(number) {
    let promise = new Promise((resolve, reject) => {
        if (!Number.isInteger(number)) {
            return reject(`${number} is not a number`);
        }
        setTimeout(() => {
                let result = 2 * number;
                if (result == Infinity) {
                    return reject(`${number} is not a number`);
                }
                resolve(result);
            }, Math.floor(Math.random() * 10000)
        );
    });
    return promise;
}


factorial(20)
    .then((result) => double(result))
    .then((result) => {
        console.log('resolved: ', result);
    })
    .catch((error) => {
        console.log('rejected: ', error);
    });


