# UI for options window/page

import tkinter as tk
import tkinter.ttk as ttk
from tkinter.messagebox import showinfo

from theme.gsc_theme import set_theme

class Options(tk.Tk):
    def __init__(self):
        super().__init__()

        # Window properties
        self.geometry('350x550')
        self.resizable(False, False)
        self.title('Options')

        self.restore_var = tk.BooleanVar()
        self.confirm_reset_var = tk.BooleanVar()
        self.no_output_var = tk.BooleanVar()
        self.output_path_var = tk.StringVar()

        # self.restore_var = tk.BooleanVar(value=True)
        

        # General
        general_lf = ttk.LabelFrame(self, text="General", height=100)
        general_lf.pack(fill='both', expand='true', padx=8, pady=8)

        restore_check = ttk.Checkbutton(general_lf, 
                        text="Restore previous session on startup",
                        variable= self.restore_var,
                        onvalue=True,
                        offvalue=False)
        
        confirm_reset_check = ttk.Checkbutton(general_lf, 
                        text="Confirm counter reset",
                        variable= self.confirm_reset_var,
                        onvalue=True,
                        offvalue=False)
        
        restore_check.pack()
        confirm_reset_check.pack()

        # Advanced
        advanced_lf = ttk.LabelFrame(self, text="Advanced", height=100)
        advanced_lf.pack(fill='both', expand='true', padx=8, pady=8)

        no_output_check = ttk.Checkbutton(advanced_lf, 
                        text="Do not output text file. Only use preview.",
                        variable= self.no_output_var,
                        onvalue=True,
                        offvalue=False)
        
        change_output_btn = ttk.Button(advanced_lf, text="Change output path")

        no_output_check.pack()
        change_output_btn.pack(pady=20)

        # Buttons
        reset_btn = ttk.Button(self, text="Reset", width=8)
        ok_btn = ttk.Button(self, text="OK", width=8)
        cancel_btn = ttk.Button(self, text="Cancel", width=8)
        apply_btn = ttk.Button(self, text="Apply", width=8)

        reset_btn.pack(anchor="sw", side="left", padx=5, pady=5)
        ok_btn.pack(anchor="se", side="right", padx=5, pady=5)
        cancel_btn.pack(anchor="se", side="right", padx=5, pady=5)
        apply_btn.pack(anchor="se", side="right", padx=5, pady=5)
        
        set_theme(self, 10)


# Driver
if __name__ == "__main__":
    opts = Options()
    opts.mainloop()