using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = textBox5.Text.ToUpper() + "-" + textBox6.Text[0].ToString().ToUpper() + textBox6.Text.ToLower().Substring(1, textBox6.Text.Length-1); // treść
            string caption = "Imie i nazwisko"; // tytuł
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
