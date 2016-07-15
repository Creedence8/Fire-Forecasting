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
        public static List<Time_series> create_date_list(DateTime d)
        {
            List<Time_series>  flist = new List<Time_series>();
            flist.Add (new Time_series(d));
            for (int i=1; i<=32; i++)
            {
                flist.Add( new Time_series(d) );
                d = d.Date.AddDays(1);
            }
            return flist;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtext.Text = "";
            rtext.Text += create_date_list(cal.SelectionStart)[2].dt.Date.ToShortDateString() + "               ЮАО                    " + create_date_list(cal.SelectionStart)[2].value.ToString() + "                     " + Math.Round(create_date_list(cal.SelectionStart)[2].value).ToString() + "\n";
               
            //DateTime dt = DateTime.ParseExact("01021997", "ddMyyyy", null);
            ////rtext.Text += dt.Date.ToShortDateString();
            ////DateTime dt = DateTime.ParseExact(cal.SelectionStart.ToShortDateString().ToString(), "ddMyyyy", null);
            //rtext.Text += cal.SelectionStart.ToOADate() + "\n";
            //textBox1.Text = DateTime.FromOADate(cal.SelectionStart.ToOADate()).ToShortDateString().ToString();
            //rtext.Text += dt.Date.DayOfYear;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtext.Text = "";
            for (int i = 2; i <= 8; i++)
            {
                rtext.Text += create_date_list(cal.SelectionStart)[i].dt.Date.ToShortDateString() + "               ЮАО                    " + create_date_list(cal.SelectionStart)[i].value.ToString() + "                     " + Math.Round(create_date_list(cal.SelectionStart)[i].value).ToString() + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtext.Text = "";
            for (int i = 2; i <= 32; i++)
            {
                rtext.Text += create_date_list(cal.SelectionStart)[i].dt.Date.ToShortDateString() + "               ЮАО                    " + create_date_list(cal.SelectionStart)[i].value.ToString() + "                     " + Math.Round(create_date_list(cal.SelectionStart)[i].value).ToString() + "\n";
            }
        }
    }

    public class Time_series
    {
        public DateTime dt;
        public int dtint;
        public double value;
        private const double a = -0.00286;
        private const double b = 4.02431;

        public Time_series(DateTime d)
        {
            dt = d;
            dtint = d.Date.DayOfYear;
            //value = Math.Round(a * dtint + b, 0);
            value = a * dtint + b;
            if (d.Date.Month % 2 != 0 & d.Date.Day <= 7 & 2 <= d.Date.Day)
            {
                value += 3.05 ;
            }
            if (d.Date.Month % 2 == 0 & d.Date.Day <= 7 & 3 <= d.Date.Day)
            {
                value += 2.8;
            }
            if (d.Date.Month % 2 == 0 & d.Date.Day <= 13 & 9 <= d.Date.Day)
            {
                value += 3;
            }
            if (d.Date.Month == 01 & d.Date.Day == 1)
            {
                value += 10;
            }
        }

        public string get_info()
        {
            return "";
        }
    }
}
