PIB = input("Enter your PIB value : ")
group = input("Enter your group value : ")
age = float(input("Enter your age value : "))
school = input("Enter your school value : ")
variant = float(input("Enter your variant value : "))

text = ("My PIB is %s and I am %d years old and i am learning in %s." % ("\n".join(PIB), age, school)).upper()

centered_text = text.center(170)

print(centered_text)
print(school[-5])
print(PIB[2:5])
print(PIB[3] + " Третя літера прізвища")
