namespace TwitchCounter.forms
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.btn_changeOutput = new System.Windows.Forms.Button();
            this.btn_changePreviewFont = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gb_general = new System.Windows.Forms.GroupBox();
            this.check_restorePrevSess = new System.Windows.Forms.CheckBox();
            this.gb_advanced = new System.Windows.Forms.GroupBox();
            this.check_noText = new System.Windows.Forms.CheckBox();
            this.check_confirmReset = new System.Windows.Forms.CheckBox();
            this.btn_resetSettings = new System.Windows.Forms.Button();
            this.gb_general.SuspendLayout();
            this.gb_advanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_changeOutput
            // 
            this.btn_changeOutput.Location = new System.Drawing.Point(186, 71);
            this.btn_changeOutput.Name = "btn_changeOutput";
            this.btn_changeOutput.Size = new System.Drawing.Size(141, 23);
            this.btn_changeOutput.TabIndex = 3;
            this.btn_changeOutput.Text = "Change output location";
            this.btn_changeOutput.UseVisualStyleBackColor = true;
            this.btn_changeOutput.Click += new System.EventHandler(this.btn_changeOutput_Click);
            // 
            // btn_changePreviewFont
            // 
            this.btn_changePreviewFont.Location = new System.Drawing.Point(6, 71);
            this.btn_changePreviewFont.Name = "btn_changePreviewFont";
            this.btn_changePreviewFont.Size = new System.Drawing.Size(141, 23);
            this.btn_changePreviewFont.TabIndex = 2;
            this.btn_changePreviewFont.Text = "Change preview font";
            this.btn_changePreviewFont.UseVisualStyleBackColor = true;
            this.btn_changePreviewFont.Click += new System.EventHandler(this.btn_changePreviewFont_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(117, 471);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(198, 471);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(279, 471);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // gb_general
            // 
            this.gb_general.Controls.Add(this.check_confirmReset);
            this.gb_general.Controls.Add(this.check_restorePrevSess);
            this.gb_general.Location = new System.Drawing.Point(12, 13);
            this.gb_general.Name = "gb_general";
            this.gb_general.Size = new System.Drawing.Size(334, 87);
            this.gb_general.TabIndex = 4;
            this.gb_general.TabStop = false;
            this.gb_general.Text = "General";
            // 
            // check_restorePrevSess
            // 
            this.check_restorePrevSess.AutoSize = true;
            this.check_restorePrevSess.Checked = global::StreamCounter.Properties.Settings.Default.RestorePrevSess;
            this.check_restorePrevSess.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::StreamCounter.Properties.Settings.Default, "RestorePrevSess", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.check_restorePrevSess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_restorePrevSess.Location = new System.Drawing.Point(6, 19);
            this.check_restorePrevSess.Name = "check_restorePrevSess";
            this.check_restorePrevSess.Size = new System.Drawing.Size(282, 24);
            this.check_restorePrevSess.TabIndex = 1;
            this.check_restorePrevSess.Text = "Restore previous session on startup";
            this.check_restorePrevSess.UseVisualStyleBackColor = true;
            // 
            // gb_advanced
            // 
            this.gb_advanced.Controls.Add(this.check_noText);
            this.gb_advanced.Controls.Add(this.btn_changePreviewFont);
            this.gb_advanced.Controls.Add(this.btn_changeOutput);
            this.gb_advanced.Location = new System.Drawing.Point(12, 106);
            this.gb_advanced.Name = "gb_advanced";
            this.gb_advanced.Size = new System.Drawing.Size(334, 100);
            this.gb_advanced.TabIndex = 5;
            this.gb_advanced.TabStop = false;
            this.gb_advanced.Text = "Advanced";
            // 
            // check_noText
            // 
            this.check_noText.AutoSize = true;
            this.check_noText.Checked = global::StreamCounter.Properties.Settings.Default.NoOutput;
            this.check_noText.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::StreamCounter.Properties.Settings.Default, "NoOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.check_noText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_noText.Location = new System.Drawing.Point(6, 19);
            this.check_noText.Name = "check_noText";
            this.check_noText.Size = new System.Drawing.Size(310, 24);
            this.check_noText.TabIndex = 0;
            this.check_noText.Text = "Do not output text file. Use only preview.";
            this.check_noText.UseVisualStyleBackColor = true;
            // 
            // check_confirmReset
            // 
            this.check_confirmReset.AutoSize = true;
            this.check_confirmReset.Checked = global::StreamCounter.Properties.Settings.Default.ConfirmReset;
            this.check_confirmReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_confirmReset.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::StreamCounter.Properties.Settings.Default, "ConfirmReset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.check_confirmReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_confirmReset.Location = new System.Drawing.Point(6, 49);
            this.check_confirmReset.Name = "check_confirmReset";
            this.check_confirmReset.Size = new System.Drawing.Size(181, 24);
            this.check_confirmReset.TabIndex = 2;
            this.check_confirmReset.Text = "Confirm counter reset";
            this.check_confirmReset.UseVisualStyleBackColor = true;
            // 
            // btn_resetSettings
            // 
            this.btn_resetSettings.Location = new System.Drawing.Point(12, 471);
            this.btn_resetSettings.Name = "btn_resetSettings";
            this.btn_resetSettings.Size = new System.Drawing.Size(75, 23);
            this.btn_resetSettings.TabIndex = 6;
            this.btn_resetSettings.Text = "Reset";
            this.btn_resetSettings.UseVisualStyleBackColor = true;
            this.btn_resetSettings.Click += new System.EventHandler(this.btn_resetSettings_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 500);
            this.Controls.Add(this.btn_resetSettings);
            this.Controls.Add(this.gb_advanced);
            this.Controls.Add(this.gb_general);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.gb_general.ResumeLayout(false);
            this.gb_general.PerformLayout();
            this.gb_advanced.ResumeLayout(false);
            this.gb_advanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.CheckBox check_noText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_changeOutput;
        private System.Windows.Forms.Button btn_changePreviewFont;
        private System.Windows.Forms.CheckBox check_restorePrevSess;
        private System.Windows.Forms.GroupBox gb_general;
        private System.Windows.Forms.GroupBox gb_advanced;
        private System.Windows.Forms.CheckBox check_confirmReset;
        private System.Windows.Forms.Button btn_resetSettings;
    }
}