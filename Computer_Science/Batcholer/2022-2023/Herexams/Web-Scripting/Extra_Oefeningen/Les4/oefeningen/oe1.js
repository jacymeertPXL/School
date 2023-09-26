const MOUNTAINS = [
    { name: "Kilimanjaro", height: 5895, place: "Tanzania" },
    { name: "Everest", height: 8848, place: "Nepal" },
    { name: "Mount Fuji", height: 3776, place: "Japan" },
    { name: "Vaalserberg", height: 323, place: "Netherlands" },
    { name: "Denali", height: 6168, place: "United States" },
    { name: "Popocatepetl", height: 5465, place: "Mexico" },
    { name: "Mont Blanc", height: 4808, place: "Italy/France" }
];
let output_var = document.getElementsByTagName("output")[0];
let table_tag = document.createElement("table");
let tr_tag_head = document.createElement("tr");
table_tag.appendChild(tr_tag_head);
let array_names = Object.getOwnPropertyNames(MOUNTAINS[0]);

for (item of array_names) {
    let th_tag_head = document.createElement("th");
    let th_textNode = document.createTextNode(item);
    th_tag_head.appendChild(th_textNode);
    tr_tag_head.appendChild(th_tag_head);
}

for (itemMoun of MOUNTAINS) {
    tr_tag_body = document.createElement("tr");
    table_tag.appendChild(tr_tag_body);
    let td_tag_body = document.createElement("td");
    let td_textNode = document.createTextNode(itemMoun.name);
    td_tag_body.appendChild(td_textNode);
    tr_tag_body.appendChild(td_tag_body);
    td_tag_body = document.createElement("td");
    td_textNode = document.createTextNode(itemMoun.height);
    td_tag_body.appendChild(td_textNode);
    tr_tag_body.appendChild(td_tag_body);
    td_tag_body = document.createElement("td");
    td_textNode = document.createTextNode(itemMoun.place);
    td_tag_body.appendChild(td_textNode);
    tr_tag_body.appendChild(td_tag_body);
}

output_var.appendChild(table_tag);