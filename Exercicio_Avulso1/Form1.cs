using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Avulso1
{
    public partial class Form1 : Form
    {
        Random x = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        int nr1, nr2;

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblMostraJogador1.Text = "";
            lblMostraJogador2.Text = "";
            lblMostraVencedor.Text = "";
            btnJogador1.Enabled = true;
        }

        private void btnJogador1_Click(object sender, EventArgs e)
        {            
            nr1 = (int)Math.Truncate((x.NextDouble() * 10) % 6);
            nr1 = nr1 + 1;
            lblMostraJogador1.Visible = true;
            lblMostraJogador1.Text = nr1.ToString();
            btnJogador2.Enabled = true;
            btnJogador1.Enabled = false;
        }

        private void btnJogador2_Click(object sender, EventArgs e)
        {
            string resultado;

            nr2 = (int)Math.Truncate((x.NextDouble() * 10) % 6);
            nr2 = nr2 + 1;
            lblMostraJogador2.Visible = true;
            lblMostraJogador2.Text = nr2.ToString();
            btnJogador2.Enabled = false;

            if (nr1 > nr2)
            {
                resultado = "Jogador 1";                
            }
            else if (nr1 < nr2)
            {
                resultado = "Jogador 2";                
            }
            else
            {
                resultado = "Empate";
            }

            lblMostraVencedor.Visible = true;
            lblMostraVencedor.Text = resultado.ToString();
        }
        
    }
}
