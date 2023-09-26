getal1 = int(input("Geef het eerste getal in "))
getal2 = int(input("Geef het tweede getal in "))

if getal1 < getal2:
    print("Het kleinste getal is", getal1)
    print("Het kwadraat van het kleinste getal is", getal1 ** 2)

    if getal1 != 0:
        print("Het grootste getal gedeeld door het kleinste getal is ", getal2 / getal1)
else:
    print("Het kleinste getal is", getal2)
    print("Het kwadraat van het kleinste getal is", getal2 ** 2)

    if getal2 != 0:
        print("Het grootste getal gedeeld door het kleinste getal is ", getal1 / getal2)