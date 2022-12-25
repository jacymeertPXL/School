getal01 = float(input("Geef het eerste getal in "))
getal02 = float(input("Geef het tweede getal in "))
code = float(input("Geef de code in "))

if (code == 1):
    oplossing = getal01 + getal02
    print("de som van de twee getallen is: ", oplossing)
elif (code == 2):
    aftrekking = getal01 - getal02
    print("de som van de twee getallen is: ", aftrekking)
elif (code == 3):
    vermenigvuldiging = getal01 * getal02
    print("de som van de twee getallen is: ", vermenigvuldiging)
elif (code == 4):
    kwadraata = getal01 ** 2
    print("kwadraat van a is", kwadraata)
elif (code == 5):
    kwadraatb = getal02 ** 2
    print("kwadraat van b is", kwadraatb)
else:
    print("foutieve code ingegeven")
