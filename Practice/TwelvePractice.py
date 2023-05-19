import math

# Task 1

product = 1;
sum = 0;

while True:
    num_str = input("Enter value (or 'stop' to end process): ");
    if num_str == "stop":
        break;
    try:
        num = float(num_str);
    except ValueError:
        print("Please enter number value");
        continue;
    product *= num;
    sum += num;

print(f"Mult: {product}");
print(f"Sum: {sum}");

# Task 2

def factorial(n):
    if n < 0:
        return "Factorial can't be less then zero."
    elif n == 0 or n == 1:
        return 1;
    else:
        result = 1;
        for i in range(2, n+1):
            result *= i;
        return result;


n = 10;
x = 0;

while True:
    try:
        x = float(input("Enter 'x' value: "));
        if (x >= 0.1 and x <= 1):
            break;
    except ValueError:
        print("Please enter number value");
        continue;

sum = 0;
for k in range(0, n):
    sum += ((pow(-1, k) * pow(x, 2 * k + 1)) / (factorial(k) * (2 * k + 1)));

print("Here is your sum result: ", sum);

# Task 3

x0 = 0.4;
xk = 1.0;
h = 0.1;

x = x0;
while x <= xk:
    y = 1 + math.log2(x);
    print(f"x = {x:.2f}, y = {y:.2f}");
    x += h;
