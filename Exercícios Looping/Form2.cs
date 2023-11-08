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
    public partial class frmexercicio11 : Form
    {
        public frmexercicio11()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmexercicio11_Load(object sender, EventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double num, I, R;

            num = Convert.ToDouble(txtnum.Text);

            I = 1;

            do
            {
                R = num * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + R.ToString());
                I++;
            }
            while (I < 11);
        }

        private void btnenq_Click(object sender, EventArgs e)
        {
            Double num, I, R;

            num = Convert.ToDouble(txtnum.Text);

            I = 1;
            while (I < 11)
            {
                R = num * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + R.ToString());
                I++;
            }

        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double num, I, R;

            for (I = 1; I <= 10; I++)
            {
                num = Convert.ToDouble(txtnum.Text);
                R = I * num;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + R.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }
    }
}
