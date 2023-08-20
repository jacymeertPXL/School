afgelegde_kilimeter = float(input("aantal afgelegde km per jaar"))
verbruik = float(input("verbruik in liter per 100km"))
prijs_per_liter = float(input("prijs van 1 liter brandstof"))

kostprijs_per_km = (verbruik / afgelegde_kilimeter) * prijs_per_liter
totalekost_perjaar = afgelegde_kilimeter * kostprijs_per_km

print("De totale kost per jaar bedraagt " , totalekost_perjaar)

print("De kostprijs per kilimeter ", kostprijs_per_km)