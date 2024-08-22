import math

# Task 1

k = float(input("Enter 'k' value: "));
x = float(input("Enter 'x' value: "));

l = (1 / (pow(2.71, -k * x + 0.5)) * (((math.log(abs(k + x)) - math.sqrt(pow(math.sin(x), 4)) / (abs(math.atan(((x + 1) / (x - k)) + (3.14 / 10)) * math.log(3.14)) + 1))) + 2));

print("Here is your result value: ", l);

# Task 2

x = 3;
c = 2.5;

y = pow(x, 4) - pow(math.sqrt(c), 1/3);
d = 2 * y + math.cos(c);

print(x);
print(c);
print(y);
print(d);

# Task 3

T = 1.6;
W = -3.4;
E = -1.5 * pow(10, -3);
K = 2.1;
D = 3.2;
result = -229.579;

x = (math.sqrt(math.sin(W * T + E)) - pow(E, -W * T)) / (pow(math.sqrt(math.log(2 * k + D) + pow(D, 3 * k)), 1/3));

if (x == result):
    print("Right answer matches with count result.");

