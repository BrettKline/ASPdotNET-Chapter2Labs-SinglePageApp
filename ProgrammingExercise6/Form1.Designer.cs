namespace ProgrammingExercise6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBMonth = new System.Windows.Forms.TextBox();
            this.textBoxBDay = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birth Month (as number):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birth Day (as number):";
            // 
            // textBoxBMonth
            // 
            this.textBoxBMonth.Location = new System.Drawing.Point(15, 24);
            this.textBoxBMonth.Name = "textBoxBMonth";
            this.textBoxBMonth.Size = new System.Drawing.Size(108, 20);
            this.textBoxBMonth.TabIndex = 2;
            // 
            // textBoxBDay
            // 
            this.textBoxBDay.Location = new System.Drawing.Point(15, 63);
            this.textBoxBDay.Name = "textBoxBDay";
            this.textBoxBDay.Size = new System.Drawing.Size(108, 20);
            this.textBoxBDay.TabIndex = 3;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(15, 89);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(119, 23);
            this.buttonValidate.TabIndex = 4;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 115);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 177);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxBDay);
            this.Controls.Add(this.textBoxBMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBMonth;
        private System.Windows.Forms.TextBox textBoxBDay;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label labelResult;
    }
}

