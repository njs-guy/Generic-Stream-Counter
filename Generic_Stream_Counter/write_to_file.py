# Writes to .txt or .json

# Creates string to output to file
def write_output(text='Count', count='0', sep=''):
    if len(sep) == 0:
        output_to_text(text + " " + count)
    else:
        output_to_text(text + sep + " " + count)

def write_settings(settings= []):
    pass

# Writes counter_output.txt
def output_to_text(output):
    if len(output) > 0:
        with open('counter_output.txt', 'w', encoding='utf-8') as f:
            f.write(output)
        
        f.close()

# Writes settings.json
def output_to_json():
    pass