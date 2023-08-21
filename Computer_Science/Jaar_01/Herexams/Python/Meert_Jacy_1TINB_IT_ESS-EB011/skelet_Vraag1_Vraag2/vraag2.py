def bepaal_letterwaarde(woord):
    char_array = ["A", "I", "N", "M", "P","O", "W", "U", "E", "S", "J", "T", "Z", "G", "R", "L", "D"]
    nummer_array = [-8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8]
    for char in woord:
        if char.upper() in [char.upper() for char in char_array]:
            index = [char.lower() for char in char_array].index(woord.upper())
            return letterwaarde += char_array.index(index)+ " , " + nummer_array.index(index)
        else:
            return letterwaarde == "Geen correcte letterreeks"
def bepaal_woordwaarde(woord, letterreeks):
    char_array = ["A", "I", "N", "M", "P", "O", "W", "U", "E", "S", "J", "T", "Z", "G", "R", "L", "D"]
    nummer_array = [-8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8]
    for char in woord:
        if char.upper() in [char.upper() for char in char_array]:
            index = [char.lower() for char in char_array].index(woord.upper())
            return letterwaarde += nummer_array.index(index)
        else:
            return letterwaarde = "Geen correcte letterreeks"

def is_woordwaarde_in_stijgende_volgorde(lijst , letterreeks):
    char_array = ["A", "I", "N", "M", "P", "O", "W", "U", "E", "S", "J", "T", "Z", "G", "R", "L", "D"]
    nummer_array = [-8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8]

    componets = lijst.split()
    woord = componets[0]
    woord2 = componets[1]
    woord3 = componets[2]

    for char in woord:
        if char.upper() in [char.upper() for char in char_array]:
            index = [char.lower() for char in char_array].index(woord.upper())
            optelling += nummer_array.index(index)
        else:
            return letterwaarde = "Geen correcte letterreeks"

    for char in woord2:
        if char.upper() in [char.upper() for char in char_array]:
            index2 = [char.lower() for char in char_array].index(woord2.upper())
            optelling2 += nummer_array.index(index2)
        else:
            return letterwaarde = "Geen correcte letterreeks"

    for char in woord3:
        if char.upper() in [char.upper() for char in char_array]:
            index3 = [char.lower() for char in char_array].index(woord3.upper())
            optelling3 += nummer_array.index(index3)
        else:
            return letterwaarde = "Geen correcte letterreeks"

    if optelling > optelling2 > optelling3:
        return true
    else:
        return false
def rangschik(lijst, letterreeks):
    char_array = ["A", "I", "N", "M", "P", "O", "W", "U", "E", "S", "J", "T", "Z", "G", "R", "L", "D"]
    nummer_array = [-8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8]

    for i in lijst:
        for char in lijst.index(i):
            if char.upper() in [char.upper() for char in char_array]:
                index = [char.lower() for char in char_array].index(lijst.index(i).upper())
                return letterwaarde += nummer_array.index(index)
            else:
                return letterwaarde = "Geen correcte letterreeks"


def main():
    print("BEPAAL LETTERWAARDE: ")
    print(bepaal_letterwaarde("AINMP"))
    print(bepaal_letterwaarde("ainmp"))
    print(bepaal_letterwaarde("AINMPB"))
    print(bepaal_letterwaarde("AINMPB_"))

    print("\nBEPAAL WOORDWAARDE: ")
    print(bepaal_woordwaarde("Polen", "AINMPOWUESJTZGRLD"))         # -6
    print(bepaal_woordwaarde("spanje", "AINMPOWUESJTZGRLD"))        # -15
    print(bepaal_woordwaarde("RUSLAND", "AINMPOWUESJTZGRLD"))       # 7
    print(bepaal_woordwaarde("Duitsland", "AINMPOWUESJTZGRLD"))     # 5
    print(bepaal_woordwaarde("Belgie", "AINMPOWUESJTZGRLD"))        # letter B niet in lijst
    print(bepaal_woordwaarde("Nederland", "AINMPOWUESJTZGRLD"))     # 9
    print(bepaal_woordwaarde("Oostenrijk", "AINMPOWUESJTZGRLD"))    # letter K niet in lijst
    print(bepaal_woordwaarde("Italie", "AINMPOWUESJTZGRLD"))        # -12
    print(bepaal_woordwaarde("Zwitserland", "AINMPOWUESJTZGRLD"))   # 6
    print(bepaal_woordwaarde("Zwitserland", "AINMpowuesjTZGRLD"))  # 6
    print(bepaal_woordwaarde("Zwitserland", "AINMPOWUESJTZGRLDB"))  # geen correcte letterreeks
    print(bepaal_woordwaarde("Zwitserland", "AINMPOWUESJTZGRLD_"))  # geen correcte letterreeks

    print("\nIS WOORDWAARDE IN STIJGENDE VOLGORDE?")
    print(is_woordwaarde_in_stijgende_volgorde(["Duitsland", "Zwitserland", "RUSLAND"], "AINMPOWUESJTZGRLD"))    # True
    print(is_woordwaarde_in_stijgende_volgorde(["Duitsland", "Nederland", "Zwitserland"], "AINMPOWUESJTZGRLD"))  # False
    print(is_woordwaarde_in_stijgende_volgorde(["Duitsland", "ZwQserland", "RUSLAND"], "AINMPOWUESJTZGRLD"))     # letter Q niet in letterreeks
    print(is_woordwaarde_in_stijgende_volgorde(["Duitsland", "Nederland", "Zwitserland"], "AINMPOWUESJTZGRLDB")) # geen correcte letterreeks
    print(is_woordwaarde_in_stijgende_volgorde(["Duitsland", "Nederland", "Zwitserland"], "AINMPOWUESJTZGRL_"))  # geen correcte letterreeks

    print("\nRANGSCHIK:")
    print(rangschik(["Duitsland", "Frankrijk", "RUSLAND", "Italie", "Nederland", "Zwitserland", "Polen"], "AINMPOWUESJTZGRLD"))
    print(rangschik(["Duitsland", "spanje", "RUSLAND", "Italie", "Nederland", "Zwitserland", "Polen"], "AINMPOWUESJTZGRLD"))
    print(rangschik(["Duitsland", "spanje", "RUSLAND", "Italie", "Nederland", "Zwitserland", "Polen"], "AINMPOWUESJTZGRLDB")) # geen correcte letterreeks

if __name__ == '__main__':
    main()
