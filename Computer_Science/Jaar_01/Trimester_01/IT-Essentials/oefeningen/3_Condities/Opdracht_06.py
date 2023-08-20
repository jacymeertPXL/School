jaar_film = 2022 - int(input("Welk jaar is de film gemkaat: "))
rating_film = int(input("Rating van 1 tot 5: "))
prijs_film = 5

if (rating_film < 4 or rating_film > 5):
    prijs_film = 2

else:
    prijs_film = 1

if (jaar_film < 2):
    prijs_film += 1

print("de prijs van de film is ", str(prijs_film))