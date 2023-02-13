BTW = 1.21
prijs_product = 11.5

aantal_artikals = int(input(" hoeveel artikals "))

totaal_prijs = (prijs_product * aantal_artikals * BTW)

if totaal_prijs > 1000:
    totaal_prijs *= 0.9

print(" het totaal is ", int(totaal_prijs * 100 + 0.5) / 100)
