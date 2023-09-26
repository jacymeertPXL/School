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

factorial(10)
    .then((result) => result * 2)
    .then((result) => {
        console.log('resolved: ', result);
    })
    .catch((error) => {
        console.log('rejected: ', error);
    });
