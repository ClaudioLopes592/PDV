using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDV
{
    public partial class FrmProdutos : Form
    {
        Conexao conn = new Conexao();
        string sql;
        MySqlCommand cmd;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            this.lbl_dataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.ListarProdutos();
            this.DesabilitaCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.HabilitaCampos();
            this.LimpaCampos();
            this.HabilitaCampos();
            //this.btn_cadastrar.Enabled = true;
            this.btn_novo.Enabled = false;
            //this.btn_editar.Enabled = false;
            //this.btn_excluir.Enabled = false;
            this.lbl_dataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            this.InserirFoto();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.CadastrarProduto();
            this.ListarProdutos();
            this.DesabilitaCampos();
            this.LimpaCampos();
            this.btn_novo.Enabled = true;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InserirFoto()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;

            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substiruir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                this.pbx_foto.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
        }

        public void CadastrarProduto()
        {
            conn.AbrirConexao();
            sql = @"INSERT INTO tb_produtos 
                  (data_cadastro, codigo, descricao, unidade, categoria, quantidade, qtd_min, qtd_max, estoque_atual, preco_compra, porcentagem, 
                   preco_venda, preco_total,foto) 
                   VALUES 
                   (@data_cadastro, @codigo, @descricao, @unidade, @categoria, @quantidade, @qtd_min, @qtd_max, @estoque_atual, @preco_compra, 
                    @porcentagem, @preco_venda, @preco_total, @foto)";
            cmd = new MySqlCommand(sql, conn.conn);
            cmd.Parameters.AddWithValue("@data_cadastro", this.lbl_dataCadastro.Text);
            cmd.Parameters.AddWithValue("@codigo", this.txt_codigoProduto.Text);
            cmd.Parameters.AddWithValue("@descricao", this.txt_descricao.Text);
            cmd.Parameters.AddWithValue("@unidade", this.cbx_unidade.Text);
            cmd.Parameters.AddWithValue("@categoria", this.cbx_categoria.Text);
            cmd.Parameters.AddWithValue("@quantidade", this.txt_quantidade.Text);
            cmd.Parameters.AddWithValue("@qtd_min", this.txt_qtdMin.Text);
            cmd.Parameters.AddWithValue("@qtd_max", this.txt_qtdMax.Text);
            cmd.Parameters.AddWithValue("@estoque_atual", this.lbl_estoqueAtual.Text);
            cmd.Parameters.AddWithValue("@preco_compra", this.txt_PrecoCompra.Text);
            cmd.Parameters.AddWithValue("@porcentagem", this.txt_porcentagem.Text);
            cmd.Parameters.AddWithValue("@preco_venda", this.txt_precoVenda.Text);
            cmd.Parameters.AddWithValue("@preco_total", this.lbl_TotalCompra.Text);
            cmd.Parameters.AddWithValue("@foto", this.img());
            cmd.ExecuteNonQuery();
            conn.FecharConexao();
            MessageBox.Show("Produto cadastrado no banco de dados com sucesso!");
        }

        public void ListarProdutos()
        {
            conn.AbrirConexao();
            sql = "SELECT * FROM tb_produtos order by descricao";
            cmd = new MySqlCommand(sql, conn.conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_produtos.DataSource = dt;
            conn.FecharConexao();
        }

        private byte[] img()
        {
            byte[] image_byte = null;

            FileStream fs = new FileStream(destinoCompleto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            image_byte = br.ReadBytes((int)fs.Length);

            return image_byte;
        }

        private void dgv_produtos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgv_produtos.Rows[e.RowIndex];
            if (linha == null)
            {
                return;
            }
            else
            {
                this.txt_idProduto.Text = linha.Cells[0].Value.ToString();
                this.lbl_dataCadastro.Text = linha.Cells[1].Value.ToString();
                this.txt_codigoProduto.Text = linha.Cells[2].Value.ToString();
                this.txt_descricao.Text = linha.Cells[3].Value.ToString();
                this.cbx_unidade.Text = linha.Cells[4].Value.ToString();
                this.cbx_categoria.Text = linha.Cells[5].Value.ToString();
                this.txt_quantidade.Text = linha.Cells[6].Value.ToString();
                this.txt_qtdMin.Text = linha.Cells[7].Value.ToString();
                this.txt_qtdMax.Text = linha.Cells[8].Value.ToString();
                this.lbl_estoqueAtual.Text = linha.Cells[9].Value.ToString();
                this.txt_PrecoCompra.Text = linha.Cells[10].Value.ToString();
                this.txt_porcentagem.Text = linha.Cells[11].Value.ToString();
                this.txt_precoVenda.Text = linha.Cells[12].Value.ToString();
                this.lbl_TotalCompra.Text = linha.Cells[13].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dgv_produtos.CurrentRow.Cells[14].Value);
                this.pbx_foto.Image = Image.FromStream(ms);

                this.HabilitaCampos();
            }
            this.btn_novo.Enabled = false;
            this.btn_cadastrar.Enabled = false;
            this.btn_editar.Enabled = true;
            this.btn_excluir.Enabled = true;
        }

        private void CalcularTotal()
        {
            decimal valorCompra = Convert.ToDecimal(txt_PrecoCompra.Text);
            int qtd = int.Parse(txt_quantidade.Text);
            decimal totalCompra = valorCompra * qtd;
            lbl_TotalCompra.Text = Convert.ToString(totalCompra);
        }

        private void LimpaCampos()
        {
            this.txt_idProduto.Clear();
            this.lbl_dataCadastro.Text = "";
            this.txt_codigoProduto.Clear();
            this.txt_descricao.Clear();
            this.cbx_unidade.SelectedIndex = 0;
            this.cbx_categoria.SelectedIndex = 0;
            this.txt_quantidade.Clear();
            this.txt_qtdMin.Clear();
            this.txt_qtdMax.Clear();
            this.lbl_estoqueAtual.Text = "0";
            this.txt_PrecoCompra.Clear();
            this.txt_porcentagem.Clear();
            this.txt_precoVenda.Clear();
            this.lbl_TotalCompra.Text = "0";
            this.pbx_foto.ImageLocation = null;
        }

        private void DesabilitaCampos()
        {
            this.txt_codigoProduto.Enabled = false;
            this.txt_descricao.Enabled = false;
            this.cbx_unidade.Enabled = false;
            this.cbx_categoria.Enabled = false;
            this.txt_quantidade.Enabled = false;
            this.txt_qtdMin.Enabled = false;
            this.txt_qtdMax.Enabled = false;
            this.lbl_estoqueAtual.Enabled = false;
            this.txt_PrecoCompra.Enabled = false;
            this.txt_porcentagem.Enabled = false;
            this.txt_precoVenda.Enabled = false;
            this.lbl_TotalCompra.Enabled = false;
            this.btn_cadastrar.Enabled = false;
            this.btn_editar.Enabled = false;
            this.btn_excluir.Enabled = false;
            this.btn_foto.Enabled = false;
        }

        private void HabilitaCampos()
        {
            this.txt_codigoProduto.Enabled = true;
            this.txt_descricao.Enabled = true;
            this.cbx_unidade.Enabled = true;
            this.cbx_categoria.Enabled = true;
            this.txt_quantidade.Enabled = true;
            this.txt_qtdMin.Enabled = true;
            this.txt_qtdMax.Enabled = true;
            this.lbl_estoqueAtual.Enabled = true;
            this.txt_PrecoCompra.Enabled = true;
            this.txt_porcentagem.Enabled = true;
            this.txt_precoVenda.Enabled = true;
            this.lbl_TotalCompra.Enabled = true;
            this.btn_cadastrar.Enabled = true;
            this.btn_foto.Enabled = true;
            this.txt_codigoProduto.Focus();
        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            lbl_estoqueAtual.Text = txt_quantidade.Text;
        }

        private void txt_PrecoCompra_TextChanged(object sender, EventArgs e)
        {
            if (txt_PrecoCompra.Text.Substring(0)  == ",")
            {
                txt_PrecoCompra.Text = "0" + txt_PrecoCompra.Text;
            }
            this.CalcularTotal();
        }

        private void txt_porcentagem_TextChanged(object sender, EventArgs e)
        {
            if (txt_porcentagem.Text.Substring(0) == ",")
            {
                txt_porcentagem.Text = "0" + txt_porcentagem.Text;
            }
            if (txt_PrecoCompra.Text != "")
            {
                decimal precoc = Convert.ToDecimal(txt_PrecoCompra.Text);
                decimal porcentagem = Convert.ToDecimal(txt_porcentagem.Text);
                decimal total = (precoc * porcentagem) / 100 + precoc;
                txt_precoVenda.Text = Convert.ToString(total);
            }
        }

        private void txt_precoVenda_TextChanged(object sender, EventArgs e)
        {
            if (txt_precoVenda.Text.Substring(0) == ",")
                txt_precoVenda.Text = "0" + txt_precoVenda.Text;
        }

        private void txt_PrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_PrecoCompra.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_precoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_precoVenda.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_porcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_porcentagem.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
    }
}
