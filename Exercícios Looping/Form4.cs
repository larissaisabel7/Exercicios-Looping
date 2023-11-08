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
    public partial class frmexercicio13 : Form
    {
        public frmexercicio13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrep_Click(object sender, EventArgs e)
        {

        }
        double areatotal;
        private void btnpara_Click(object sender, EventArgs e)
        {

        }

        private void btnenq_Click(object sender, EventArgs e)
        {
            double larg, comp, area;

           
            larg = Convert.ToDouble(txtlarg.Text);
            comp = Convert.ToDouble(txtcomp.Text);

            area = larg * comp;
            areatotal+= area;
            txtarea.Text = area.ToString();

            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                txtcomodo.Clear();
                txtlarg.Clear();
                txtcomp.Clear();
                txtarea.Clear();
                txtareatotal.Clear();
                txtcomodo.Focus();
            }
            else
            {
                lblareat.Visible = true;
                txtareatotal.Visible = true;
                txtareatotal.Text = areatotal.ToString(); 
            }
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            txtcomodo.Clear();
            txtlarg.Clear();
            txtcomp.Clear();
            txtarea.Clear();
            txtareatotal.Clear();
            txtcomodo.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
