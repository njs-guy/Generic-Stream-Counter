using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StreamCounter.Properties;

namespace TwitchCounter.forms
{
    public partial class Options : Form
    {
        string output_setting_start = "";
        Font font_setting_start;

        string output_setting_current = "";
        Font font_setting_current;

        //Saves application settings.
        public void saveSettings()
        {

            Settings.Default.RestorePrevSess = check_restorePrevSess.Checked;
            Settings.Default.NoOutput = check_noText.Checked;
            Settings.Default.ConfirmReset = check_confirmReset.Checked;

            if (Settings.Default.PreviewFont != null)
            {

            }

            if (Settings.Default.OutputPath != null)
            {

            }

            Settings.Default.Save();
        }

        //Changes theme
        public void applyTheme()
        {

        }

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            output_setting_start = Settings.Default.OutputPath;
            font_setting_start = Settings.Default.PreviewFont;
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
                MessageBox.Show(Convert.ToString(fontDialog1.Font));
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
                MessageBox.Show(outputPath);
            }
        }

        private void btn_resetSettings_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reset settings to default?", "Generic Stream Counter", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Settings.Default.RestorePrevSess = false;
                Settings.Default.NoOutput = false;
                Settings.Default.ConfirmReset = true;
                Settings.Default.PreviewFont = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular, GraphicsUnit.Point);
                Settings.Default.OutputPath = "counter_output.txt";
                Settings.Default.Save();
            }
        }
    }
}
