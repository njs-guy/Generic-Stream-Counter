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
            this.splitCont_options = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont_options)).BeginInit();
            this.splitCont_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitCont_options
            // 
            this.splitCont_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCont_options.Location = new System.Drawing.Point(0, 0);
            this.splitCont_options.Name = "splitCont_options";
            this.splitCont_options.Size = new System.Drawing.Size(800, 450);
            this.splitCont_options.SplitterDistance = 266;
            this.splitCont_options.TabIndex = 0;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitCont_options);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitCont_options)).EndInit();
            this.splitCont_options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCont_options;
    }
}