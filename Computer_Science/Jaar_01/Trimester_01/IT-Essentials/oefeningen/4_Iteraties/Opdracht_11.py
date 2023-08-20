aantal_vrouwen = 0
aantal_mannen = 0

personeelsnummer = int(input("Geef het personeelsnummer in "))
while personeelsnummer != 0:
    leeftijd = int(input("Geef de leeftijd in "))
    brutoloon = int(input("Geef de de brutoloon in "))
    geslacht = int(input("Geef het geslacht in (0= vrouw , 1= man "))
    while not (geslacht == 0 or geslacht == 1):
        geslacht = int(input("Foute invoer! (0= vrouw , 1= man "))

    if geslacht == 1:
        if leeftijd > 34 or brutoloon >= 1800:
            aantal_mannen += 1

    else:
        if leeftijd < 25:
            aantal_vrouwen += 1

    personeelsnummer = int(input("Geef het personeelsnummer in "))

print("Aantal mannen die ouder zijn dan 34 jaar, of een loon hebben van 1800 euro of meer:", aantal_mannen)
print("Aantal vrouwen die jonger zijn dan 25 jaar:", aantal_vrouwen)
