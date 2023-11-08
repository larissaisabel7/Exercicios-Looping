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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void exercício11ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void exercício11ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicio11 Exercício11 = new frmexercicio11();
            Exercício11.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercício12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicio12 Exercício12 = new frmexercicio12();
            Exercício12.Show();
        }

        private void exercício13ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício13ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicio13 Exercício13 = new frmexercicio13();
            Exercício13.Show();
        }
    }
}
