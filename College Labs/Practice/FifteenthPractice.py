import os
import time

toys = {}

while True:
    os.system('cls' if os.name == 'nt' else 'clear')
    print("Menu:")
    print("0. Print all items")
    print("1. Print items up to 50 uah price")
    print("2. Add item")
    print("3. Delete item")
    print("4. Print sorted items")
    print("5. Exit")

    choice = input("Enter your choice (1-5): ")

    if choice == "1":
        for key, value in toys.items():
            if (value["price"] <= 50):
                print(key, ":", value)
        time.sleep(1)

    elif choice == "0":
        for key, value in toys.items():
            print(key, ":", value)
        time.sleep(1)

    elif choice == "2":
        name = input("Enter toy name: ")
        price = float(input("Enter toy price: "))
        material = input("Enter toy material: ")
        age_limit = int(input("Enter toy age limit: "))
        toys[name] = {"price": price, "material": material, "age_limit": age_limit}
        print("Item added successfully.")
        time.sleep(1)

    elif choice == "3":
        name = input("Enter toy name to delete: ")
        if name in toys:
            del toys[name]
            print("Item deleted successfully.")
        else:
            print("Item not found in dictionary.")
        time.sleep(1)

    elif choice == "4":
        sorted_keys = sorted(toys.keys())
        for key in sorted_keys:
            print(key, ":", toys[key])
        time.sleep(1)

    elif choice == "5":
        print("Goodbye!")
        break

    else:
        print("Invalid input. Please enter a number between 1 and 5.")
        time.sleep(1)
