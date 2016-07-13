using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forecast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           // DateTime dt = DateTime.ParseExact(btext.Text, "ddMyyyy", null);
            //rtext.Text += dt.Date.ToShortDateString();
            //DateTime dt = DateTime.ParseExact(cal.SelectionStart.ToShortDateString().ToString(), "ddMyyyy", null);
            rtext.Text += cal.SelectionStart.ToOADate() + "\n";
            textBox1.Text = DateTime.FromOADate(40881).ToShortDateString().ToString();
            //textBox1.Text = DateTime.FromOADate(cal.SelectionStart.ToOADate()).ToShortDateString().ToString();
        }
    }
}
