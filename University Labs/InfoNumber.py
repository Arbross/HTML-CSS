number = int(input("Prosze podac liczbew zakresie 0-999: "))
if number < 0 | number > 999:
    print("Nie poprawna liczba.")

first = (int)(number % 1000 / 100)
second = (int)(number % 100 / 10)
third = (int)(number % 10)

if first == 0:
    print(f"Suma cyfr: {second + third}, dziesiatki: {second}, jednosci: {third}")
elif first == 0 & second == 0:
    print(f"Suma cyfr: {third}, jednosci: {third}")
else:
    print(f"Suma cyfr: {first + second + third}, setki: {first}, dziesiatki: {second}, jednosci: {third}")
