brutoloon = int(input("Geef het brutoloon van een werknemer in "))
vakantiegeld = (brutoloon / 100) * 5
jaarlijkse_bijdrage = (350 / 100) * 8

print("Dit is de het vakantiegeld: ", vakantiegeld)

if vakantiegeld >= 350:
    print(("De jaarlijkse bijdrage = "), jaarlijkse_bijdrage)

else:
    print("De jaarlijkse bijdrage = ", (vakantiegeld / 100) * 8)
