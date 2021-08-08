namespace TwitchCounter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.num_counter = new System.Windows.Forms.NumericUpDown();
            this.lbl_preview = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gr_preview = new System.Windows.Forms.GroupBox();
            this.btn_addOne = new System.Windows.Forms.Button();
            this.btn_minusOne = new System.Windows.Forms.Button();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.num_counter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gr_preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            resources.ApplyResources(this.lbl_text, "lbl_text");
            this.lbl_text.Name = "lbl_text";
            // 
            // lbl_count
            // 
            resources.ApplyResources(this.lbl_count, "lbl_count");
            this.lbl_count.Name = "lbl_count";
            // 
            // txt_text
            // 
            resources.ApplyResources(this.txt_text, "txt_text");
            this.txt_text.Name = "txt_text";
            // 
            // num_counter
            // 
            resources.ApplyResources(this.num_counter, "num_counter");
            this.num_counter.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.num_counter.Name = "num_counter";
            // 
            // lbl_preview
            // 
            resources.ApplyResources(this.lbl_preview, "lbl_preview");
            this.lbl_preview.Name = "lbl_preview";
            // 
            // btn_update
            // 
            resources.ApplyResources(this.btn_update, "btn_update");
            this.btn_update.Name = "btn_update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.optionsPageToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Checked = global::StreamCounter.Properties.Settings.Default.AlwaysOnTop;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            resources.ApplyResources(this.alwaysOnTopToolStripMenuItem, "alwaysOnTopToolStripMenuItem");
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // optionsPageToolStripMenuItem
            // 
            this.optionsPageToolStripMenuItem.Name = "optionsPageToolStripMenuItem";
            resources.ApplyResources(this.optionsPageToolStripMenuItem, "optionsPageToolStripMenuItem");
            this.optionsPageToolStripMenuItem.Click += new System.EventHandler(this.optionsPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gr_preview
            // 
            resources.ApplyResources(this.gr_preview, "gr_preview");
            this.gr_preview.Controls.Add(this.lbl_preview);
            this.gr_preview.Name = "gr_preview";
            this.gr_preview.TabStop = false;
            // 
            // btn_addOne
            // 
            resources.ApplyResources(this.btn_addOne, "btn_addOne");
            this.btn_addOne.Name = "btn_addOne";
            this.btn_addOne.UseVisualStyleBackColor = true;
            this.btn_addOne.Click += new System.EventHandler(this.btn_addOne_Click);
            // 
            // btn_minusOne
            // 
            resources.ApplyResources(this.btn_minusOne, "btn_minusOne");
            this.btn_minusOne.Name = "btn_minusOne";
            this.btn_minusOne.UseVisualStyleBackColor = true;
            this.btn_minusOne.Click += new System.EventHandler(this.btn_minusOne_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_minusOne);
            this.Controls.Add(this.btn_addOne);
            this.Controls.Add(this.gr_preview);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.num_counter);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_counter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gr_preview.ResumeLayout(false);
            this.gr_preview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.NumericUpDown num_counter;
        private System.Windows.Forms.Label lbl_preview;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gr_preview;
        private System.Windows.Forms.ToolStripMenuItem optionsPageToolStripMenuItem;
        private System.Windows.Forms.Button btn_addOne;
        private System.Windows.Forms.Button btn_minusOne;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

