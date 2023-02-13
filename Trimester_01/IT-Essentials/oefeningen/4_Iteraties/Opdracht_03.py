aantal_negatiefen = 0
som = 0
getal = int(input("Geef een getal in: "))
while getal != 0:
    som += getal
    if getal < 0:
        aantal_negatiefen += 1
    getal = int(input("Geef een getal in: "))
print("De som van deze getallen is", som)
print("Aantal negatieve getallen:", aantal_negatiefen)
