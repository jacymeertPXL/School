function functie(){
    let tekst;
    let aantallijnen = 7;

    for (i = 1; i <= aantalLijnen; i++) {
        for(teller = 0; teller <= i; teller++){
            tekst += "#"
        }

        // Voeg een nieuwe regel toe na elke lijn
        tekst += "\n";
    }

    let driehoek = document.createElement("p");
    driehoek.textContent = tekst;
    document.body.appendChild(driehoek);
}