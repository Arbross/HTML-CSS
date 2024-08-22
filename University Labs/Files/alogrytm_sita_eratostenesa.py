import math


def znajdz_liczby_pierwsze(end_number):
    tab = [True]*(end_number-1)
    for i in range(2, math.ceil(math.sqrt(end_number))):
        if tab[i-2]:
            for j in range(i*i, end_number+1, i):
                tab[j-2] = False
    return tab


result = znajdz_liczby_pierwsze(123451)

print("Liczby pierwsze:")
for i in range(2, 123451 + 1):
    if result[i-2]:
        print(i, end=", ")
