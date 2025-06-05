using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_multiplo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnDados_Click(object sender, EventArgs e)
        {
            frmJogodeDados jogoDeDadosForm = new frmJogodeDados(txtNomeJog1.Text, txtNomeJog2.Text);
            jogoDeDadosForm.Show();
        }
        private void btnFotos_Click(object sender, EventArgs e)
        {
            frmCarregaFotos carregaFotosForm = new frmCarregaFotos();
            carregaFotosForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeJog1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
