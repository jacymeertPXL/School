Als je de gegevens wilt splitsen op elk nummer of elk uitroepteken (!), kun je de `re` (regular expression) module van Python gebruiken. Hier is hoe je de `split_apartment_data`-functie kunt aanpassen om op elk nummer of elk uitroepteken te splitsen

 ````python
 import re

def split_apartment_data(apartment):
    components = re.split(r'\d+|!', apartment)
    components = [comp.strip() for comp in components if comp.strip()]
    
    residence = components[0]
    stars = components[1]
    apartment_type = components[2]
    opp_index = components.index("opp:")

    opp = components[opp_index + 1]
    if "balkon" in components:
        balkon = "Ja"
        afstand_index = components.index("afstand:")
    else:
        balkon = "Nee"
        afstand_index = components.index("afstand:") - 1

    afstand = components[afstand_index + 1]
    prijs_index = components.index("prijs")
    prijs = components[prijs_index + 1]
    
    return {
        "residence": residence,
        "stars": stars,
        "apartment_type": apartment_type,
        "opp": opp,
        "balkon": balkon,
        "afstand": afstand,
        "prijs": prijs
    }

for apartment in apartment_list:
    data = split_apartment_data(apartment)
    print("Residence:", data["residence"])
    print("Stars:", data["stars"])
    print("Apartment Type:", data["apartment_type"])
    print("Oppervlakte:", data["opp"])
    print("Balkon:", data["balkon"])
    print("Afstand:", data["afstand"])
    print("Prijs:", data["prijs"])
    print("-------------------")

````

In dit voorbeeld gebruiken we de `re.split()`-functie van de `re`-module om de tekst te splitsen op elk nummer of elk uitroepteken (!). De `r'\d+|!'` reguliere expressie betekent dat we splitsen op elke reeks opeenvolgende cijfers (`\d+`) of elk uitroepteken (`!`). Daarna verwijderen we eventuele lege en overbodige spaties en splitsen we de tekst in de vereiste componenten voor elk appartement.

#Python