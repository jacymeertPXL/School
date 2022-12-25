# Schrijf een programma dat tafels van vermenigvuldiging afdrukt voor de getallen 2 tot 5(incl.).


for i in range(2, 6): ## of gewoon 6 noteren of 5 + 1

    for j in range(1, 11):
        print(j, "x", i, "=", i * j)
    print()


