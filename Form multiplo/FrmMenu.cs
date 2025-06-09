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
        private OpenFileDialog opdFoto = new OpenFileDialog();
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnDados_Click(object sender, EventArgs e)
        {
            frmJogodeDados jogoDeDadosForm = new frmJogodeDados(txtNomeJog1.Text, txtNomeJog2.Text);
            jogoDeDadosForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarFoto1_Click(object sender, EventArgs e)
        {
            opdFoto.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|BMP(*.bmp)|*.bmp";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opdFoto.FileName);
            }
            else

                pictureBox1.Image = null;
        }

        private void btnCarregarFoto2_Click(object sender, EventArgs e)
        {

            opdFoto.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|BMP(*.bmp)|*.bmp";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opdFoto.FileName);
            }
            else

                pictureBox2.Image = null;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
