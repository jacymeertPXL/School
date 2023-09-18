const button_click_get_all = () => {
    let url = 'http://localhost:3000/performances';
    let output = document.getElementById("output");
    fetch(url)
        .then((response) => {
            if (response.status == 200) {
                return response.json();
            } else {
                throw `error with status ${response.status}`;
            }
        })
        .then((performances) => {
            let data = [];
            for (let performance of performances) {
                data.push([performance.id, performance.name, performance.play_date, performance.description]);
            }
            let table = makeTable(data);
            output.appendChild(table);
        })
        .catch((error) => {
            output.appendChild(document.createTextNode(error));
        });

}

function makeTable(data) {
    let table = document.createElement("table");
    for (let fest of data) {
        let row = document.createElement("tr");
        table.appendChild(row);
        for (let festdat of fest) {
            let col = document.createElement("td");
            row.appendChild(col);
            let col_textnode = document.createTextNode(festdat);
            col.appendChild(col_textnode);
        }
    }
    return table
}


const handleLoad = () => {
    let button_get_all = document.getElementById("getAll");
    button_get_all.addEventListener("click", button_click_get_all);
}

window.addEventListener("load", handleLoad);