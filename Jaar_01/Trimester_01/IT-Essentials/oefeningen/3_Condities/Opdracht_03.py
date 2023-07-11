vertrekuur = int(input("Voer het vertrekuur in: "))
vertrekminuut = int(input("Voer het vertrekminuut in: "))
duur = int(input("Voer de duur in minuten in: "))

aankomstuur = (vertrekuur + (duur // 60)) % 24

aankomstminuut = (vertrekminuut + (duur % 60)) % 60

print(aankomstuur, aankomstminuut)
