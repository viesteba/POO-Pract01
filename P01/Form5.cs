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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.button3 = new System.Windows.Forms.Button();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 215);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.Controls.Add(this.button3);
            this.button3.Click += new System.EventHandler(this.button3_Click);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola.");
        }
        }
}
