using MySql.Data.MySqlClient;

namespace PDV
{
    public partial class FrmLogin : Form
    {
        Conexao conn = new Conexao();
        string sql;
        MySqlCommand cmd;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            this.LogarUsuario();
        }

        private void LogarUsuario()
        {
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Informe o nome de usuário!");
                txt_nome.Focus();
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Informe o email de usuário!");
                txt_email.Focus();
            }
            else if (txt_senha.Text == "")
            {
                MessageBox.Show("Informe a senha de usuário");
                txt_senha.Focus();
            }
            else if (cbx_cargo.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um perfil de usuário!");
                cbx_cargo.Focus();
            }
            else
            {
                conn.AbrirConexao();
                try
                {
                    sql = @"SELECT * FROM tb_funcionarios WHERE email = @email and senha = @senha";
                    cmd = new MySqlCommand(sql, conn.conn);
                    cmd.Parameters.AddWithValue("@email", this.txt_email.Text);
                    cmd.Parameters.AddWithValue("@senha", this.txt_senha.Text);
                    var resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        FrmPrincipal principal = new FrmPrincipal(txt_nome.Text);
                        if (cbx_cargo.Text == "Gerente")
                        {
                            principal.tsm_funcionarios.Enabled = true;
                            principal.tsm_produtos.Enabled = true;
                            principal.tsm_iniciarServico.Enabled = true;
                        }
                        else if (cbx_cargo.Text == "Caixa")
                        {
                            principal.tsm_iniciarServico.Enabled = true;
                        }
                        principal.ShowDialog();
                        this.LimparCampos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha inválidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (MySqlException er)
                {
                    MessageBox.Show("Erro do Banco de dados " + er, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.FecharConexao();
                }
            }
        }

        private void LimparCampos()
        {
            this.txt_nome.Clear();
            this.txt_email.Clear();
            this.txt_senha.Clear();
            this.cbx_cargo.SelectedIndex = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}