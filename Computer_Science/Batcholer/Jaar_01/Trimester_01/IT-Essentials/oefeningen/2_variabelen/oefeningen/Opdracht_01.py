
teller = 1
var = input("geef een eerst getal in")
while var != "":

    teller += 1
    gemiddelde2 =+ int(var)
    var = input("geef een eerst getal in")

    if teller == 3:
        som = gemiddelde2 / teller
        teller = 0
        print(som)




