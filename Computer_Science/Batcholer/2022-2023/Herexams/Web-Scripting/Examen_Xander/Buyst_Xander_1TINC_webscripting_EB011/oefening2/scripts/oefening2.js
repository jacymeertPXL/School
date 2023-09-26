//naam: Buyst Xander
'use strict';
let li;

const getActivities = function () {
    return [{ id: 1, name: "Boardgame Night", date: "06/04/2022", time: "18h30", location: "Corda Campus", place: "Hasselt" },
    { id: 2, name: "Lezing: De Mainframe", date: "24/03/2022", time: "19h - 21h45", location: "Hogeschool PXL", place: "Hasselt" },
    { id: 3, name: "Hexilan", date: "18/03/2022", time: "19h", location: "Hogeschool PXL", place: "Hasselt" },
    { id: 4, name: "Hexion Café-Avond Witte Non", date: "08/12/2022", time: "19h30-23h", location: "Café De Witte Non", place: "Hasselt" },
    { id: 5, name: "De Alles-en-Nog-Wat CANTUS", date: "18/04/2022", time: "20h", location: "Europalaan 26", place: "Genk" },
    { id: 6, name: "De Alles-Vergeten CANTUS", date: "25/06/2022", time: "21h", location: "Fitlink", place: "Diepenbeek" }];
}
const sortByDate = function (array) {
    let sortedArray = [];
    //sorteer de objecten in de meegegeven array op datum
    let activity;
    for (let i = 0; i < sortedArray.length; i++) {
        for (let j = 0; j < sortedArray.length; j++) {
            if (Date.parse(sortedArray[j]) < Date.parse(sortedArray[j + 1])){
                activity = sortedArray[j];
                sortedArray[j] = sortedArray[j + 1];
                sortedArray[j + 1] = activity;
            }
        }
    }
    return sortedArray;
}

const handleLoad = function () {
    let url = 'http://localhost:3000/activities/';
    let fieldset = document.getElementsByTagName("fieldset")[0];
    let ul

    fetch(url)
        .then((response) => {
            if (response.status == 200) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((activities) => {
            ul = document.createElement("ul");
            li;
            let a;
            let a_content;
            let dateDiv;
            let dateDiv_content;
            let today = new Date();

            for (activity of activities) {
                li = document.createElement("li");
                ul.appendChild(li);
                a = document.createElement("a");
                //a = document.createAttribute("href=\"https://pxl.be\"");
                a_content = document.createTextNode(activity.name);
                a.appendChild(a_content);
                li.appendChild(a);
                if (Date.parse(activity.date) >= today.valueOf()) {
                    dateDiv = document.createElement("div");
                    dateDiv_content = document.createTextNode(activity.date);
                    dateDiv.appendChild(dateDiv_content);
                    li.appendChild(dateDiv);
                }
                //a.addEventListener("click", activityDetails(activity));
            }
            fieldset.appendChild(ul);
        })
        .catch((error) => {
            console.log(error);
            let activities = [];
            let activity;
            activities = getActivities();
            ul = document.createElement("ul");
            li;
            let a;
            let a_content;
            let dateDiv;
            let dateDiv_content;
            let today = new Date();

            for (activity of activities) {
                li = document.createElement("li");
                ul.appendChild(li);
                a = document.createElement("a");
                //a = document.createAttribute("href=\"https://pxl.be\"");
                a_content = document.createTextNode(activity.name);
                a.appendChild(a_content);
                li.appendChild(a);
                if (Date.parse(activity.date) >= today.valueOf()) {
                    dateDiv = document.createElement("div");
                    dateDiv_content = document.createTextNode(activity.date);
                    dateDiv.appendChild(dateDiv_content);
                    li.appendChild(dateDiv);
                }
                //a.addEventListener("click", activityDetails(activity));
            }
            fieldset.appendChild(ul);
        });
}

function activityDetails(activity) {
    let blockquote = document.createElement("blockquote");
    let p = document.createElement("p");
    let p_content;
    li.appendChild(blockquote);

    p_content = document.createTextNode(activity.time);
    p.appendChild(p_content);
    blockquote.appendChild(p);

    p = document.createElement("p");
    p_content = document.createTextNode(activity.location);
    p.appendChild(p_content);
    blockquote.appendChild(p);

    p = document.createElement("p");
    p_content = document.createTextNode(activity.place);
    p.appendChild(p_content);
    if (activity.place != "Hasselt") {
        //p.style.color = "red";
    }
    blockquote.appendChild(p);
}
window.addEventListener('load', handleLoad);

function makeElementEmpty(element) {
    while (element.hasChildNodes()) {
        element.removeChild(element.firstChild);
    }
}