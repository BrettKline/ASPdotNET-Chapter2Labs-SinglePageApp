namespace ProgrammingExercise9
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLotRes1 = new System.Windows.Forms.Label();
            this.labelLotRes2 = new System.Windows.Forms.Label();
            this.labelLotRes3 = new System.Windows.Forms.Label();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the super lottery!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter 3 numbers between 1 and 4.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 38);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 38);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(31, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lottery results:";
            // 
            // labelLotRes1
            // 
            this.labelLotRes1.AutoSize = true;
            this.labelLotRes1.Location = new System.Drawing.Point(5, 130);
            this.labelLotRes1.Name = "labelLotRes1";
            this.labelLotRes1.Size = new System.Drawing.Size(13, 13);
            this.labelLotRes1.TabIndex = 6;
            this.labelLotRes1.Text = "0";
            // 
            // labelLotRes2
            // 
            this.labelLotRes2.AutoSize = true;
            this.labelLotRes2.Location = new System.Drawing.Point(69, 130);
            this.labelLotRes2.Name = "labelLotRes2";
            this.labelLotRes2.Size = new System.Drawing.Size(13, 13);
            this.labelLotRes2.TabIndex = 7;
            this.labelLotRes2.Text = "0";
            // 
            // labelLotRes3
            // 
            this.labelLotRes3.AutoSize = true;
            this.labelLotRes3.Location = new System.Drawing.Point(133, 130);
            this.labelLotRes3.Name = "labelLotRes3";
            this.labelLotRes3.Size = new System.Drawing.Size(13, 13);
            this.labelLotRes3.TabIndex = 8;
            this.labelLotRes3.Text = "0";
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(6, 64);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(167, 23);
            this.buttonRoll.TabIndex = 9;
            this.buttonRoll.Text = "Roll the dice";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 158);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 261);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.labelLotRes3);
            this.Controls.Add(this.labelLotRes2);
            this.Controls.Add(this.labelLotRes1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLotRes1;
        private System.Windows.Forms.Label labelLotRes2;
        private System.Windows.Forms.Label labelLotRes3;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Label labelResult;
    }
}

