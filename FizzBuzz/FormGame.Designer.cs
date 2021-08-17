
namespace FizzBuzz
{
    partial class FormGame
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFizz = new System.Windows.Forms.Button();
            this.buttonBuzz = new System.Windows.Forms.Button();
            this.buttonFizzBuzz = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your number is:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFizz
            // 
            this.buttonFizz.Location = new System.Drawing.Point(12, 55);
            this.buttonFizz.Name = "buttonFizz";
            this.buttonFizz.Size = new System.Drawing.Size(75, 23);
            this.buttonFizz.TabIndex = 2;
            this.buttonFizz.Tag = "Fizz";
            this.buttonFizz.Text = "[1] Fizz";
            this.buttonFizz.UseVisualStyleBackColor = true;
            // 
            // buttonBuzz
            // 
            this.buttonBuzz.Location = new System.Drawing.Point(93, 55);
            this.buttonBuzz.Name = "buttonBuzz";
            this.buttonBuzz.Size = new System.Drawing.Size(75, 23);
            this.buttonBuzz.TabIndex = 3;
            this.buttonBuzz.Tag = "Buzz";
            this.buttonBuzz.Text = "[2] Buzz";
            this.buttonBuzz.UseVisualStyleBackColor = true;
            // 
            // buttonFizzBuzz
            // 
            this.buttonFizzBuzz.Location = new System.Drawing.Point(174, 55);
            this.buttonFizzBuzz.Name = "buttonFizzBuzz";
            this.buttonFizzBuzz.Size = new System.Drawing.Size(75, 23);
            this.buttonFizzBuzz.TabIndex = 4;
            this.buttonFizzBuzz.Tag = "FizzBuzz";
            this.buttonFizzBuzz.Text = "[3] FizzBuzz";
            this.buttonFizzBuzz.UseVisualStyleBackColor = true;
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(255, 55);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(75, 23);
            this.buttonN.TabIndex = 5;
            this.buttonN.Tag = "N";
            this.buttonN.Text = "[4] N";
            this.buttonN.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 84);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonFizzBuzz);
            this.Controls.Add(this.buttonBuzz);
            this.Controls.Add(this.buttonFizz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FizzBuzz Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFizz;
        private System.Windows.Forms.Button buttonBuzz;
        private System.Windows.Forms.Button buttonFizzBuzz;
        private System.Windows.Forms.Button buttonN;
    }
}