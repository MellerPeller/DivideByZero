using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideByZero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            double n;
            double d;

            try 
            { 
                n = double.Parse(textBox1.Text);
                d = double.Parse(textBox2.Text);
            }
            catch 
            {
                throw new Exception("Can only convert numbers (0-9) to double.");
            }

            try
            {
                MessageBox.Show($"{n} divided by {d} equals {divide(n, d)}");
            }
            catch 
            {
                DivideByZeroException DBZE = new DivideByZeroException();
                MessageBox.Show(DBZE.Message);
            }
            
        }

        public static double divide(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();

            }
            
      
            return numerator / denominator;



        }



    }
}
