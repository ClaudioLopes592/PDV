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
    public partial class FrmFuncionarios : Form
    {
        Conexao conn = new Conexao();
        string sql;
        MySqlCommand cmd;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            this.lbl_dataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.ListarFuncionarios();
            this.DesabilitaCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.HabilitaCampos();
            this.LimparCampos();
            this.btn_cadastrar.Enabled = true;
            this.btn_novo.Enabled = false;
            this.btn_editar.Enabled = false;
            this.btn_excluir.Enabled = false;
            this.lbl_dataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            this.InserirFoto();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.CadastrarFuncionario();
            this.ListarFuncionarios();
            this.LimparCampos();
            this.DesabilitaCampos();
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

        private void CadastrarFuncionario()
        {
            conn.AbrirConexao();
            sql = @"INSERT INTO tb_funcionarios 
                (data_cadastro, cpf, cargo, nome, email, foto, senha, fone, celular, cep, endereco, bairro, cidade, estado) 
                VALUES 
                (@data_cadastro, @cpf, @cargo, @nome, @email, @foto, @senha, @fone, @celular, @cep, @endereco, @bairro, @cidade, @estado)";
            cmd = new MySqlCommand(sql, conn.conn);
            cmd.Parameters.AddWithValue("@data_cadastro", this.lbl_dataCadastro.Text);
            cmd.Parameters.AddWithValue("@cpf", this.txt_cpf.Text);
            cmd.Parameters.AddWithValue("@cargo", this.cbx_cargo.Text);
            cmd.Parameters.AddWithValue("@nome", this.txt_nome.Text);
            cmd.Parameters.AddWithValue("@email", this.txt_email.Text);
            cmd.Parameters.AddWithValue("@foto", img());
            cmd.Parameters.AddWithValue("@senha", this.txt_senha.Text);
            cmd.Parameters.AddWithValue("@fone", this.txt_fone.Text);
            cmd.Parameters.AddWithValue("@celular", this.txt_celular.Text);
            cmd.Parameters.AddWithValue("@cep", this.txt_cep.Text);
            cmd.Parameters.AddWithValue("@endereco", this.txt_endereco.Text);
            cmd.Parameters.AddWithValue("@bairro", this.txt_bairro.Text);
            cmd.Parameters.AddWithValue("@cidade", this.txt_cidade.Text);
            cmd.Parameters.AddWithValue("@estado", this.cbx_estado.Text);
            cmd.ExecuteNonQuery();
            conn.FecharConexao();
            MessageBox.Show("Funcionário cadastrado no banco de dados com sucesso!");
        }

        public void ListarFuncionarios()
        {
            conn.AbrirConexao();
            sql = "SELECT * FROM tb_funcionarios order by nome";
            cmd = new MySqlCommand(sql, conn.conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_funcionarios.DataSource = dt;
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

        private void dgv_funcionarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgv_funcionarios.Rows[e.RowIndex];
            if (linha == null)
            {
                return;
            }
            else
            {
                this.txt_idFuncionario.Text = linha.Cells[0].Value.ToString();
                this.lbl_dataCadastro.Text = linha.Cells[1].Value.ToString();
                this.txt_nome.Text = linha.Cells[4].Value.ToString();
                this.txt_email.Text = linha.Cells[5].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dgv_funcionarios.CurrentRow.Cells[6].Value);
                this.pbx_foto.Image = Image.FromStream(ms);
                this.txt_senha.Text = linha.Cells[7].Value.ToString();
                this.txt_cpf.Text = linha.Cells[2].Value.ToString();
                this.txt_fone.Text = linha.Cells[8].Value.ToString();
                this.txt_celular.Text = linha.Cells[9].Value.ToString();
                this.cbx_cargo.Text = linha.Cells[3].Value.ToString();
                this.txt_cep.Text = linha.Cells[10].Value.ToString();
                this.txt_endereco.Text = linha.Cells[11].Value.ToString();
                this.txt_bairro.Text = linha.Cells[12].Value.ToString();
                this.txt_cidade.Text = linha.Cells[13].Value.ToString();
                this.cbx_estado.Text = linha.Cells[14].Value.ToString();
                
                this.HabilitaCampos();
            }
            this.btn_novo.Enabled = false;
            this.btn_cadastrar.Enabled = false;
            this.btn_editar.Enabled = true;
            this.btn_excluir.Enabled = true;
        }

        private void LimparCampos()
        {
            this.txt_idFuncionario.Clear();
            this.lbl_dataCadastro.Text = "";
            this.txt_cpf.Clear();
            this.cbx_cargo.SelectedIndex = 0;
            this.txt_nome.Clear();
            this.txt_email.Clear();
            this.pbx_foto.ImageLocation = null;
            this.txt_senha.Clear();
            this.txt_fone.Clear();
            this.txt_celular.Clear();
            this.txt_cep.Clear();
            this.txt_endereco.Clear();
            this.txt_bairro.Clear();
            this.txt_cidade.Clear();
            this.cbx_estado.SelectedIndex = 0;
            this.txt_cpf.Focus();
        }

        private void DesabilitaCampos()
        {
            this.txt_cpf.Enabled = false;
            this.cbx_cargo.Enabled = false;
            this.txt_nome.Enabled = false;
            this.txt_email.Enabled = false;
            this.btn_foto.Enabled = false;
            this.txt_senha.Enabled = false;
            this.txt_fone.Enabled = false;
            this.txt_celular.Enabled = false;
            this.txt_cep.Enabled = false;
            this.txt_endereco.Enabled = false;
            this.txt_bairro.Enabled = false;
            this.txt_cidade.Enabled = false;
            this.cbx_estado.Enabled = false;
            this.btn_cadastrar.Enabled = false;
            this.btn_editar.Enabled = false;
            this.btn_excluir.Enabled = false;
        }

        private void HabilitaCampos()
        {
            this.txt_cpf.Enabled = true;
            this.cbx_cargo.Enabled = true;
            this.txt_nome.Enabled = true;
            this.txt_email.Enabled = true;
            this.btn_foto.Enabled = true;
            this.txt_senha.Enabled = true;
            this.txt_fone.Enabled = true;
            this.txt_celular.Enabled = true;
            this.txt_cep.Enabled = true;
            this.txt_endereco.Enabled = true;
            this.txt_bairro.Enabled = true;
            this.txt_cidade.Enabled = true;
            this.cbx_estado.Enabled = true;
            this.btn_cadastrar.Enabled = true;
            this.btn_editar.Enabled = true;
            this.btn_excluir.Enabled = true;
        }
    }
}
