let vakken = new Array("Web", "C#", "Com Skills", "Org");
let tekst;

function toonarray() {

    vakken.push(" Bachelor Multimedia", "Commmunicatietechnologie ");

    for (i = 0; i < vakken.length; i++) {
        console.log(vakken[i]);
    }

    console.log(vakken.length);
}