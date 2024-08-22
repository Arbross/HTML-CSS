
### Отримувати значення від користувача, поки не буде введено непарне число. Визначте найменше і найбільше значення, а потім виведіть результат піднесення до степеня (операція підведення до степеня повинна виконуватися на основі циклу, без використання вбудованої функції), де: основа = min, ступінь = max.

n = 0
list = []

while n % 2 == 0:
    n = int(input("Wpisz liczbe: "))
    list.append(n)

max = list[0]
min = list[0]
for i in range(1, len(list)):
    if max < list[i]:
        max = list[i]
    elif min > list[i]:
        min = list[i]

print(f"Max: '{max}'.")
print(f"Min: '{min}'.")

result = 1
for i in range(0, max):
    result *= min

print(f"Resultat: '{result}'.")
