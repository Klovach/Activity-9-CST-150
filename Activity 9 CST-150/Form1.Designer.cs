namespace Activity_9_CST_150
{
    partial class Form1
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
            this.rtxStatistics = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxStatistics
            // 
            this.rtxStatistics.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtxStatistics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtxStatistics.ForeColor = System.Drawing.Color.Black;
            this.rtxStatistics.Location = new System.Drawing.Point(0, 64);
            this.rtxStatistics.Name = "rtxStatistics";
            this.rtxStatistics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtxStatistics.Size = new System.Drawing.Size(800, 386);
            this.rtxStatistics.TabIndex = 0;
            this.rtxStatistics.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistics(Method Results) :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxStatistics);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Activity 9 - Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxStatistics;
        private System.Windows.Forms.Label label1;
    }
}

