import math

x = int(input("Enter 'x' value : "))

y = 0;
if (x < -1):
   y = acos((3.14 - x) / 2);
elif (abs(x) < 1):
   y = pow(2.71, pow(-x, 2))
elif (x > 1):
   y = 3.14 * pow(math.log(x), 2)
elif (abs(x) == 1):
   y = pow(10, -3)

print("Here is your result ", y)
