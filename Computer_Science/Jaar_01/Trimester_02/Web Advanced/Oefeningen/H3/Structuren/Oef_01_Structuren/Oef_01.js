function checkleeftijd(){
    let geboortejaar = prompt("wat is je geboortejaar ?");

    let huideigejaar = new Date().getFullYear();
    let leefijtd = huideigejaar - geboortejaar;

    if (leefijtd > 20) {
        alert("Je bent oud genoeg om de informatie op deze webpagina te bekijken.");
    } else {
        alert("Je bent nog te jong om de informatie op deze webpagina te bekijken.");
    }

    window.onload = checkleeftijd;
}