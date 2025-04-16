def kalkulator():
    try:
        a = float(input("Podaj pierwszą liczbę: "))
        b = float(input("Podaj drugą liczbę: "))
        op = input("Wybierz operację (+, -, *, /): ")
        if op == "+":
            print(f"Wynik: {a + b}")
        elif op == "-":
            print(f"Wynik: {a - b}")
        elif op == "*":
            print(f"Wynik: {a * b}")
        elif op == "/":
            if b != 0:
                print(f"Wynik: {a / b}")
            else:
                print("Błąd: dzielenie przez zero.")
        else:
            print("Nieznana operacja.")
    except ValueError:
        print("Nieprawidłowe dane wejściowe.")

def konwerter_temperatur():
    kierunek = input("Wybierz konwersję (C -> F wpisz 'C', F -> C wpisz 'F'): ").upper()
    try:
        temp = float(input("Podaj temperaturę: "))
        if kierunek == "C":
            wynik = temp * 1.8 + 32
            print(f"{temp}°C = {wynik:.2f}°F")
        elif kierunek == "F":
            wynik = (temp - 32) / 1.8
            print(f"{temp}°F = {wynik:.2f}°C")
        else:
            print("Nieznany kierunek konwersji.")
    except ValueError:
        print("Nieprawidłowa temperatura.")

def srednia_ocen():
    try:
        n = int(input("Ile ocen chcesz podać? "))
        oceny = []
        for i in range(n):
            ocena = float(input(f"Podaj ocenę {i+1}: "))
            if 1 <= ocena <= 6:
                oceny.append(ocena)
            else:
                print("Ocena spoza zakresu 1-6. Pomijam.")
        if oceny:
            srednia = sum(oceny) / len(oceny)
            print(f"Średnia: {srednia:.2f}")
            print("Uczeń zdał." if srednia >= 3.0 else "Uczeń nie zdał.")
        else:
            print("Brak poprawnych ocen.")
    except ValueError:
        print("Nieprawidłowa liczba ocen.")

def menu():
    while True:
        print("\nMENU:")
        print("1 - Kalkulator")
        print("2 - Konwerter temperatur")
        print("3 - Średnia ocen")
        print("0 - Wyjście")
        wybor = input("Wybierz opcję: ")

        if wybor == "1":
            kalkulator()
        elif wybor == "2":
            konwerter_temperatur()
        elif wybor == "3":
            srednia_ocen()
        elif wybor == "0":
            print("Do widzenia!")
            break
        else:
            print("Niepoprawny wybór.")

if __name__ == "__main__":
    menu()
