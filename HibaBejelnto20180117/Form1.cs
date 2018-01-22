using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HibaBejelnto20180117
{
    public partial class Form1 : Form
    {
        List<HibaClass> FelhAdatok = new List<HibaClass>();

        public Form1()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FelhAdatok.Add(new HibaClass(textBox1.Text, dateTimePicker1.Value, textBox2.Text));
        }
    }
     
}
