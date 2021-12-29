# UI for main window

import tkinter as tk
from tkinter import *
from tkinter import ttk
from tkinter.messagebox import showerror

from theme.gsc_theme import set_theme
from write_to_file import write_output, write_settings

class App(tk.Tk):

    def __init__(self):
        super().__init__()

        # Writes the counter_output file
        def update_output():
            txt = text_str.get()
            cnt = counter_num.get()
            write_output(txt, cnt)

            preview_lbl.config(text=txt + " " + cnt)
        
        # Resets the count to 0
        def reset_counter():
            counter_num.set('0')
            update_output()

        def plus_button_clicked():
            num = int(counter_num.get())
            maxval = int(self.nametowidget(self.count_ent).config('to')[4])

            if num + 1 < maxval: # Only update if new counter value is lower than max
                counter_num.set(str(num+1))
                update_output()
            else:
                showerror(title="Error", message="The counter is currently at its maximum value.")

        def minus_button_clicked():
            num = int(counter_num.get())
            minval = int(self.nametowidget(self.count_ent).config('from')[4])

            if num - 1 >= minval: # Only update if new counter value is lower than max
                counter_num.set(str(num-1))
                update_output()
            else:
                showerror(title="Error", message="The counter is currently at its minimum value.")

        # Window properties
        self.geometry('600x300')
        self.resizable(False, False)
        self.title('Generic Stream Counter')

        # Grid
        self.columnconfigure(0, weight=1)
        self.columnconfigure(1, weight=1)
        
        text_str = StringVar()
        text_str.set('Count:') # Default value. Set using settings later.

        counter_num = StringVar()
        counter_num.set('0') # Default value. Set using settings later.
            
        # Labels
        # Text:
        self.text_lbl = ttk.Label(text="Text: ")
        self.text_lbl.grid(column=0, row=0, sticky=tk.W, padx=10, pady=5)

        self.text_ent = ttk.Entry(textvariable=text_str)
        self.text_ent.grid(column=1, row=0, sticky=tk.W, padx=5, pady=5)

        # Count:
        self.count_lbl = ttk.Label(text="Count: ")
        self.count_lbl.grid(column=0, row=1, sticky=tk.W, padx=10, pady=5)

        self.count_ent = ttk.Spinbox(from_=0, to=2000000,textvariable=counter_num, wrap=False)
        self.count_ent.grid(column=1, row=1, sticky=tk.W, padx=5, pady=5)

        # Buttons
        # Update
        self.update_btn = ttk.Button(text="Update", width=8, command=update_output)
        self.update_btn.grid(column=0, row=2, sticky=tk.W, padx=10, pady=15)

        # Add 1
        self.add_btn = ttk.Button(text="+1", width=8, command=plus_button_clicked)
        self.add_btn.grid(column=1, row=2, sticky=tk.W, padx=5, pady=15)

        # Minus 1
        self.subtract_btn = ttk.Button(text="-1", width=8, command=minus_button_clicked)
        self.subtract_btn.grid(column=1, row=2, padx=5, pady=15)

        # Preview
        preview_lf = ttk.LabelFrame(text="Preview")
        preview_lf.grid(column=0, row=3, columnspan=4, rowspan=4, sticky=tk.EW, padx=10, pady=10)
        preview_lbl = ttk.Label(preview_lf, text="PREVIEW ")
        preview_lbl.pack(expand=True, fill="both", ipadx=20, ipady=20)

        # Menu
        menubar = Menu(self, relief=FLAT, bd=0)
        self.config(menu=menubar)

        options_m = Menu(menubar, tearoff=0, activeborderwidth=3)
        options_m.add_command(label='Always on top', command=self.destroy)
        options_m.add_command(label='Reset', command=self.destroy)
        options_m.add_command(label='Options', command=self.destroy)
        options_m.add_command(label='Exit', command=self.destroy)

        # Help - About, Instructions, Source code
        help_m = Menu(menubar, tearoff=0, activeborderwidth=3)
        help_m.add_command(label='About', command=self.destroy)
        help_m.add_command(label='Instructions', command=self.destroy)
        help_m.add_command(label='Source code', command=self.destroy)

        # Add to window
        menubar.add_cascade(label='Options', menu=options_m)
        menubar.add_cascade(label='Help', menu=help_m)

        set_theme(self)

# Driver
if __name__ == "__main__":
    app = App()
    app.mainloop()