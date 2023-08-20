'''Schrijf programma waarmee je n karakters via het toetsenbord ingeeft, n wordt als gegeven via het toetsenbord ingegeven.

als dit karakter een letter is, dan controleer je of deze letter in hoofdletters of in kleine letters is ingegeven.
Je drukt dit karakter af met de melding of het al dan niet een hoofdletter is.
als dit karakter een cijfer is dan tel je dit op en hou je een som bij van alle ingegeven cijfers.
als dit karakter geen letter en geen cijfer is dan druk je dit karakter af met de vermelding “onbekend”'''


def main():
    som = 0
    n = int(input("geef het aantal karakters in "))
    for i in range(1, n + 1):
        karakter = input("geef een karakter in ")

        if karakter.isupper():
            print(karakter, ": is een hoofdletter")

        elif karakter.islower():
            print(karakter, ": is geen hoofdletter")

        elif karakter.isdigit():
            som += int(karakter)

        else:
            print(karakter, " is onbekend")
    print("De som van alle ingegeve cijfers: ", som)


if __name__ == '__main__':
    main()

