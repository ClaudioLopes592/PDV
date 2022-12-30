namespace PDV
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Informe o nome de usu�rio!");
                txt_nome.Focus();
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Informe o email de usu�rio!");
                txt_email.Focus();
            }
            else if (txt_senha.Text == "")
            {
                MessageBox.Show("Informe a senha de usu�rio");
                txt_senha.Focus();
            }
            else if (cbx_cargo.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um perfil de usu�rio!");
                cbx_cargo.Focus();
            }
            else
            {
                if (txt_email.Text == "claudioglopes" && txt_senha.Text == "123456")
                {
                    FrmPrincipal frmPrincipal = new FrmPrincipal(txt_nome.Text);
                    if (cbx_cargo.Text == "Gerente")
                    {
                        frmPrincipal.tsm_funcionarios.Enabled = true;
                        frmPrincipal.tsm_produtos.Enabled = true;
                        frmPrincipal.tsm_iniciarServico.Enabled = true;
                    }
                    else if (cbx_cargo.Text == "Caixa")
                    {
                        frmPrincipal.tsm_iniciarServico.Enabled = true;
                    }
                    frmPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usu�rio ou senha informados n�o s�o v�lidos!");
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}