1. **Oppervlakte van een Plank:**

Stel dat je de lengte, breedte en hoogte van een plank hebt en je wilt het totale oppervlakte berekenen.

````python
length = 10 width = 5 height = 2  
total_surface_area = 2 * (length * width + length * height + width * height) print("Totale oppervlakte van de plank:", total_surface_area)
`````

2. **Oppervlakte van een Kubus:**

Voor een kubus met één zijde a kun je de oppervlakte berekenen als 6 keer het kwadraat van de zijde.

````python
side_length = 4   
surface_area_cube = 6 * side_length ** 2 print("Oppervlakte van de kubus:", surface_area_cube)
`````

3. **Oppervlakte van een Cirkel:**

Stel dat je de straal van een cirkel hebt en je wilt de oppervlakte berekenen.

````python
import math  radius = 3  
circle_area = math.pi * radius ** 2 print("Oppervlakte van de cirkel:", circle_area)
`````

In deze voorbeelden gebruik ik de wiskundige module `math` voor het benaderen van π (pi). Je moet ervoor zorgen dat je deze module importeert om toegang te hebben tot de `math.pi`-constante