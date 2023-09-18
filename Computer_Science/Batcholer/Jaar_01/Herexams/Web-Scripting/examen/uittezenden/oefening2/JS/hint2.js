'use strict'

function hint(){
    fetch(`http://localhost:3000/wandelingen/?datum=###`)
        .then((response) => {
            if (response.ok) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((wandelingen)=> {

            for( let wandeling of wandelingen){
                console.log(###, ###)
            }

        })
        .catch((error)=>{
            console.log(error.message);
        })

}
hint();