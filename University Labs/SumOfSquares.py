n = 0
while n < 10 or n > 50:
    n = int(input("Wpisz 'n' liczbe: "))

result = 0
for element in range(1, n):
    result += element * element

print(f"Resultatem jest - '{result}'.")
