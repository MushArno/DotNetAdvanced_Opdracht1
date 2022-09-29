namespace Oefening2
{
    partial class IsItBigger
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
            this.Calculation1 = new System.Windows.Forms.Label();
            this.Calculation2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculation1
            // 
            this.Calculation1.AutoSize = true;
            this.Calculation1.Location = new System.Drawing.Point(331, 131);
            this.Calculation1.Name = "Calculation1";
            this.Calculation1.Size = new System.Drawing.Size(12, 15);
            this.Calculation1.TabIndex = 0;
            this.Calculation1.Text = "?";
            // 
            // Calculation2
            // 
            this.Calculation2.AutoSize = true;
            this.Calculation2.Location = new System.Drawing.Point(331, 196);
            this.Calculation2.Name = "Calculation2";
            this.Calculation2.Size = new System.Drawing.Size(12, 15);
            this.Calculation2.TabIndex = 1;
            this.Calculation2.Text = "?";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(331, 256);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(174, 15);
            this.Result.TabIndex = 2;
            this.Result.Text = "12345 * 54321 > 22222 * 33333 =";
            // 
            // IsItBigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Calculation2);
            this.Controls.Add(this.Calculation1);
            this.Name = "IsItBigger";
            this.Text = "IsItBigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Calculation1;
        private Label Calculation2;
        private Label Result;
    }
}