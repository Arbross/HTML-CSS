import math;

# Task 1

a = int(input("Enter 'a' value: "));
b = int(input("Enter 'b' value: "));
m = float(input("Enter 'm' value: "));

h = (b - a) / m;

for val in range(int(a), int(b)):
    x = val + h;
    y = 1 / pow(x, 2) + pow(x, 2);
    print("Here is your value: ", y);

# Task 2

v = float(input("Enter 'v' value: "))

y = 0;
while (v <= 8):
    v += 0.5;
    if (0 <= v <= 0.5):
        y = pow(v, 2) + pow(math.sqrt(v), 1/3);
    elif (0.5 < v <= 8):
        y = math.log(v + math.sin(v));
    print("Here is your 'y' result value: ", y);

# Task 3

array = [10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

result = 0;
for val in array:
    result += val / 10;

print("Here is your result value: ", result);

# Task 4

# Sum math example

i = 2;
s = 0;
for l in range(i, 12):
    s += (pow(-1, l)) * ((pow(l, 4) - 2) / (pow(l, 2) + 3));

print("Here is your 's' result value: ", s);

# Multiplication math example

k = 6;
y = 0;
for l in range(i, k):
    y *= ((5 * pow(l, 2) - 2 * l + 1) / (3 * l + 5));

print("Here is your 'y' result value: ", y);

# Task 5

n = int(input("Enter 'n' value : "))

for val in range(0, n + 1):
    print(val);

# Task 6

step = int(input("Enter count of steps: "));

dArray = [];
for i in range(1, step + 1):
    dArray.append(int(input(f"Enter 'd{i}' value: ")));

sumA = 0;
mulB = 1;
for i in dArray:
    if (i % 2 == 0):
        sumA += i;
    else:
        mulB *= i;

print("Here is your 'sumA' value: ", sumA);
print("Here is your 'mulB' value: ", mulB);








