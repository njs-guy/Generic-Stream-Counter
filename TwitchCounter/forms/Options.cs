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
        //Saves application settings.
        public void saveSettings()
        {
            Settings.Default.AlwaysOnTop = check_AoT.Checked;

            Settings.Default.RestorePrevSess = check_restorePrevSess.Checked;

            Settings.Default.NoOutput = check_noText.Checked;

            if (Settings.Default.PreviewFont != null)
            {

            }

            if (Settings.Default.OutputPath != null)
            {

            }

            Settings.Default.Save();
        }

        //After changing the settings file, change the current settings to reflect that
        public void applySettings()
        {

        }

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

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
                string outputPath = folderBrowserDialog1.SelectedPath;
                MessageBox.Show(outputPath);
            }
        }
    }
}
