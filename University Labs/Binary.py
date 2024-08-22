### Cast (10) to (2)

number = int(input("Podaj liczbe: "))

wynik = ''
while number > 0:
    x = number % 2
    wynik = str(x) + wynik
    number = number // 2
print(wynik)

### Cast (2) to (10)

binaryNumber = int(input("Podaj binary liczbe: "))

potega = 0
wynik_binarny = 0
while binaryNumber > 0:
    x = binaryNumber % 10
    binaryNumber = binaryNumber // 10
    #print(x, 2**potega)
    wynik_binarny = wynik_binarny + x * potega
    potega = potega * 2
#print(wynik_binarny)

### Another

wynik_binarny = 0
len = -len(str(binaryNumber))
while len > 0:
    wynik_binarny += -len * 2 + int(str(binaryNumber)[len])
    len -= 1
print(wynik_binarny)

