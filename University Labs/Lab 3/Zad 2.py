# Zadanie 2a
# Iteracyjnie

def ciagAIteracyjny(n):
    a0 = 1
    a1 = 1
    if n == 0:
        return -a0
    elif n == 1:
        return a1

    for number in range(n-1):
        a2 = a1 + a0
        a0 = a1
        a1 = a2
    if n % 2 == 0:
        return -a2
    else:
        return a2

for n in range(50):
    print(ciagAIteracyjny(n))

# Rekurencyjnie

def ciagARekurencyjny(n):
    if n == 0:
        return -1
    if n == 1:
        return 1
    return ciagARekurencyjny(n - 2) - ciagARekurencyjny(n - 1)


for n in range(30):
    print(ciagARekurencyjny(n))

# Zadanie 2b
# Iteracyinie
def ciagBIteracyjny(n):
    x = 1
    krok = 2
    for n in range(n):
        x += krok
        krok *= 2
    return x

for n in range(50):
    print(ciagBIteracyjny(n))

# Rekurencyjnie
def ciagBIteracyjny(x, krok):
    x += krok
    print(x)
    return ciagBIteracyjny(x, krok * 2)

ciagBIteracyjny(0, 1)
