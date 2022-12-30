using Google.Protobuf.WellKnownTypes;
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
    public partial class FrmFecharCompra : Form
    {
        double total;
        double valor;
        double troco = 0;

        public FrmFecharCompra()
        {
            InitializeComponent();
        }

        private void txt_valorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (txt_valorRecebido.Text.Substring(0) == ",")
            {
                txt_valorRecebido.Text = "0" + txt_valorRecebido.Text;
            }
            if (txt_valorRecebido.Text != "")
            {
                total = Convert.ToDouble(lbl_totalAReceber.Text);
                valor = Convert.ToDouble(txt_valorRecebido.Text);
                troco = valor - total;
                lbl_troco.Text = Convert.ToString(troco);
            }
        }

        private void txt_valorRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                {
                    if (e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }
                    else if (txt_valorRecebido.Text.IndexOf(',') > 0)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btn_dinheiro_Click(object sender, EventArgs e)
        {
            txt_valorRecebido.Enabled = true;
            txt_valorRecebido.Focus();
        }

        private void btn_receber_Click(object sender, EventArgs e)
        {
            //Abre gaveta
            //Encerra venda
            FrmCaixaPDV caixaPDV = new FrmCaixaPDV();
            caixaPDV.txt_pesquisarProduto.Focus();
            this.Dispose();
        }
    }
}
