using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_AndreiKazakov
{
    public partial class Form1 : Form
    {
        private static decimal[] COSTS = { 15m, 12m, 9m };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearOutputs();

            TextBox[] components = { ClassAInputTextBox, ClassBInputTextBox, ClassCInputTextBox };

            foreach (TextBox component in components)
            {
                component.Text = "";
            }

            ValidationErrorLabel.Visible = false;

            components[0].Focus();
        }

        private void ClearOutputs()
        {
            TextBox[] components = { ClassAOutputTextBox, ClassBOutputTextBox, ClassCOutputTextBox, TotalOutputTextBox };

            foreach (TextBox component in components)
            {
                component.Text = "";
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ValidationErrorLabel.Visible = false;

            TextBox[] inputs = { ClassAInputTextBox, ClassBInputTextBox, ClassCInputTextBox };
            TextBox[] outputs = { ClassAOutputTextBox, ClassBOutputTextBox, ClassCOutputTextBox };

            try
            {
                decimal total = 0;

                for (int i = 0; i < inputs.Length; i++)
                {
                    int value = Int32.Parse(inputs[i].Text);
                    if (value < 0)
                    {
                        throw new FormatException("value should be >= 0");
                    }

                    decimal result = value * COSTS[i];
                    outputs[i].Text = result.ToString("C");

                    total += result;
                }

                TotalOutputTextBox.Text = total.ToString("C");
            }
            catch (FormatException)
            {
                this.ClearOutputs();
                ValidationErrorLabel.Visible = true;
            }

            inputs[0].Focus();
        }
    }
}
