file = open("dane.txt", "r")

new_list = file.readlines()

# Task 1

list = []
for line in new_list:
    line = line.strip("\n")

    isAdded = False
    for item in list:
        if item[0] == line:
            item[1] += 1
            isAdded = True

    if isAdded is False:
        list.append([line, 1])

print(list)

# Task 2

maxCountWords = 0
index = 0
i = 0
for item in list:
    if item[1] > maxCountWords:
        maxCountWords = item[1]
        index = i
    i += 1

print(f"The word with the highest number of repeats is '{list[index][0]}' with {maxCountWords} repeats.")

# Task 3

counter = 0
for item in list:
    if int(item[0], 16) % 2 == 0:
        counter += 1

print(f"Count of % 2 == 0 numbers is {counter}.")

# Task 4

polindromsCounter = 0
for item in list:
    if item[0] == item[0][::-1]:
        polindromsCounter += 1

print(f"Polindroms count is {polindromsCounter}.")

# Task 5

for i in range(0, len(new_list)):
    for j in range(0, len(new_list) - i - 1):
        if new_list[j] > new_list[j + 1]:
            new_list[j], new_list[j + 1] = new_list[j + 1], new_list[j]

new_file = open("s_dane.txt", "w")
new_file.writelines(new_list)
new_file.close()

file.close()
