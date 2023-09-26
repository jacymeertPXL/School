def haal_vertrektijd_in_minuten_uit_string(reistijd):
    components = reistijd.split()
    vertrektijd = components[0] + "," + components[1]
    vertrektijd_in_minuten = int(vertrektijd)
    return vertrektijd_in_minuten


def haal_aankomsttijd_in_minuten_uit_string(reistijd):
    components = reistijd.split()
    aankomsttijd = components[2] + "," + components[3]
    aankomsttijd_in_minuten = int(aankomsttijd)
    return aankomsttijd_in_minuten


def vertraging_berekenen(vertrektijd, aankomsttijd, vertraging):
    if aankomsttijd > vertrektijd:
        verschill = aankomsttijd - vertrektijd

    vertrektijd = vertrektijd + (vertraging - verschill / 100)
    aankomsttijd = aankomsttijd + (vertraging - verschill / 100)
    return aankomsttijd

def main():
    bestemming = ""
    while bestemming != "S" or bestemming != "Stop":
        bestemming = str(input("typ 'S' of 'Stop' om te stoppen"))
        vertraging = int(input("Geef de vertraging in minuten:"))
        aantal_treinritten = int(input("Geef het aantal treinritten:"))
        for i in range(1, aantal_treinritten + 1):
            reistijd = str(input("Geef de reistijd trein"))
            vertrektijd = haal_vertrektijd_in_minuten_uit_string(reistijd)
            aankomsttijd = haal_aankomsttijd_in_minuten_uit_string(reistijd)
            aankomsttijd_laaste_trein = vertraging_berekenen(vertrektijd, aankomsttijd, vertraging)
        print("De aankomsttijd van de laaste trein is" + aankomsttijd_laaste_trein)

if __name__ == '__main__':
    main()