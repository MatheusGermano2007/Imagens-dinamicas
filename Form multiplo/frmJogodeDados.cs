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
    public partial class frmJogodeDados : Form
    {
        private Random sorteio = new Random();
        private int dadoJog1, dadoJog2;
        private int contVitoria1 = 0, contVitoria2 = 0;
        private string jogador1;
        private string jogador2;
        public frmJogodeDados(string jogador1, string jogador2)
        {
            InitializeComponent();
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
            
        }

        private void frmJogodeDados_Load(object sender, EventArgs e)
        {
            lblJogador1.Text = jogador1;
            lblJogador2.Text = jogador2;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            contVitoria1 = 0;
            contVitoria2 = 0;
            lblPlacar1.Text = "0";
            lblPlacar2.Text = "0";
            pcJogador1.Image = null;
            pcJogador2.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Deseja realmente sair?",
            "Jogo de Dados CTI",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblJogador1_Click(object sender, EventArgs e)
        {

        }

        private void lblJogador2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnJogar_Click(object sender, EventArgs e)
        {

            dadoJog1 = SorteioDado(pcJogador1);
            dadoJog2 = SorteioDado(pcJogador2);
            if (dadoJog1 > dadoJog2)
            {
                contVitoria1++;
                lblPlacar1.Text = contVitoria1.ToString();
            }
            else if (dadoJog2 > dadoJog1)
            {
                contVitoria2++;
                lblPlacar2.Text = contVitoria2.ToString();
            }
            else
            {
                MessageBox.Show("Empate!",
                                "Jogo de Dados CTI",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);

            }
        }
        private int SorteioDado(PictureBox dado)
        {
            int valorDado = sorteio.Next(1, 7);
            String arquivoDado = ".\\imagens\\dado" + valorDado.ToString() + ".jpg";
            dado.Image = Image.FromFile(arquivoDado);
            return valorDado;
        }
    }
}
