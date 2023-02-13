HUIDIG_JAAR = 2022
bedrag = 100
leeftijd = int(input("Geef de leeftijd in: "))
aansluitingsjaar = int(input("Geef het aansluitingsjaar: "))

if bedrag < 21 or leeftijd > 60:
    bedrag -= 14.5

bedrag = bedrag - (HUIDIG_JAAR - aansluitingsjaar) * 2.5
if bedrag < 62.5:
    bedrag = 62.5

print("De prijs is ", bedrag, " euro.")
