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
            TextBox[] components = {ClassAInputTextBox, ClassBInputTextBox, ClassCInputTextBox, ClassAOutputTextBox, ClassBOutputTextBox, ClassCOutputTextBox, TotalOutputTextBox};

            for (int i = 0; i < components.Length; i++) {
                components[i].Text = "";
            }

            ValidationErrorLabel.Visible = false;
        }
    }
}
