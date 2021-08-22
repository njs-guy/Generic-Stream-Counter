using System;
using System.Drawing;
using System.Windows.Forms;
using StreamCounter.Properties;

namespace TwitchCounter.forms
{
    public partial class Options : Form
    {
        string output_setting_start = "";
        Font font_setting_start;

        string output_setting_current = "";
        Font font_setting_current;

        private Main _mainForm; //used to call checkOutput()

        public Options()
        {
            InitializeComponent();
        }

        public Options(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        //Saves application settings.
        public void saveSettings()
        {
            //Check boxes
            Settings.Default.RestorePrevSess = check_restorePrevSess.Checked;
            Settings.Default.NoOutput = check_noText.Checked;
            Settings.Default.ConfirmReset = check_confirmReset.Checked;

            //If the font has changed
            if (font_setting_current != font_setting_start)
            {
                font_setting_start = font_setting_current;
                Settings.Default.PreviewFont = font_setting_current;
            }

            //If the output has changed
            if (output_setting_current != output_setting_start)
            {
                output_setting_start = output_setting_current;
                Settings.Default.OutputPath = output_setting_current;

                _mainForm.checkOutput();
            }

            //Save settings
            Settings.Default.Save();
        }

        //Changes theme
        public void applyTheme()
        {

        }

        private void Options_Load(object sender, EventArgs e)
        {
            output_setting_start = Settings.Default.OutputPath;
            output_setting_current = Settings.Default.OutputPath;
            font_setting_start = Settings.Default.PreviewFont;
            font_setting_current = Settings.Default.PreviewFont;
        }

        //Saves settings, then closes the window.
        private void btn_ok_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Close();
        }

        //Closes the window without saving settings.
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Saves settings while leaving window open.
        private void btn_apply_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        //Font dialog when selecting preview font
        private void btn_changePreviewFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                font_setting_current = fontDialog1.Font;
            }
        }

        //Save file dialog when changing output file
        private void btn_changeOutput_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if( result == DialogResult.OK)
            {
                string outputPath = Convert.ToString(folderBrowserDialog1.SelectedPath) + "\\counter_output.txt";
                Settings.Default.OutputPath = outputPath;

                MessageBox.Show(Settings.Default.OutputPath);
            }
        }

        private void btn_resetSettings_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reset settings to default?", "Generic Stream Counter", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //non-bool defaults
                Font defaultFont = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular, GraphicsUnit.Point);
                string defaultOutputPath = "counter_output.txt";

                //update these to be consistent
                output_setting_start = defaultOutputPath;
                font_setting_start = defaultFont;
                output_setting_current = defaultOutputPath;
                font_setting_current = defaultFont;

                //update actual settings
                Settings.Default.RestorePrevSess = false;
                Settings.Default.NoOutput = false;
                Settings.Default.ConfirmReset = true;
                Settings.Default.PreviewFont = defaultFont;
                Settings.Default.OutputPath = defaultOutputPath;
                Settings.Default.Save();
            }
        }
    }
}
