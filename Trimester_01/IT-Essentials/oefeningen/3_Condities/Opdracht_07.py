resultaat1 = int(input("Geef het eerste resultaat in op 20 "))
resultaat2 = int(input("Geef het tweede resultaat in op 20 "))
resultaat3 = int(input("Geef het derde resultaat in op 20 "))

som = ((resultaat1 + resultaat2 + resultaat3) / 60) * 100

if som < 60:
    print(som, "onvoldoende")
elif som < 70:
    print(som, "onvoldoende")
elif som < 80:
    print(som, "onderscheiding")
elif som < 90:
    print(som, "grote onderscheiding")
else:
    print(som, "grootste onderscheiding")
