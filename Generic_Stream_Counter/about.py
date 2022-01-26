import tkinter as tk
import tkinter.ttk as ttk
import webbrowser
from tkinter.messagebox import showinfo

from theme.gsc_theme import set_theme

class About(tk.Tk):
    def __init__(self):
        super().__init__()

        def callback(url):
            webbrowser.open_new(url)

        window_width = 400
        # Window properties
        self.geometry(str(window_width) + 'x550')
        self.resizable(True, True)
        self.title('About GSC')

        # Header
        self.version = '0.3'
        self.logo_img = tk.PhotoImage(file='./Generic_Stream_Counter/images/gsc_about.gif')
        self.header_lbl = ttk.Label(image=self.logo_img,text=f"Generic Stream Counter v{self.version}", compound='top')
        self.header_lbl.pack()

        self.creator_lbl = ttk.Label(text="Created by Nick Shockey under the MIT license.")
        self.creator_lbl.pack(padx=20, pady=20)
        
        # Links
        self.source_code_link = ttk.Label(text="SOURCE CODE", foreground="blue", cursor="hand2")
        self.source_code_link.pack()
        self.source_code_link.bind("<Button-1>", lambda e: callback("https://github.com/njshockey/Generic-Stream-Counter"))

        self.license_link = ttk.Label(text="LICENSE", foreground="blue", cursor="hand2")
        self.license_link.pack()
        self.license_link.bind("<Button-1>", lambda e: callback("https://github.com/njshockey/Generic-Stream-Counter/blob/main/LICENSE.txt"))

        # Open Sans
        self.open_sans_lbl = ttk.Label(text="Open Sans was created by Steve Matteson and uses the Apache License, version 2.0.", wraplength=window_width-40, justify='center')
        self.open_sans_lbl.pack(padx=20, pady=20)

        # Azure theme
        self.azure_lbl = ttk.Label(text="The Azure ttk theme was created by rdbende and uses the MIT license.", wraplength=window_width-40, justify='center')
        self.azure_lbl.pack(padx=20, pady=20)

        set_theme(self, 11)

# Driver
if __name__ == "__main__":
    about = About()
    about.mainloop()