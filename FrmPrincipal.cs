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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome)
        {
            InitializeComponent();
            this.lbl_usuarioLogado.Text = nome;
        }

        private void tsm_funcionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frmFuncionarios = new FrmFuncionarios();
            frmFuncionarios.ShowDialog();
        }

        private void tsm_produtos_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.ShowDialog();
        }

        private void tsm_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tsm_iniciarServico_Click(object sender, EventArgs e)
        {
            FrmCaixaPDV frmCaixa = new FrmCaixaPDV();
            frmCaixa.ShowDialog();
        }
    }
}
