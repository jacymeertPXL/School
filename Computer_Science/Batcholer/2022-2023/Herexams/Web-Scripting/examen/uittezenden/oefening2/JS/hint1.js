'use strict';
// de ### moeten vervangen worden door code, omdat dit script werkt
function hint(){
fetch("http://localhost:3000/wandelingen/")
    .then((response) => {
        if (response.ok) {
            return response.json();
        } else {
            throw `error with status ${response.status}`;
        }
    })
    .then((wandelingen)=> {

        for(let wandeling of wandelingen){
            console.log(###, ###, ###, ###);
        }
        let keys = Object.keys(###);
        console.log(keys);



    })
    .catch((error)=>{
        console.log(error.message);
    })
}

hint();