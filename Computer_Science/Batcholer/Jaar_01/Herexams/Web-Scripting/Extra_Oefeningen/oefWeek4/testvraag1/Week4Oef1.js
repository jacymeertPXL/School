weekdagen = ["Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag"]
let body_var = document.body;
let ul_tag = document.createElement("ul");
for (weekdag of weekdagen) {
    let li_tag = document.createElement("li");
    let li_textNode = document.createTextNode(weekdag);
    li_tag.appendChild(li_textNode);
    ul_tag.appendChild(li_tag);
}
body_var.appendChild(ul_tag);