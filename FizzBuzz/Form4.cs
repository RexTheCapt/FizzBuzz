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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            buttonAccept.Enabled = false;

            buttonAccept.Click += ButtonAccept_Click;

            textBox1.TextChanged += TextBox1_TextChanged;

            FormClosing += Form4_FormClosing;
        }

        private void Form4_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            buttonAccept.Enabled = int.TryParse(textBox1.Text.Trim(), out _);
        }

        private void ButtonAccept_Click(object? sender, EventArgs e)
        {
            Variables.Seconds = int.Parse(textBox1.Text.Trim());
            FormGame fg = new FormGame();
            fg.Show(this);
            this.Hide();
        }
    }
}
