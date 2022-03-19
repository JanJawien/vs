using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab2 {
    class MsgBox {
        public static void OK(string title, string msg) {
            // Displays the MessageBox.
            MessageBox.Show(msg, title, MessageBoxButtons.OK);
        }
    }
}
