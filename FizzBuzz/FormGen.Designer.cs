
namespace FizzBuzz
{
    partial class FormGen
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
            this.textBoxLowest = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxHighest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input lowest number:";
            // 
            // textBoxLowest
            // 
            this.textBoxLowest.Location = new System.Drawing.Point(12, 27);
            this.textBoxLowest.Name = "textBoxLowest";
            this.textBoxLowest.Size = new System.Drawing.Size(100, 23);
            this.textBoxLowest.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Make Me A List!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxHighest
            // 
            this.textBoxHighest.Location = new System.Drawing.Point(157, 27);
            this.textBoxHighest.Name = "textBoxHighest";
            this.textBoxHighest.Size = new System.Drawing.Size(100, 23);
            this.textBoxHighest.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input highest number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 353);
            this.textBox1.TabIndex = 4;
            // 
            // FormGen
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxHighest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLowest);
            this.Controls.Add(this.label1);
            this.Name = "FormGen";
            this.Text = "FormGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLowest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxHighest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}