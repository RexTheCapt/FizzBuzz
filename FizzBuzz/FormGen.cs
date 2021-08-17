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
    public partial class FormGen : Form
    {
        private int? Lowest
        {
            get
            {
                if (int.TryParse(textBoxLowest.Text.Trim(), out int result))
                    return result;
                else
                    return null;
            }
        }
        private int? Highest
        {
            get
            {
                if (int.TryParse(textBoxHighest.Text.Trim(), out int result))
                    return result;
                else
                    return null;
            }
        }

        public FormGen()
        {
            InitializeComponent();

            textBox1.ReadOnly = true;
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            textBoxHighest.TextChanged += InputTextChanged;
            textBoxLowest.TextChanged += InputTextChanged;

            button1.Enabled = false;
            button1.Click += GenerateList_ButtonClick;

            this.FormClosing += FormGen_FormClosing;
        }

        private void FormGen_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void GenerateList_ButtonClick(object? sender, EventArgs e)
        {
            textBox1.Text =
$@"Lowest number: {Lowest}
Highest number: {Highest}

";
            if (Lowest == null || Highest == null)
                throw new EBKAC_NotYouThough_Exception();

            OutputSomething[] outputSomethings = new OutputSomething[]
            {
                new OutputSomething(divider: 3, replacer: "Fizz"),
                new OutputSomething(divider: 5,  replacer: "Buzz"),
                new OutputSomething(divider: 15,  replacer: "FizzBuzz")
            };

            for (int i = (int)Lowest; i <= Highest; i++)
            {
                bool buzz = false;
                foreach (OutputSomething output in outputSomethings)
                    if (i % output.Divider == 0)
                    {
                        textBox1.Text += $"{output.Replacer} ";
                        buzz = true;
                    }

                if (!buzz)
                    textBox1.Text += $"{i}";

                textBox1.Text += Environment.NewLine;
            }
        }

        private void InputTextChanged(object? sender, EventArgs e)
        {
            if (Lowest == null || Highest == null)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}
