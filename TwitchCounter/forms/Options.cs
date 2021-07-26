using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchCounter.forms
{
    public partial class Options : Form
    {
        //Saves application settings.
        public void saveSettings()
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
    }
}
