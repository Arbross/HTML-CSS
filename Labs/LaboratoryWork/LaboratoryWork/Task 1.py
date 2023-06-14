import tkinter as tk

# Define a function that will be called when the button is clicked
def change_text_and_title():
    root.title("New Title")
    text_label.config(text="New Text")

# Create the root window
root = tk.Tk()
root.title("Window Title")
root.geometry("400x200")

# Create a button and place it in the window
button = tk.Button(root, text="Change Text and Title", command=change_text_and_title)
button.pack()

# Create a label (text element) and place it in the window
text_label = tk.Label(root, text="Original Text")
text_label.pack()

# Start the main event loop
root.mainloop()