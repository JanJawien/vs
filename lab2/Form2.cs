using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e) {
            textBox1.Text = "";
        }

        private void button2_Click(object sender,EventArgs e) {
            textBox2.Text = "";
        }

        private void button3_Click(object sender,EventArgs e) {
            textBox3.Text = "";
        }

        private void button4_Click(object sender,EventArgs e) {
            double a;
            double b;
            double c;
            double delta;
            string message;
            double sq1;
            double sq2;

            try {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
            } catch(Exception ex) {
                a = double.NaN;
                b = double.NaN;
                c = double.NaN;
            }

            delta = b*b - 4*a*c;


            if(double.IsNaN(delta)) {
                message = "Podane argumenty nie były liczbami"; // treść
            } else if(delta < 0) {
                message = "Brak pierwiastków - delta ujemna: " + delta; // treść
            } else {
                sq1 = (-b - Math.Sqrt(delta)) / (2 * a);
                sq2 = (-b + Math.Sqrt(delta)) / (2 * a);

                message = "Pierwszy pierwiastek: " + sq1 + "\nDrugi pierwiastek: " + sq2; // treść
            }


            // Initializes the variables to pass to the MessageBox.Show method.
            string caption = "Pierwiastki"; // tytuł
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            MessageBox.Show(message,caption,buttons);

        }

        private void button5_Click(object sender,EventArgs e) {
            this.Close();
        }

        private void textBox1_TextChanged(object sender,EventArgs e) {

        }
    }
}
