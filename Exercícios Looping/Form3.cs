using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_Looping
{
    public partial class frmexercicio12 : Form
    {
        public frmexercicio12()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }

        private void btnenq_Click(object sender, EventArgs e)
        {
            double celsius, fahrenheit, i;

            celsius = Convert.ToDouble(txtnum.Text);
            

            i = 0;
           
            while(i <90)
            {
                fahrenheit = (celsius + i) * 1.8 + 32;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + fahrenheit.ToString());
                i = i + 10;
            }

        }

        private static double NewMethod(double i)
        {
            i++;
            return i;
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrep_Click(object sender, EventArgs e)
        {

            double celsius, fahrenheit, i;

            celsius = Convert.ToDouble(txtnum.Text);

            i = 0;

            do
            {
                fahrenheit = (celsius + i) * 1.8 + 32;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + fahrenheit.ToString());
                i = i + 10;
            }
            while (i < 100);
           
        }

        private void btnpara_Click(object sender, EventArgs e)
        {

            double celsius, fahrenheit, i;

            celsius = Convert.ToDouble(txtnum.Text);

            i = 0;

            for (i = 0; i < 100;) 
            {
                fahrenheit = (celsius + i) * 1.8 + 32;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + fahrenheit.ToString());
                i = i + 10;
            }
        }
    }
}
