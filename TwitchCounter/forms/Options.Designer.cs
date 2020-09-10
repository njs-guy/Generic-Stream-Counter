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
            this.tab_options = new System.Windows.Forms.TabControl();
            this.options_general = new System.Windows.Forms.TabPage();
            this.options_advanced = new System.Windows.Forms.TabPage();
            this.check_AoT = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.check_noText = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_changePreviewFont = new System.Windows.Forms.Button();
            this.btn_changeOutput = new System.Windows.Forms.Button();
            this.tab_options.SuspendLayout();
            this.options_general.SuspendLayout();
            this.options_advanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_options
            // 
            this.tab_options.Controls.Add(this.options_general);
            this.tab_options.Controls.Add(this.options_advanced);
            this.tab_options.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_options.Location = new System.Drawing.Point(0, 0);
            this.tab_options.Name = "tab_options";
            this.tab_options.SelectedIndex = 0;
            this.tab_options.Size = new System.Drawing.Size(358, 469);
            this.tab_options.TabIndex = 0;
            // 
            // options_general
            // 
            this.options_general.Controls.Add(this.check_AoT);
            this.options_general.Location = new System.Drawing.Point(4, 22);
            this.options_general.Name = "options_general";
            this.options_general.Padding = new System.Windows.Forms.Padding(3);
            this.options_general.Size = new System.Drawing.Size(350, 443);
            this.options_general.TabIndex = 0;
            this.options_general.Text = "General";
            this.options_general.UseVisualStyleBackColor = true;
            // 
            // options_advanced
            // 
            this.options_advanced.Controls.Add(this.btn_changeOutput);
            this.options_advanced.Controls.Add(this.btn_changePreviewFont);
            this.options_advanced.Controls.Add(this.check_noText);
            this.options_advanced.Location = new System.Drawing.Point(4, 22);
            this.options_advanced.Name = "options_advanced";
            this.options_advanced.Padding = new System.Windows.Forms.Padding(3);
            this.options_advanced.Size = new System.Drawing.Size(350, 443);
            this.options_advanced.TabIndex = 1;
            this.options_advanced.Text = "Advanced";
            this.options_advanced.UseVisualStyleBackColor = true;
            // 
            // check_AoT
            // 
            this.check_AoT.AutoSize = true;
            this.check_AoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_AoT.Location = new System.Drawing.Point(9, 7);
            this.check_AoT.Name = "check_AoT";
            this.check_AoT.Size = new System.Drawing.Size(126, 24);
            this.check_AoT.TabIndex = 0;
            this.check_AoT.Text = "Always on top";
            this.check_AoT.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(279, 471);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(198, 471);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(117, 471);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // check_noText
            // 
            this.check_noText.AutoSize = true;
            this.check_noText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_noText.Location = new System.Drawing.Point(4, 7);
            this.check_noText.Name = "check_noText";
            this.check_noText.Size = new System.Drawing.Size(278, 24);
            this.check_noText.TabIndex = 0;
            this.check_noText.Text = "Do not output text file. Preview only.";
            this.check_noText.UseVisualStyleBackColor = true;
            // 
            // btn_changePreviewFont
            // 
            this.btn_changePreviewFont.Location = new System.Drawing.Point(8, 68);
            this.btn_changePreviewFont.Name = "btn_changePreviewFont";
            this.btn_changePreviewFont.Size = new System.Drawing.Size(114, 23);
            this.btn_changePreviewFont.TabIndex = 2;
            this.btn_changePreviewFont.Text = "Change preview font";
            this.btn_changePreviewFont.UseVisualStyleBackColor = true;
            // 
            // btn_changeOutput
            // 
            this.btn_changeOutput.Location = new System.Drawing.Point(128, 68);
            this.btn_changeOutput.Name = "btn_changeOutput";
            this.btn_changeOutput.Size = new System.Drawing.Size(141, 23);
            this.btn_changeOutput.TabIndex = 3;
            this.btn_changeOutput.Text = "Change output location";
            this.btn_changeOutput.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 500);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tab_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.tab_options.ResumeLayout(false);
            this.options_general.ResumeLayout(false);
            this.options_general.PerformLayout();
            this.options_advanced.ResumeLayout(false);
            this.options_advanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_options;
        private System.Windows.Forms.TabPage options_general;
        private System.Windows.Forms.TabPage options_advanced;
        private System.Windows.Forms.CheckBox check_AoT;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.CheckBox check_noText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_changeOutput;
        private System.Windows.Forms.Button btn_changePreviewFont;
    }
}