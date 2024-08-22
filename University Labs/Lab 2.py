# Zadanie 1.1

czyDodawac = False
suma = 0
iloscLiczb = 0
while(True):
    liczba = int(input("Podaj liczbe: "))
    if liczba == 0:
        czyDodawac = not czyDodawac
        continue
    elif liczba == -1:
        if suma == 0 and iloscLiczb == 0:
            break

        print(f"Avg. -> {suma} / {iloscLiczb} = {suma / iloscLiczb}")
        break
    if czyDodawac:
        suma += liczba
        iloscLiczb += 1
    print(liczba, end=" ")

# Zadanie 1.2

n1 = int(input("Podaj ilosc 'n' elementow tablicy: "))
if n1 < 1:
    print("Tablica nie moze miec taka ilosc elementow.")

tablica1 = []
for number in range(0, n1):
    tablica1.append(int(input(f"Podaj '{number}' tablicy: ")))

suma1 = 0
iloscElemetow1 = 0
ostatniElement1 = tablica1[len(tablica1) - 1]
for elem in tablica1:
    if elem > ostatniElement1:
        suma1 += elem
        iloscElemetow1 += 1

print(f"Suma elementow wiekszych od ostatniego -> {suma1}")
print(f"Avg. elementow wiekszych od ostatniego -> {suma1 / iloscElemetow1}")

# Zadanie 1.3

def sumaCyfr(liczba):
    resultat = 0
    temp = str(liczba)
    for cyfra in temp:
        resultat += int(cyfra)
    return resultat

n2 = int(input("Podaj ilosc 'n' elementow tablicy: "))
if n2 < 1:
    print("Tablica nie moze miec taka ilosc elementow.")

tablica2 = []
for number in range(0, n2):
    tablica2.append(int(input(f"Podaj '{number}' tablicy: ")))

tablica3 = []
ostatniElement2 = tablica2[len(tablica2) - 1]
for elem in tablica2:
    if sumaCyfr(elem) > ostatniElement2:
        tablica3.append(elem)

print(f"Tablica wiekszych elementow od ostatniego -> {tablica3}")
print(f"Ilosc elementow tej tablicy -> {len(tablica3)}")

# Zadanie 1.4

tablica4_parzyste = []
tablica4_nie_parzyste = []
for index in range(0, 10):
    liczba1 = int(input(f"Podaj '{index}' tablicy: "))
    if liczba1 == 0:
        break
    if liczba1 % 2 == 0:
        tablica4_parzyste.append(liczba1)
    elif liczba1 % 2 != 0:
        tablica4_nie_parzyste.append(liczba1)
print(f"Resultat parzystych i nie parzystych listow -> {tablica4_parzyste + tablica4_nie_parzyste}")

# Zadanie 1.5

n3 = int(input("Podaj ilosc 'n' elementow tablicy: "))
tablica5 = []

for number in range(0, n3):
    tablica5.append(int(input(f"Podaj '{number}' tablicy: ")))

print("Przed usunieciem wielokrotnosci liczby 5:", tablica5)

i = 0
while i < len(tablica5):
    if tablica5[i] % 5 == 0:
        for j in range(i, len(tablica5) - 1):
            tablica5[j] = tablica5[j + 1]
        tablica5.pop()
    else:
        i += 1

print("Po usunieciu wielokrotnosci liczby 5:", tablica5)

# Zadanie 2.1

tablica6 = []
for index in range(0, 4):
    tmpLiczba = int(input("Podaj liczbe dodatnia: "))
    if tmpLiczba <= 0:
        tmpLiczba = abs(tmpLiczba)
    tablica6.append(tmpLiczba)

length = len(tablica6) - 1
ostatniElement3 = tablica6[length]
for index in length:
    print(f"{tablica6[index]} / {ostatniElement3} = {tablica6[index] / ostatniElement3}")

# Zadanie 2.2

n4 = int(input("Podaj ilosc 'n' elementow tablicy: "))
if n4 < 1:
    print("Tablica nie moze miec taka ilosc elementow.")

suma_kwadratow = 0
for number in range(0, n4):
    liczb = int(input(f"Podaj '{number}' tablicy: "))
    suma_kwadratow += liczb ** 2

print(f"Suma kwadratow liczb -> {suma_kwadratow}")

# Zadanie 2.3

min_elem = 0
sum = 0
iloscElemetow2 = 0
while(True):
    liczb = int(input("Podaj liczbe: "))
    sum += liczb
    iloscElemetow2 += 1
    if min_elem > liczb:
        min_elem = liczb
    if liczb % 10 == 0:
        break
print(f"Min liczba -> {min_elem}")
print(f"Avg. liczba -> {sum / iloscElemetow2}")

# Zadanie 2.4

n5 = int(input("Podaj liczbę elementów tablicy: "))
tablica7 = []
for i in range(n5):
    liczba = int(input(f"Podaj liczbę {i}: "))
    tablica7.append(liczba)

if len(tablica7) < 3:
    print("Tablica jest zbyt krótka, aby znaleźć trzy kolejne liczby.")
else:
    max_suma = int('-inf')
    indeks_poczatkowy = 0

    for i in range(len(tablica7) - 2):
        suma_trzech = tablica7[i] + tablica7[i + 1] + tablica7[i + 2]
        if suma_trzech > max_suma:
            max_suma = suma_trzech
            indeks_poczatkowy = i

    print(f"Pozycji początkowa: {indeks_poczatkowy}")
    print(f"Trzy liczby to: {tablica7[indeks_poczatkowy]}, {tablica7[indeks_poczatkowy + 1]}, {tablica7[indeks_poczatkowy + 2]}")

# Zadanie 3.1

decimal = int(input("Podaj dziesietna liczbe: "))
binary = ""
while decimal > 0:
    binary = str(decimal % 2) + binary
    decimal = decimal // 2
print(f"Binarna liczba -> {binary}")

# Zadanie 3.2

binary_number = int(input("Podaj binarna liczbe: "))

decimal_number = 0
potega = len(str(binary_number)) - 1
for num in binary_number:
    decimal_number += int(num) * (2 ** potega)
    potega -= 1

print(f"Dziesietna liczba -> {decimal_number}")
