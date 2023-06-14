l = int(input("Enter 'l' value: "))
k = int(input("Enter 'k' value: "))

a = (l + k) / 5
b = (l - k) / k
c = l * k + 4.2

tmp1 = 0;
tmp2 = 0;

if (a < b):
    tmp1 = a;
else:
    tmp1 = b;

if (b > c):
    tmp2 = b;
else: 
    tmp2 = c;

p = tmp1 + tmp2

print("Your result is ", p)

