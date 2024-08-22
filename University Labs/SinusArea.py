import random
import math
# random.seed(11)
#
# a = 10 * [0]
# print(a)
#
# suma = 0
# max = 0
# secondMax = 0
# for i in range(10):
#     a[i] = random.randint(0, 100)
#     suma += a[i]
#     if secondMax < a[i] and secondMax != max:
#         max = secondMax
#         secondMax = a[i]
#
# print(a)
# print(f"Avg.: {suma / len(a)}")

# Zadanie 1

# def generate(n):
#     count = 0
#     for i in range(n):
#         x = random.random()
#         y = random.random()
#         # print(f"{x}, {y}")
#         if x * x + y * y <= 1:
#             count += 1
#
#     print(count)
#     print(f"z = {count} / {n} = {4 * (count / n)}")
#
# n = int(input("Podaj ilość 'n' liczb: "))
# generate(n)
# generate(1000)
# generate(10000)
# generate(100000)
# generate(1000000)

# Sinus

# def generate1(n):
#     count = 0
#     for i in range(n):
#         x = random.random() * math.pi
#         y = random.random()
#         # print(f"{x}, {y}")
#         if y <= math.sin(x):
#             count += 1
#     print(f"z = {(math.pi * count) / n}")
# # pi s / n
# generate1(10000000)

# Sinus 2

def generate1(n):
    h = math.pi / n
    resultat = 0
    for i in range(n):
        x1 = h * i
        x2 = x1 + h
        y1 = math.sin(x1)
        y2 = math.sin(x2)
        resultat += ((y1 + y2) / 2) * h
    return resultat

print(generate1(5))
print(generate1(100))
print(generate1(10000))
