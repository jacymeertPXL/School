function oef03()
{

// veranderen van color van element in html
document.getElementById("red").style.color = "#8B0000";

// eeerst haal je de parent op en via de parent verwijder je de children
let bodydocument = document.getElementById("body");
let verwijdertekst = document.getElementById("weg");

bodydocument.removeChild(verwijdertekst);

// element toevoegen aan body
let asideeElement = document.createElement('aside');

let nieuweParagraaf = document.createElement("p");
nieuweParagraaf.id = "tekst";

let nieuweParagraaf2 = document.createElement("p");

let tekstVoorP = document.createTextNode("Text in de aside");
let tekstVoorP2 = document.createTextNode("Text in de aside 2");

nieuweParagraaf.appendChild(tekstVoorP);
nieuweParagraaf2.appendChild(tekstVoorP2);

// Normale toevoegen
asideeElement.appendChild(nieuweParagraaf);

// steekt dit element voor het elenment dus (nieuweParagraaf2 dit als eerste)
asideeElement.insertBefore(nieuweParagraaf2,document.getElementById("tekst"));

bodydocument.appendChild(asideeElement);

}
