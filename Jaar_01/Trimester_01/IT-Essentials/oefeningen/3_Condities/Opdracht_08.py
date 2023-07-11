afstand = float(input("Geef de afstand in km in: "))
klasse = int(input("Geef de klasse in "))

if afstand < 1000:
    prijs = 0.25 * afstand
elif afstand < 3000:
    prijs = 0.20 * afstand
else:
    prijs = 0.12 * afstand

if klasse == 2:
    prijs = prijs - (prijs / 100 * 20)
elif klasse == 3:
    prijs = prijs + (prijs / 100 * 30)

print("De prijs is ", prijs, " euro.")