using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmCaixaPDV : Form
    {
        Conexao conn = new Conexao();
        string sql;
        MySqlCommand cmd;
        double total = 0;
        double soma = 0;
        double valor;
        int qtd = 0;
        int count = 0;
        int estoque;
        int estoqueAtual;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        public FrmCaixaPDV()
        {
            InitializeComponent();
        }

        private void btn_pesquisarProduto_Click(object sender, EventArgs e)
        {
            this.PesquisarProduto();
        }

        private void PesquisarProduto()
        {
            if (txt_pesquisarProduto.Text != "")
            {
                lbl_caixaLivre.Text = "CAIXA ABERTO";
                if (lbl_caixaLivre.Text == "CAIXA ABERTO")
                {
                    lbl_caixaLivre.ForeColor = Color.Blue;
                }
                sql = "SELECT * FROM tb_produtos WHERE codigo = @codigo";
                conn.AbrirConexao();
                cmd = new MySqlCommand(sql, conn.conn);
                cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = txt_pesquisarProduto.Text;
                try
                {
                    if (txt_pesquisarProduto.Text == "")
                    {
                        throw new Exception("Você precisa digitar o código do produto");
                    }
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == false)
                    {
                        throw new Exception("Produto não cadastrado!");
                    }
                    dr.Read();
                    txt_descricaoProduto.Text = Convert.ToString(dr["descricao"]);
                    txt_codigoProduto.Text = Convert.ToString(dr["codigo"]);
                    txt_precoUnitario.Text = Convert.ToString(dr["preco_venda"]);
                    lbl_estoque.Text = Convert.ToString(dr["estoque_atual"]);
                    lbl_idProduto.Text = Convert.ToString(dr["id_produto"]);
                    byte[] foto = (byte[])dr["foto"];
                    MemoryStream ms = new MemoryStream(foto);
                    pbx_fotoProduto.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.FecharConexao();
                }
            }
        }

        public void AlterarProduto()
        {
            int id = Convert.ToInt32(this.lbl_idProduto.Text);
            int qt = Convert.ToInt32(this.lbl_estAtual.Text);
            conn.AbrirConexao();
            sql = @"UPDATE tb_produtos SET id_produto="+id+", estoque_atual="+qt+" WHERE id_produto= "+id+"";
            cmd = new MySqlCommand(sql, conn.conn);
            cmd.Parameters.AddWithValue("@estoque", this.lbl_estAtual.Text);
            cmd.Parameters.AddWithValue("@id_produto", this.lbl_idProduto.Text);
            cmd.ExecuteNonQuery();
            conn.FecharConexao();
            //MessageBox.Show("Produto editado no banco de dados com sucesso!");
        }

        private byte[] img()
        {
            byte[] image_byte = null;

            FileStream fs = new FileStream(destinoCompleto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            image_byte = br.ReadBytes((int)fs.Length);

            return image_byte;
        }

        private void FrmCaixaPDV_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            FrmLoginCaixa loginCaixa = new FrmLoginCaixa();
            this.lbl_nomeAtendente.Text = loginCaixa.txt_nomeAtendente.Text;
            lbl_caixaLivre.Text = "CAIXA LIVRE";
            if (lbl_caixaLivre.Text == "CAIXA LIVRE")
            {
                lbl_caixaLivre.ForeColor = Color.Green;
            }
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            this.AumentarQuantidadeProduto();
            this.AtualizarEstoque();
        }

        private void AumentarQuantidadeProduto()
        {
            count++;
            this.lbl_quantidade.Text = Convert.ToString(count);
            this.SomarTotal();
        }

        private void AtualizarEstoque()
        {
            estoque = Convert.ToInt32(this.lbl_estoque.Text);
            qtd = Convert.ToInt32(this.lbl_quantidade.Text);
            estoqueAtual = estoque - qtd;
            lbl_estAtual.Text = Convert.ToString(estoqueAtual);
        }

        private void SomarTotal()
        {
            valor = Convert.ToDouble(txt_precoUnitario.Text);
            qtd = Convert.ToInt32(lbl_quantidade.Text);
            total = valor * qtd;
            this.txt_totalProduto.Text = Convert.ToString(total);
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            this.DiminuiQuantidadeProduto();
        }

        private void DiminuiQuantidadeProduto()
        {
            if (count >=1)
            {
                count--;
                this.lbl_quantidade.Text = Convert.ToString(count);
                this.SubtraiValorTotal();
            }
            else
            {
                return;
            }
        }

        private void btn_salvarProduto_Click(object sender, EventArgs e)
        {
            string[] venda = new string[5];
            venda[0] = txt_codigoProduto.Text;
            venda[1] = lbl_quantidade.Text;
            venda[2] = txt_descricaoProduto.Text;
            venda[3] = txt_precoUnitario.Text;
            venda[4] = txt_totalProduto.Text;

            ListViewItem list = new ListViewItem(venda);
            ltv_produtos.Items.Add(list);
            this.CalcularTotalCompras();
            txt_pesquisarProduto.Clear();
            txt_codigoProduto.Clear();
            lbl_quantidade.Text = "0";
            count = 0;
            txt_descricaoProduto.Clear();
            txt_precoUnitario.Clear();
            txt_totalProduto.Clear();
            txt_pesquisarProduto.Focus();
            this.AlterarProduto();
        }

        private void CalcularTotalCompras()
        {
            valor = Convert.ToDouble(txt_totalProduto.Text);
            soma = valor += soma;
            lbl_TotalCompra.Text = Convert.ToString(soma);
        }

        private void btn_fecharVenda_Click(object sender, EventArgs e)
        {
            FrmFecharCompra frmFechar = new FrmFecharCompra();
            frmFechar.lbl_totalAReceber.Text = this.lbl_TotalCompra.Text;
            this.lbl_TotalCompra.Text = "CAIXA LIVRE";
            if (lbl_caixaLivre.Text == "CAIXA LIVRE")
            {
                lbl_caixaLivre.ForeColor = Color.Green;
            }
            frmFechar.ShowDialog();
            this.lbl_TotalCompra.Text = "";
            this.ltv_produtos.Items.Clear();
        }

        private void btn_fecharCaixa_Click(object sender, EventArgs e)
        {
            lbl_caixaLivre.Text = "CAIXA FECHADO";
            if (lbl_caixaLivre.Text == "CAIXA FECHADO")
            {
                lbl_caixaLivre.ForeColor = Color.Red;
            }
            this.Close();
        }

         private void SubtraiValorTotal()
         {
            valor = Convert.ToDouble(txt_precoUnitario.Text);
            total -= valor;
            this.txt_totalProduto.Text = Convert.ToString(total);
         }
    }
}
