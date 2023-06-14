R1 = float(input("Введіть опір першої опори: "));
R2 = float(input("Введіть опір другої опори: "));

print("Як об'єднані опори?");
print("1. Паралельно");
print("2. Послідовно");
choice = input("Ваш вибір: ");

if choice == '1':
    R = (R1 * R2) / (R1 + R2);
    print("Опір ланки: ", R);
elif choice == '2':
    R = R1 + R2;
    print("Опір ланки: ", R);
else:
    print("Невірний вибір");
