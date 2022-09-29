namespace Oefening7
{
    partial class Sum
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.NumberOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(58, 15);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(51, 15);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Number";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(115, 53);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // NumberInput
            // 
            this.NumberInput.Location = new System.Drawing.Point(115, 12);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.Size = new System.Drawing.Size(127, 23);
            this.NumberInput.TabIndex = 2;
            // 
            // NumberOutput
            // 
            this.NumberOutput.Location = new System.Drawing.Point(8, 93);
            this.NumberOutput.Name = "NumberOutput";
            this.NumberOutput.ReadOnly = true;
            this.NumberOutput.Size = new System.Drawing.Size(293, 23);
            this.NumberOutput.TabIndex = 3;
            this.NumberOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 130);
            this.Controls.Add(this.NumberOutput);
            this.Controls.Add(this.NumberInput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.NumberLabel);
            this.Name = "Sum";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NumberLabel;
        private Button btnCalculate;
        private TextBox NumberInput;
        private TextBox NumberOutput;
    }
}