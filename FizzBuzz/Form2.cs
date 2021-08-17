using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            textBoxInput.TextChanged += TextBoxInput_TextChanged;
            buttonAccept.Enabled = false;
            buttonAccept.Click += ButtonAccept_Click;

            FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonAccept_Click(object? sender, EventArgs e)
        {
            Variables.startingNumber = int.Parse(textBoxInput.Text);
            Form3 f3 = new Form3();
            f3.Show(this);
            this.Hide();
        }

        private void TextBoxInput_TextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text.Trim(), out int result))
                buttonAccept.Enabled = true;
            else
                buttonAccept.Enabled = false;
        }
    }
}
