namespace Opdracht5
{
    partial class CelciusToFahrenheit
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
            this.CelsiusLabel = new System.Windows.Forms.Label();
            this.FahrenheitLabel = new System.Windows.Forms.Label();
            this.CelsiusBox = new System.Windows.Forms.TextBox();
            this.FahrenheitBox = new System.Windows.Forms.TextBox();
            this.CtoFButton = new System.Windows.Forms.Button();
            this.FtoCButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CelsiusLabel
            // 
            this.CelsiusLabel.AutoSize = true;
            this.CelsiusLabel.Location = new System.Drawing.Point(64, 65);
            this.CelsiusLabel.Name = "CelsiusLabel";
            this.CelsiusLabel.Size = new System.Drawing.Size(44, 15);
            this.CelsiusLabel.TabIndex = 0;
            this.CelsiusLabel.Text = "Celsius";
            // 
            // FahrenheitLabel
            // 
            this.FahrenheitLabel.AutoSize = true;
            this.FahrenheitLabel.Location = new System.Drawing.Point(182, 65);
            this.FahrenheitLabel.Name = "FahrenheitLabel";
            this.FahrenheitLabel.Size = new System.Drawing.Size(63, 15);
            this.FahrenheitLabel.TabIndex = 1;
            this.FahrenheitLabel.Text = "Fahrenheit";
            // 
            // CelsiusBox
            // 
            this.CelsiusBox.Location = new System.Drawing.Point(37, 83);
            this.CelsiusBox.Name = "CelsiusBox";
            this.CelsiusBox.Size = new System.Drawing.Size(100, 23);
            this.CelsiusBox.TabIndex = 2;
            // 
            // FahrenheitBox
            // 
            this.FahrenheitBox.Location = new System.Drawing.Point(160, 83);
            this.FahrenheitBox.Name = "FahrenheitBox";
            this.FahrenheitBox.Size = new System.Drawing.Size(100, 23);
            this.FahrenheitBox.TabIndex = 3;
            // 
            // CtoFButton
            // 
            this.CtoFButton.Location = new System.Drawing.Point(49, 112);
            this.CtoFButton.Name = "CtoFButton";
            this.CtoFButton.Size = new System.Drawing.Size(75, 23);
            this.CtoFButton.TabIndex = 4;
            this.CtoFButton.Text = "C to F";
            this.CtoFButton.UseVisualStyleBackColor = true;
            this.CtoFButton.Click += new System.EventHandler(this.CtoFButton_Click);
            // 
            // FtoCButton
            // 
            this.FtoCButton.Location = new System.Drawing.Point(170, 112);
            this.FtoCButton.Name = "FtoCButton";
            this.FtoCButton.Size = new System.Drawing.Size(75, 23);
            this.FtoCButton.TabIndex = 5;
            this.FtoCButton.Text = "F to C";
            this.FtoCButton.UseVisualStyleBackColor = true;
            this.FtoCButton.Click += new System.EventHandler(this.FtoCButton_Click);
            // 
            // CelciusToFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 201);
            this.Controls.Add(this.FtoCButton);
            this.Controls.Add(this.CtoFButton);
            this.Controls.Add(this.FahrenheitBox);
            this.Controls.Add(this.CelsiusBox);
            this.Controls.Add(this.FahrenheitLabel);
            this.Controls.Add(this.CelsiusLabel);
            this.Name = "CelciusToFahrenheit";
            this.Text = "CelciusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CelsiusLabel;
        private Label FahrenheitLabel;
        private TextBox CelsiusBox;
        private TextBox FahrenheitBox;
        private Button CtoFButton;
        private Button FtoCButton;
    }
}