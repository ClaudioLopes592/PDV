using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmLoginCaixa : Form
    {
        public FrmLoginCaixa()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_nomeAtendente.Text == "")
            {
                MessageBox.Show("Digite seu nome de usuário");
                this.txt_nomeAtendente.Focus();
            }
            else if (txt_senha.Text == "")
            {
                MessageBox.Show("Digite sua senha");
            }
            else
            {
                if(txt_nomeAtendente.Text == "Claudio" && txt_senha.Text == "123")
                {
                    FrmCaixaPDV caixaPDV = new FrmCaixaPDV();
                    caixaPDV.ShowDialog();
                    this.Dispose();
                }
            }
        }
    }
}
