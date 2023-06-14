import tkinter as tk
from datetime import datetime

# Create a function to calculate age based on birth year entered by the user
def calculate_age():
    birth_year = int(entry.get())
    now = datetime.now()
    age = now.year - birth_year

    # Set the window size and background color based on the age
    if age < 50:
        root.geometry("200x100")
        root.configure(bg="green")
    else:
        root.geometry("300x150")
        root.configure(bg="red")

    # Update the age label text
    age_label.configure(text=f"Age: {age}")

# Create the root window
root = tk.Tk()
root.title("Age Counter")

# Create a label and entry widget for the birth year
year_label = tk.Label(root, text="Enter your birth year:")
year_label.pack()
entry = tk.Entry(root)
entry.pack()

# Create a button to calculate the age
button = tk.Button(root, text="Calculate Age", command=calculate_age)
button.pack()

# Create a label for the age and place it in the window
age_label = tk.Label(root, text="Age: ", font=("Arial", 24))
age_label.pack(expand=True)

# Define a function that will be called when the window is clicked
def resize_window(event):
    current_size = root.geometry()
    if current_size == "200x100":
        root.geometry("300x150")
    else:
        root.geometry("400x200")

# Bind the resize function to the window click event
root.bind("<Button-1>", resize_window)

# Start the main event loop
root.mainloop()