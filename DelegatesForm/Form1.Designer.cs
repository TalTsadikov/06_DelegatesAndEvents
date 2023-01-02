namespace DelegatesForm
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Calculations = new System.Windows.Forms.ComboBox();
            this.firstInput = new System.Windows.Forms.TextBox();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(347, 275);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Calculations
            // 
            this.Calculations.FormattingEnabled = true;
            this.Calculations.Items.AddRange(new object[] {
            "Add",
            "Substract",
            "Multiply",
            "Divide",
            "Power",
            "Root"});
            this.Calculations.Location = new System.Drawing.Point(322, 206);
            this.Calculations.Name = "Calculations";
            this.Calculations.Size = new System.Drawing.Size(121, 21);
            this.Calculations.TabIndex = 1;
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(194, 146);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(100, 20);
            this.firstInput.TabIndex = 2;
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(476, 145);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(100, 20);
            this.secondInput.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultLabel.Location = new System.Drawing.Point(362, 352);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.Calculations);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ComboBox Calculations;
        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Label resultLabel;
    }
}

