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
    public partial class FormGame : Form
    {
        private bool GameLive = false;
        private DateTime _lastInput;

        public FormGame()
        {
            InitializeComponent();

            textBox1.Text = "Press any buttons to start!";

            buttonFizz.Click += Button_Click;
            buttonBuzz.Click += Button_Click;
            buttonFizzBuzz.Click += Button_Click;
            buttonN.Click += Button_Click;

            buttonFizz.KeyDown += Button_KeyDown;
            buttonBuzz.KeyDown += Button_KeyDown;
            buttonFizzBuzz.KeyDown += Button_KeyDown;
            buttonN.KeyDown += Button_KeyDown;

            FormClosing += FormGame_FormClosing;
        }

        private void FormGame_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_KeyDown(object? sender, KeyEventArgs e)
        {
            if (sender == null)
                throw new NullReferenceException("sender");
            
            switch (e.KeyCode)
            {
                case Keys.D1:
                    Button_Click(buttonFizz, e);
                    break;
                case Keys.D2:
                    Button_Click(buttonBuzz, e);
                    break;
                case Keys.D3:
                    Button_Click(buttonFizzBuzz, e);
                    break;
                case Keys.D4:
                    Button_Click(buttonN, e);
                    break;
                default:
                    throw new EBKAC_NotYouThough_Exception();
            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            if (!GameLive)
            {
                GameLive = true;
                Timer t = new Timer();
                t.Interval = 100;
                t.Tick += T_Tick;
                t.Enabled = true;
                _lastInput = DateTime.Now;
                textBox1.Text = Variables.startingNumber.ToString();
                return;
            }

            if (sender == null)
                throw new NullReferenceException("sender");

            float f = Variables.startingNumber;
            switch ((string)((Button)sender).Tag)
            {
                case "Fizz":
                    if (f % 3 == 0)
                        Correct();
                    else
                        Wrong();
                    break;
                case "Buzz":
                    if (f % 5 == 0)
                        Correct();
                    else
                        Wrong();
                    break;
                case "FizzBuzz":
                    if (f % 15 == 0)
                        Correct();
                    else
                        Wrong();
                    break;
                case "N":
                    if (f % 3 == 0 || f % 5 == 0 || f % 15 == 0)
                        Wrong();
                    else
                        Correct();
                    break;
                default:
                    throw new EBKAC_NotYouThough_Exception();
            }
        }

        private void Wrong()
        {
            this.Hide();
            Timer t = new Timer();
            t.Interval = 100;
            t.Tick += failed_timer_tick;
            t.Enabled = true;
            GameLive = false;
        }

        int cnt = 0;
        private void failed_timer_tick(object? sender, EventArgs e)
        {
            if (cnt++ == 50)
                Environment.Exit(0);

            MessageBox.Show("You failed!", "Unrecoverable Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Correct()
        {
            _lastInput = DateTime.Now;
            Variables.startingNumber++;
            textBox1.Text = Variables.startingNumber.ToString();
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            if (Variables.EnableTimer)
            {
                TimeSpan timeLeft = _lastInput.AddSeconds(Variables.Seconds) - DateTime.Now;
                int timeLeftPercent = (int)(((float)timeLeft.TotalMilliseconds / (Variables.Seconds * 1000)) * 255);

                if (timeLeftPercent < 0)
                {
                    Wrong();

                    if (sender != null)
                        ((Timer)sender).Enabled = false;
                    return;
                }

                textBox1.BackColor = Color.FromArgb(255, timeLeftPercent, timeLeftPercent);
            }
        }
    }
}
