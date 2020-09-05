namespace TwitchCounter
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lbl_howtouse = new System.Windows.Forms.Label();
            this.lbl_step1 = new System.Windows.Forms.Label();
            this.lbl_step2 = new System.Windows.Forms.Label();
            this.lbl_step3 = new System.Windows.Forms.Label();
            this.lbl_step4 = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_howtouse
            // 
            this.lbl_howtouse.AutoSize = true;
            this.lbl_howtouse.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_howtouse.Location = new System.Drawing.Point(12, 9);
            this.lbl_howtouse.Name = "lbl_howtouse";
            this.lbl_howtouse.Size = new System.Drawing.Size(216, 45);
            this.lbl_howtouse.TabIndex = 1;
            this.lbl_howtouse.Text = "How to use";
            // 
            // lbl_step1
            // 
            this.lbl_step1.AutoEllipsis = true;
            this.lbl_step1.AutoSize = true;
            this.lbl_step1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step1.Location = new System.Drawing.Point(16, 54);
            this.lbl_step1.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_step1.Name = "lbl_step1";
            this.lbl_step1.Size = new System.Drawing.Size(496, 88);
            this.lbl_step1.TabIndex = 3;
            this.lbl_step1.Text = "1. Next to text, type the label. This could be something such as “Deaths:” or “Re" +
    "sets:” without the quotes. Or with the quotes. It’s entirely up to you but make " +
    "sure it makes sense.";
            // 
            // lbl_step2
            // 
            this.lbl_step2.AutoEllipsis = true;
            this.lbl_step2.AutoSize = true;
            this.lbl_step2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step2.Location = new System.Drawing.Point(16, 151);
            this.lbl_step2.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_step2.Name = "lbl_step2";
            this.lbl_step2.Size = new System.Drawing.Size(483, 44);
            this.lbl_step2.TabIndex = 4;
            this.lbl_step2.Text = "2. Count is the number being kept track of. If you have 5 deaths, for example, th" +
    "e counter should be at 5.";
            // 
            // lbl_step3
            // 
            this.lbl_step3.AutoEllipsis = true;
            this.lbl_step3.AutoSize = true;
            this.lbl_step3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step3.Location = new System.Drawing.Point(16, 208);
            this.lbl_step3.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_step3.Name = "lbl_step3";
            this.lbl_step3.Size = new System.Drawing.Size(486, 66);
            this.lbl_step3.TabIndex = 5;
            this.lbl_step3.Text = "3. Click update to update the counter_output.txt file with the current count and " +
    "label. Click update again whenever the counter needs to be refreshed.";
            // 
            // lbl_step4
            // 
            this.lbl_step4.AutoEllipsis = true;
            this.lbl_step4.AutoSize = true;
            this.lbl_step4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step4.Location = new System.Drawing.Point(16, 284);
            this.lbl_step4.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_step4.Name = "lbl_step4";
            this.lbl_step4.Size = new System.Drawing.Size(500, 154);
            this.lbl_step4.TabIndex = 6;
            this.lbl_step4.Text = resources.GetString("lbl_step4.Text");
            // 
            // lbl_note
            // 
            this.lbl_note.AutoEllipsis = true;
            this.lbl_note.AutoSize = true;
            this.lbl_note.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.Location = new System.Drawing.Point(16, 472);
            this.lbl_note.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(458, 69);
            this.lbl_note.TabIndex = 7;
            this.lbl_note.Text = "NOTE: If you do not stream with OBS, this process should be the same as reading f" +
    "rom a text file if the software supports it.";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 554);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Optional: You can enable the GTC window to always be on top in options > always o" +
    "n top.";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(561, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.lbl_step4);
            this.Controls.Add(this.lbl_step3);
            this.Controls.Add(this.lbl_step2);
            this.Controls.Add(this.lbl_step1);
            this.Controls.Add(this.lbl_howtouse);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_howtouse;
        private System.Windows.Forms.Label lbl_step1;
        private System.Windows.Forms.Label lbl_step2;
        private System.Windows.Forms.Label lbl_step3;
        private System.Windows.Forms.Label lbl_step4;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label label1;
    }
}