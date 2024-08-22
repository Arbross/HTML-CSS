import random

# Task 1

n = 10
a = [random.randint(-10, 10) for _ in range(n)]
print(a)

new_a = []
is_decreasing = True
for i in range(n):
    if i == 0 or a[i] >= a[i-1]:
        new_a.append(a[i])
    else:
        is_decreasing = False
        if a[i] < 0:
            new_a.append(1)
        else:
            new_a.append(a[i])
if is_decreasing:
    print("List creates decrease sequence.")
else:
    print(new_a)

# Task 2

def find_product(arr):
    max_elem = max(arr, key=abs)
    min_elem = min(arr, key=abs)

    max_index = arr.index(max_elem)
    min_index = arr.index(min_elem)

    if max_index < min_index:
        max_index, min_index = min_index, max_index

    product = 1
    for i in range(min_index + 1, max_index):
        product *= arr[i]

    return product

arr = [-5, 4, -3, 2, -1, 0, 3, -2, 1]
product = find_product(arr)
print(product)

# Task 3

m = 5
n = 4

matrix = [[random.randint(0, 20) for j in range(n)] for i in range(m)]

print("Start matrix:")
for i in range(m):
    print(matrix[i])

max_element = matrix[0][0]
max_row = 0
for i in range(m):
    for j in range(n):
        if matrix[i][j] > max_element:
            max_element = matrix[i][j]
            max_row = i

temp = matrix[0]
matrix[0] = matrix[max_row]
matrix[max_row] = temp

print("Changed matrix:")
for i in range(m):
    print(matrix[i])

# Task 4

beforeTransponseMatrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]

n = len(beforeTransponseMatrix)

transpose_matrix = [[0 for j in range(n)] for i in range(n)]

for i in range(n):
    for j in range(n):
        transpose_matrix[j][i] = beforeTransponseMatrix[i][j]

print("Before transponsed matrix:")
for i in range(3):
    print(beforeTransponseMatrix[i])

print("Transponsed matrix:")
for i in range(3):
    print(transpose_matrix[i])

