Als je wilt dat de `%` wordt verwijderd uit de resulterende lijst van componenten na het splitsen, kun je dat doen door elk element in de lijst te doorlopen en de `%` te verwijderen. Hier is hoe je dat kunt doen:

```` python
import re

def split_apartment_data(apartment):
    components = re.split(r'%', apartment)
    components = [comp.strip() for comp in components if comp.strip()]
    
    # Verwijder '%' uit elk component
    components = [comp.replace('%', '') for comp in components]
    
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

In dit voorbeeld gebruiken we een lijstverwerkingsstap 
`components = [comp.replace('%', '') for comp in components]` om elk element in de lijst te nemen en de `%` te verwijderen met behulp van de `replace`-methode. Dit zorgt ervoor dat de `%` uit de componenten wordt verwijderd voordat ze verder worden verwerkt.

#Python