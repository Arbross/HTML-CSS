# a[::-1], a[1:2]

def fibonacci_(n):
    a0 = 1
    a1 = 1
    if n == 0:
        return a0
    elif n == 1:
        return a1

    for number in range(1, n):
        a2 = a1 + a0
        a0 = a1
        a1 = a2
    return a2

for n in range(50):
    print(fibonacci_(n))
