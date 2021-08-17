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
    public partial class Form1 : Form
    {
        // Rules of FizzBuzz: (WikiPedia)
        // Players generally sit in a circle.
        // The player designated to go first says the number "1", and the players then count upwards in turn.
        // However, any number divisible by three is replaced by the word fizz
        // Any number divisible by five by the word buzz.
        // Numbers divisible by 15 become fizz buzz.
        // A player who hesitates or makes a mistake is eliminated from the game.

        public Form1()
        {
            InitializeComponent();

            buttonGenerate.KeyDown += Buttons_KeyDown;
            buttonPlay.KeyDown += Buttons_KeyDown;

            buttonGenerate.Click += ButtonGenerate_Click;
            buttonPlay.Click += ButtonPlay_Click;

            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonPlay_Click(object? sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(this);
            this.Hide();
        }

        private void ButtonGenerate_Click(object? sender, EventArgs e)
        {
            FormGen fg = new FormGen();
            fg.Show(this);
            this.Hide();
        }

        private void Buttons_KeyDown(object? sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D1:
                    ButtonGenerate_Click(sender, e);
                    break;
                case Keys.D2:
                    ButtonPlay_Click(sender, e);
                    break;
            }
        }
    }
}
