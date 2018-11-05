import tkinter as tk
from tkinter import *


def register_window(parent_widget):
    widget = tk.Toplevel()

    entry_phone = Entry(widget)
    button_find = Button(widget, text="find")
    button_register = Button(widget, text="register")

    entry_phone.grid(row=0, column=0)
    button_find.grid(row=0, column=1)
    button_register.grid(row=1, column=1)

    return widget


def create_gui():
    root = tk.Tk()

    #widget1 = register_window(root)
    #register_window(widget1)

    main = MainWindow(root)
    main.pack(side="top", fill="both", expand=True)

    # Code to add widgets will go here...
    root.mainloop()


class MainWindow(tk.Frame):
    counter = 0

    def __init__(self, *args, **kwargs):
        tk.Frame.__init__(self, *args, **kwargs)
        self.button = tk.Button(self, text="Create new window",
                                command=self.create_window)
        self.button.pack(side="top")

    def create_window(self):
        self.counter += 1
        t = tk.Toplevel(self)
        t.wm_title("Window #%s" % self.counter)
        l = tk.Label(t, text="This is window #%s" % self.counter)
        l.pack(side="top", fill="both", expand=True, padx=100, pady=100)
