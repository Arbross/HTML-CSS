import tkinter as tk

# Define a function that will be called when a button is clicked
def turn_on_device(device):
    device_label.config(text=f"Turn on {device}")

# Create the root window
root = tk.Tk()
root.title("Device Control")
root.geometry("400x200")

# Create a button for each device and place it in the window
printer_button = tk.Button(root, text="Printer", command=lambda: turn_on_device("Printer"))
printer_button.pack()

scanner_button = tk.Button(root, text="Scanner", command=lambda: turn_on_device("Scanner"))
scanner_button.pack()

keyboard_button = tk.Button(root, text="Keyboard", command=lambda: turn_on_device("Keyboard"))
keyboard_button.pack()

# Create a label and place it in the window
device_label = tk.Label(root, text="")
device_label.pack()

# Start the main event loop
root.mainloop()




