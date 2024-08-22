import random

# Task 1

text_array = ['paper', 'water', 'tower', 'canal', 'bee', 'volume'];
merged_text = text_array[1] + text_array[3];
del text_array[3];
text_array.insert(1, merged_text);

print(text_array);

# Task 2

text = input("Enter text: ");
max_count = 0;
current_count = 1;

for i in range(len(text)-1):
    if text[i] == text[i+1]:
        current_count += 1;
    else:
        if current_count > max_count:
            max_count = current_count;
        current_count = 1;

if current_count > max_count:
    max_count = current_count;

print("Result:", max_count);

