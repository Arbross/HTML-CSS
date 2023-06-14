import math

e = float(input("Enter the 'e' value: "))
y = float(input("Enter the 'y' value: "))
gamma = float(input("Enter the 'gamma' value: "))

m = (math.pow((gamma-y), 0.4)/(math.pow(e, gamma)+math.pow(e, -y))) + ((math.pow(math.log(abs(y - 5.5), 10), 2) + math.pow(math.sin(gamma / 4), 2)) / (math.sqrt(abs(gamma + y)) + (math.pow(math.atan(y), 1/3))))

print("Your result value is '" + m + "'")
