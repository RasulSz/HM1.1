namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baku = new System.Windows.Forms.Button();
            this.london = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baku
            // 
            this.baku.Location = new System.Drawing.Point(85, 185);
            this.baku.Name = "baku";
            this.baku.Size = new System.Drawing.Size(75, 23);
            this.baku.TabIndex = 0;
            this.baku.Text = "Baku";
            this.baku.MouseClick += new System.Windows.Forms.MouseEventHandler(this.baku_Click);
            // 
            // london
            // 
            this.london.Location = new System.Drawing.Point(625, 185);
            this.london.Name = "london";
            this.london.Size = new System.Drawing.Size(75, 23);
            this.london.TabIndex = 1;
            this.london.Text = "London";
            this.london.UseVisualStyleBackColor = true;
            this.london.MouseClick += new System.Windows.Forms.MouseEventHandler(this.london_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.london);
            this.Controls.Add(this.baku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button baku;
        private Button london;
    }
}