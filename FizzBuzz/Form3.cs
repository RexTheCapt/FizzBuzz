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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            buttonYes.KeyDown += Button_KeyDown;
            buttonNo.KeyDown += Button_KeyDown;

            buttonYes.Click += ButtonYes_Click;
            buttonNo.Click += ButtonNo_Click;

            FormClosing += Form3_FormClosing;
        }

        private void Form3_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonNo_Click(object? sender, EventArgs e)
        {
            Variables.EnableTimer = false;
            FormGame fg = new FormGame();
            fg.Show();
            this.Hide();
        }

        private void ButtonYes_Click(object? sender, EventArgs e)
        {
            Variables.EnableTimer = true;
            Form4 f4 = new Form4();
            f4.Show(this);
            this.Hide();
        }

        private void Button_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    ButtonYes_Click(sender, e);
                    break;
                case Keys.D2:
                    ButtonNo_Click(sender, e);
                    break;
            }
        }
    }
}
