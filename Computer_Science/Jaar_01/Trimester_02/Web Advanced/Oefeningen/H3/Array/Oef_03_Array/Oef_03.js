let vakken = new Array("Web", "C#", "Com Skills", "Org");
let tekst;

function toonarray() {

    vakken.push("Bachelor Multimedia", "Commmunicatietechnologie ");

    for (i = 0; i < vakken.length; i++) {
        tekst += vakken[i].toString();
        tekst += "\n";
    }

    console.log(tekst)
    console.log(vakken.length);
}