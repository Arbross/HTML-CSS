import math

# Task 1

x = float(input("Enter 'x' value: "));
a = float(input("Enter 'a' value: "));
b = float(input("Enter 'b' value: "));

y = 0;
if (x < a):
    y = pow(2.71, abs(x + a)) * math.sin(x);
elif (a < x < pow(b, 2)):
    y = pow(x, a + b);
elif (x >= pow(a, 2)):
    y = pow(x - 1, 2) * pow(math.cos(x), 2);

print("Here is your result value: ", y);

# Task 2

x1, y1 = map(float, input("Enter x1, y1 value through space: ").split());
x2, y2 = map(float, input("Enter x2, y2 value through space: ").split());

distance = math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2);

if distance == abs(math.sqrt(x1 ** 2 + y1 ** 2)) == abs(math.sqrt(x2 ** 2 + y2 ** 2)):
    print("Points are on the space.");
else:
    print("Points are not on the space.");


