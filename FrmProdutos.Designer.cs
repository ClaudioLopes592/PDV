namespace PDV
{
    partial class FrmProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_precoVenda = new System.Windows.Forms.TextBox();
            this.txt_PrecoCompra = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lbl_estoqueAtual = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_TotalCompra = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_porcentagem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_qtdMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_qtdMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_categoria = new System.Windows.Forms.ComboBox();
            this.cbx_unidade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbx_foto = new System.Windows.Forms.PictureBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_dataCadastro = new System.Windows.Forms.Label();
            this.txt_codigoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pesquisarProduto = new System.Windows.Forms.TextBox();
            this.btn_pesquisarProduto = new System.Windows.Forms.Button();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_precoVenda);
            this.groupBox1.Controls.Add(this.txt_PrecoCompra);
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.lbl_estoqueAtual);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lbl_TotalCompra);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_porcentagem);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_qtdMax);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_qtdMin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbx_categoria);
            this.groupBox1.Controls.Add(this.cbx_unidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_descricao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pbx_foto);
            this.groupBox1.Controls.Add(this.btn_foto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_dataCadastro);
            this.groupBox1.Controls.Add(this.txt_codigoProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Produtos";
            // 
            // txt_precoVenda
            // 
            this.txt_precoVenda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_precoVenda.Location = new System.Drawing.Point(602, 200);
            this.txt_precoVenda.Name = "txt_precoVenda";
            this.txt_precoVenda.Size = new System.Drawing.Size(102, 26);
            this.txt_precoVenda.TabIndex = 10;
            this.txt_precoVenda.TextChanged += new System.EventHandler(this.txt_precoVenda_TextChanged);
            this.txt_precoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precoVenda_KeyPress);
            // 
            // txt_PrecoCompra
            // 
            this.txt_PrecoCompra.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PrecoCompra.Location = new System.Drawing.Point(143, 200);
            this.txt_PrecoCompra.Name = "txt_PrecoCompra";
            this.txt_PrecoCompra.Size = new System.Drawing.Size(102, 26);
            this.txt_PrecoCompra.TabIndex = 8;
            this.txt_PrecoCompra.TextChanged += new System.EventHandler(this.txt_PrecoCompra_TextChanged);
            this.txt_PrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecoCompra_KeyPress);
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Location = new System.Drawing.Point(711, 319);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(130, 40);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(504, 319);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(130, 40);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Location = new System.Drawing.Point(335, 319);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(130, 40);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Location = new System.Drawing.Point(170, 319);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(130, 40);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(6, 319);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(130, 40);
            this.btn_novo.TabIndex = 12;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // lbl_estoqueAtual
            // 
            this.lbl_estoqueAtual.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estoqueAtual.Location = new System.Drawing.Point(407, 267);
            this.lbl_estoqueAtual.Name = "lbl_estoqueAtual";
            this.lbl_estoqueAtual.Size = new System.Drawing.Size(100, 20);
            this.lbl_estoqueAtual.TabIndex = 33;
            this.lbl_estoqueAtual.Text = "0";
            this.lbl_estoqueAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(293, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "Estoque Atual";
            // 
            // lbl_TotalCompra
            // 
            this.lbl_TotalCompra.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalCompra.Location = new System.Drawing.Point(138, 264);
            this.lbl_TotalCompra.Name = "lbl_TotalCompra";
            this.lbl_TotalCompra.Size = new System.Drawing.Size(100, 20);
            this.lbl_TotalCompra.TabIndex = 31;
            this.lbl_TotalCompra.Text = "0";
            this.lbl_TotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Total Compra R$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(478, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Preço Venda R$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(441, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "%";
            // 
            // txt_porcentagem
            // 
            this.txt_porcentagem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_porcentagem.Location = new System.Drawing.Point(375, 200);
            this.txt_porcentagem.Name = "txt_porcentagem";
            this.txt_porcentagem.Size = new System.Drawing.Size(60, 26);
            this.txt_porcentagem.TabIndex = 9;
            this.txt_porcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_porcentagem.TextChanged += new System.EventHandler(this.txt_porcentagem_TextChanged);
            this.txt_porcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_porcentagem_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(265, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Porcentagem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Preço Compra R$";
            // 
            // txt_qtdMax
            // 
            this.txt_qtdMax.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_qtdMax.Location = new System.Drawing.Point(624, 149);
            this.txt_qtdMax.Name = "txt_qtdMax";
            this.txt_qtdMax.Size = new System.Drawing.Size(80, 26);
            this.txt_qtdMax.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(466, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quantidade Maxima";
            // 
            // txt_qtdMin
            // 
            this.txt_qtdMin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_qtdMin.Location = new System.Drawing.Point(363, 149);
            this.txt_qtdMin.Name = "txt_qtdMin";
            this.txt_qtdMin.Size = new System.Drawing.Size(80, 26);
            this.txt_qtdMin.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(210, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quantidade Minima";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_quantidade.Location = new System.Drawing.Point(103, 149);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(80, 26);
            this.txt_quantidade.TabIndex = 5;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantidade";
            // 
            // cbx_categoria
            // 
            this.cbx_categoria.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_categoria.FormattingEnabled = true;
            this.cbx_categoria.Items.AddRange(new object[] {
            "Selecione",
            "Alimentos",
            "Matinais",
            "Bebidas",
            "Higiêne",
            "Limpeza"});
            this.cbx_categoria.Location = new System.Drawing.Point(610, 93);
            this.cbx_categoria.Name = "cbx_categoria";
            this.cbx_categoria.Size = new System.Drawing.Size(94, 26);
            this.cbx_categoria.TabIndex = 4;
            this.cbx_categoria.Text = "Selecione";
            // 
            // cbx_unidade
            // 
            this.cbx_unidade.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_unidade.FormattingEnabled = true;
            this.cbx_unidade.Items.AddRange(new object[] {
            "Selecione",
            "Unidade",
            "Kg",
            "Litro",
            "Lata",
            "Pacote"});
            this.cbx_unidade.Location = new System.Drawing.Point(414, 93);
            this.cbx_unidade.Name = "cbx_unidade";
            this.cbx_unidade.Size = new System.Drawing.Size(94, 26);
            this.cbx_unidade.TabIndex = 3;
            this.cbx_unidade.Text = "Selecione";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(342, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Unidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(529, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Categoria";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_descricao.Location = new System.Drawing.Point(90, 93);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(236, 26);
            this.txt_descricao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Descrição";
            // 
            // pbx_foto
            // 
            this.pbx_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_foto.Location = new System.Drawing.Point(721, 83);
            this.pbx_foto.Name = "pbx_foto";
            this.pbx_foto.Size = new System.Drawing.Size(120, 150);
            this.pbx_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_foto.TabIndex = 7;
            this.pbx_foto.TabStop = false;
            // 
            // btn_foto
            // 
            this.btn_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_foto.Location = new System.Drawing.Point(721, 37);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(120, 30);
            this.btn_foto.TabIndex = 1;
            this.btn_foto.Text = "FOTO";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(471, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data Cadastro";
            // 
            // lbl_dataCadastro
            // 
            this.lbl_dataCadastro.AutoSize = true;
            this.lbl_dataCadastro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dataCadastro.Location = new System.Drawing.Point(588, 44);
            this.lbl_dataCadastro.Name = "lbl_dataCadastro";
            this.lbl_dataCadastro.Size = new System.Drawing.Size(116, 18);
            this.lbl_dataCadastro.TabIndex = 19;
            this.lbl_dataCadastro.Text = "00/00/0000";
            // 
            // txt_codigoProduto
            // 
            this.txt_codigoProduto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_codigoProduto.Location = new System.Drawing.Point(273, 39);
            this.txt_codigoProduto.Name = "txt_codigoProduto";
            this.txt_codigoProduto.Size = new System.Drawing.Size(177, 26);
            this.txt_codigoProduto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código";
            // 
            // txt_idProduto
            // 
            this.txt_idProduto.Enabled = false;
            this.txt_idProduto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_idProduto.Location = new System.Drawing.Point(97, 39);
            this.txt_idProduto.Name = "txt_idProduto";
            this.txt_idProduto.Size = new System.Drawing.Size(77, 26);
            this.txt_idProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Produto";
            // 
            // txt_pesquisarProduto
            // 
            this.txt_pesquisarProduto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisarProduto.Location = new System.Drawing.Point(12, 392);
            this.txt_pesquisarProduto.Name = "txt_pesquisarProduto";
            this.txt_pesquisarProduto.Size = new System.Drawing.Size(194, 26);
            this.txt_pesquisarProduto.TabIndex = 34;
            // 
            // btn_pesquisarProduto
            // 
            this.btn_pesquisarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisarProduto.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_pesquisarProduto.Location = new System.Drawing.Point(212, 388);
            this.btn_pesquisarProduto.Name = "btn_pesquisarProduto";
            this.btn_pesquisarProduto.Size = new System.Drawing.Size(200, 35);
            this.btn_pesquisarProduto.TabIndex = 35;
            this.btn_pesquisarProduto.Text = "PESQUISAR PRODUTO";
            this.btn_pesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_produtos.Location = new System.Drawing.Point(12, 429);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowTemplate.Height = 25;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(857, 256);
            this.dgv_produtos.TabIndex = 3;
            this.dgv_produtos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_produtos_CellMouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 696);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.btn_pesquisarProduto);
            this.Controls.Add(this.txt_pesquisarProduto);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_sair;
        private Button btn_excluir;
        private Button btn_editar;
        private Button btn_cadastrar;
        private Button btn_novo;
        private Label lbl_estoqueAtual;
        private Label label18;
        private Label lbl_TotalCompra;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox txt_porcentagem;
        private Label label12;
        private Label label11;
        private TextBox txt_qtdMax;
        private Label label10;
        private TextBox txt_qtdMin;
        private Label label9;
        private TextBox txt_quantidade;
        private Label label8;
        private ComboBox cbx_categoria;
        private ComboBox cbx_unidade;
        private Label label7;
        private Label label6;
        private TextBox txt_descricao;
        private Label label5;
        private PictureBox pbx_foto;
        private Button btn_foto;
        private Label label4;
        private Label lbl_dataCadastro;
        private TextBox txt_codigoProduto;
        private Label label2;
        private TextBox txt_idProduto;
        private Label label1;
        private TextBox txt_pesquisarProduto;
        private Button btn_pesquisarProduto;
        private DataGridView dgv_produtos;
        private OpenFileDialog openFileDialog1;
        private TextBox txt_precoVenda;
        private TextBox txt_PrecoCompra;
    }
}