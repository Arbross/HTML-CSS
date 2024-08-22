import random


def generate_random_list(max_value, length):
    return [random.randint(1, max_value) for _ in range(length)]

def sort_data():
    list = generate_random_list(50, 15)
    length = len(list)
    for i in range(length):
        for j in range(0, length-i-1):
            if list[j] > list[j+1]:
                list[j], list[j+1] = list[j+1], list[j]
    return list


result = sort_data()
print(result)

file = open("wynik.txt", "w")

for element in result:
    file.write(str(element) + "\n")

file.close()

