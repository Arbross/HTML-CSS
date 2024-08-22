# Zadanie 4.1

def is_power_of_three(num):
    if num <= 0:
        return False

    while num % 3 == 0:
        num /= 3

    return num == 1


# Перевірка для заданих чисел
numbers = [1, 3, 9, 12, 27, 81, 100]
for num in numbers:
    result = is_power_of_three(num)
    print(f"{num} є степенем числа 3: {result}")

# Zadanie 4.2

def is_silnia_equals_number(num):
    if num <= 0:
        return False

    tab = []
    while num != 0:
        tab.append(num % 10)
        num //= 10

    sum = 0
    for i in tab:
        innerSum = 1
        for j in range(0, i):
            innerSum *= j
        sum += innerSum
    if sum == num:
        return True
    else:
        return False

print(is_silnia_equals_number(145))

def gcd(a, b):
    while b:
        a, b = b, a % b
    return a

print(gcd(9, 27))
