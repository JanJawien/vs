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
    public partial class Form4 : Form {
        List<Osoba> lista = new List<Osoba>();
        int index = -1;


        public Form4() {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e) {
            // Edit
            if(index == -1) return;
            lista.ElementAt(index).edit(textBox1.Text,textBox2.Text,textBox3.Text);
        }

        private void button2_Click(object sender,EventArgs e) {
            // Add
            Osoba newos = Osoba.newOsoba(textBox1.Text, textBox2.Text, textBox3.Text);
            if(newos == null) return;

            lista.Add(newos);
            newos = null;
            label4.Text = (++index + 1).ToString();
        }

        private void button3_Click(object sender,EventArgs e) {
            if(index <= 0) return;
            label4.Text = (--index + 1).ToString();

            textBox1.Text = lista.ElementAt(index).getImie();
            textBox2.Text = lista.ElementAt(index).getNazwisko();
            textBox3.Text = lista.ElementAt(index).getNumer().ToString();
        }

        private void button4_Click(object sender,EventArgs e) {
            if(index+1 >= lista.Count) return;
            label4.Text = (++index + 1).ToString();

            textBox1.Text = lista.ElementAt(index).getImie();
            textBox2.Text = lista.ElementAt(index).getNazwisko();
            textBox3.Text = lista.ElementAt(index).getNumer().ToString();
        }
    }
}
