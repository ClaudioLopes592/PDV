namespace PDV
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_iniciarServico = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_usuarioLogado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.pDVToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_funcionarios,
            this.tsm_produtos});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tsm_funcionarios
            // 
            this.tsm_funcionarios.Enabled = false;
            this.tsm_funcionarios.Name = "tsm_funcionarios";
            this.tsm_funcionarios.Size = new System.Drawing.Size(167, 22);
            this.tsm_funcionarios.Text = "Funcionários";
            this.tsm_funcionarios.Click += new System.EventHandler(this.tsm_funcionarios_Click);
            // 
            // tsm_produtos
            // 
            this.tsm_produtos.Enabled = false;
            this.tsm_produtos.Name = "tsm_produtos";
            this.tsm_produtos.Size = new System.Drawing.Size(167, 22);
            this.tsm_produtos.Text = "Produtos";
            this.tsm_produtos.Click += new System.EventHandler(this.tsm_produtos_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // pDVToolStripMenuItem
            // 
            this.pDVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_iniciarServico});
            this.pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            this.pDVToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.pDVToolStripMenuItem.Text = "PDV";
            // 
            // tsm_iniciarServico
            // 
            this.tsm_iniciarServico.Enabled = false;
            this.tsm_iniciarServico.Name = "tsm_iniciarServico";
            this.tsm_iniciarServico.Size = new System.Drawing.Size(180, 22);
            this.tsm_iniciarServico.Text = "Iniciar Serviço";
            this.tsm_iniciarServico.Click += new System.EventHandler(this.tsm_iniciarServico_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_sair});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // tsm_sair
            // 
            this.tsm_sair.Name = "tsm_sair";
            this.tsm_sair.Size = new System.Drawing.Size(102, 22);
            this.tsm_sair.Text = "Sair";
            this.tsm_sair.Click += new System.EventHandler(this.tsm_sair_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_data);
            this.panel1.Controls.Add(this.lbl_usuarioLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 63);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário Logado no Sistema";
            // 
            // lbl_data
            // 
            this.lbl_data.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_data.Location = new System.Drawing.Point(888, 20);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(120, 30);
            this.lbl_data.TabIndex = 1;
            this.lbl_data.Text = "data";
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_usuarioLogado
            // 
            this.lbl_usuarioLogado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_usuarioLogado.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_usuarioLogado.Location = new System.Drawing.Point(269, 20);
            this.lbl_usuarioLogado.Name = "lbl_usuarioLogado";
            this.lbl_usuarioLogado.Size = new System.Drawing.Size(180, 30);
            this.lbl_usuarioLogado.TabIndex = 0;
            this.lbl_usuarioLogado.Text = "nome";
            this.lbl_usuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem tsm_sair;
        public ToolStripMenuItem cadastrosToolStripMenuItem;
        public ToolStripMenuItem tsm_funcionarios;
        private Panel panel1;
        private Label lbl_usuarioLogado;
        private Label lbl_data;
        public ToolStripMenuItem tsm_produtos;
        private Label label2;
        private Label label1;
        public ToolStripMenuItem tsm_iniciarServico;
    }
}