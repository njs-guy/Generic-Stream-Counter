# Function to set theme

import tkinter as tk
from tkinter import ttk

def set_theme(container, font_size = 14, theme="light"):
            # Font
            font_name = 'Open Sans'

            # Colors. l = light theme, d = dark theme, b = black theme
            l_text_color = 'black'
            l_bg_color = '#f0f0f0'
            l_btn_bg_color = 'white'
            l_btn_hover_color = '#59C135'
            l_btn_pressed_color = '#008d59'

            d_text_color = '#CECECE'
            d_bg_color = '121212'

            if ttk.Style().theme_use() == 'aqua':
                # Do nothing if using Mac theme
                pass 
            else:
                # Set theme if not on Mac

                # Check and set colors
                if theme == 'light':
                    text_color = l_text_color
                    bg_color = l_bg_color
                    btn_bg_color = l_btn_bg_color
                    btn_hover_color = l_btn_hover_color
                    btn_pressed_color = l_btn_pressed_color
                elif theme == 'dark':
                    text_color = d_text_color
                    bg_color = d_bg_color
                    btn_bg_color = l_btn_bg_color
                    btn_hover_color = l_btn_hover_color
                    btn_pressed_color = l_btn_pressed_color
                elif theme == 'black':
                    text_color = l_text_color
                    bg_color = l_bg_color
                    btn_bg_color = l_btn_bg_color
                    btn_hover_color = l_btn_hover_color

                container.style = ttk.Style(container)
                container.style.theme_use('clam')
                container.style.configure('.', font=(font_name, font_size), background=bg_color, foreground=text_color, bordercolor='darkgrey')
                # container.style.configure('TCheckbutton', font=(font_name, font_size))
                container.style.configure('TButton', font=(font_name, font_size), background=btn_bg_color, highlightcolor=btn_hover_color, relief='groove', borderwidth=3, cursor="hand2")
                # container.style.map("TButton",
                #     foreground=[('pressed', 'black'), ('active', 'black')],
                #     background=[('pressed', '!disabled', btn_pressed_color), ('active', btn_hover_color)]
                #     )
                # container.style.configure('TEntry', font=(font_name, font_size))
                # container.style.configure('TSpinbox', font=(font_name, font_size))
                # container.style.configure('TLabel', font=(font_name, font_size), background=l_bg_color)
                container.style.configure('Label', font=(font_name, font_size))
                # container.style.configure('TLabelFrame', font=(font_name, font_size), background=l_bg_color)