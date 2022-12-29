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
        public FrmPrincipal()
        {
            InitializeComponent();
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
    }
}
