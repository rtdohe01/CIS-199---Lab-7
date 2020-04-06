namespace lab_7
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
            this.promptGrade = new System.Windows.Forms.Label();
            this.outputGrade = new System.Windows.Forms.Label();
            this.inputGrade = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptGrade
            // 
            this.promptGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promptGrade.Location = new System.Drawing.Point(11, 56);
            this.promptGrade.Name = "promptGrade";
            this.promptGrade.Size = new System.Drawing.Size(180, 30);
            this.promptGrade.TabIndex = 0;
            this.promptGrade.Text = "How many words?:";
            this.promptGrade.Click += new System.EventHandler(this.promptGrade_Click);
            // 
            // outputGrade
            // 
            this.outputGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputGrade.Location = new System.Drawing.Point(233, 137);
            this.outputGrade.Name = "outputGrade";
            this.outputGrade.Size = new System.Drawing.Size(177, 47);
            this.outputGrade.TabIndex = 1;
            // 
            // inputGrade
            // 
            this.inputGrade.Location = new System.Drawing.Point(233, 56);
            this.inputGrade.Name = "inputGrade";
            this.inputGrade.Size = new System.Drawing.Size(177, 29);
            this.inputGrade.TabIndex = 2;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(11, 137);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(180, 47);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 318);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.inputGrade);
            this.Controls.Add(this.outputGrade);
            this.Controls.Add(this.promptGrade);
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptGrade;
        private System.Windows.Forms.Label outputGrade;
        private System.Windows.Forms.TextBox inputGrade;
        private System.Windows.Forms.Button buttonCalc;
    }
}

