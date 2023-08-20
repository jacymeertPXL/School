 ````python
apartment_list = [
    "Résidence Noeyms **** T0 opp:32 afstand:30  prijs 159",
    "Résidence Noemys **** T0 opp:28 balkon afstand:30 prijs 139",
    "Résidence Noemys **** T1 opp:34 afstand:30  prijs 148",
    "Résidence Noemys **** T3 opp:100 balkon afstand:30 prijs 431",
    "Résidence Noemys **** T1 opp:44 afstand:30 prijs 204",
    # ... andere appartementen hier ...
    "Résidence Pégase ** T0 opp:25 afstand:300 prijs 60"
]

def split_apartment_data(apartment):
    components = apartment.split()
    residence = components[0] + " " + components[1]
    stars = components[2]
    apartment_type = components[3]
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

Dit zal de gesplitste gegevens van elk appartement in de lijst weergeven, met labels voor elk van de eigenschappen zoals residence, aantal sterren, appartementtype, oppervlakte, aanwezigheid van een balkon, afstand en prijs.