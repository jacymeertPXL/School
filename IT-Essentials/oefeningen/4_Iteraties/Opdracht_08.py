
AFSTAND = 36000
teller = 0
teller_meer = 0
snelste = 1000000000
snelste_nummer = 0
inschrijvingsnummer = int(input("geef het nummer "))
while inschrijvingsnummer >= 0:
    teller += 1
    tijd_sec = int(input("geef de tijd in seconden "))
    if tijd_sec < snelste:
        snelste = tijd_sec
        snelste_nummer = inschrijvingsnummer
    if tijd_sec > 60 * 60:
        teller_meer += 1

    inschrijvingsnummer = int(input("geef het nummer "))

print("Het percentage van de renners dat er langer dan 1 uur over doet:", (teller_meer / teller) * 100, "%")
print("Snelste renner is de renner met inschrijvingsnummer", snelste_nummer)
