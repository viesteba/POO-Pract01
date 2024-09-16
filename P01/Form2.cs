using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form2 : Form
    {
        private int i;
        public Form2()
        {
            i = 0;
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has hecho clic " + i + " veces.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
