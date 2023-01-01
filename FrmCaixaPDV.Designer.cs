namespace PDV
{
    partial class FrmCaixaPDV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_estAtual = new System.Windows.Forms.Label();
            this.lbl_idProduto = new System.Windows.Forms.Label();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.btn_salvarProduto = new System.Windows.Forms.Button();
            this.txt_totalProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_precoUnitario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbx_fotoProduto = new System.Windows.Forms.PictureBox();
            this.txt_codigoProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_descricaoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_pesquisarProduto = new System.Windows.Forms.Button();
            this.txt_pesquisarProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_nomeAtendente = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_caixaLivre = new System.Windows.Forms.Label();
            this.ltv_produtos = new System.Windows.Forms.ListView();
            this.colCodigo = new System.Windows.Forms.ColumnHeader();
            this.colQuantidade = new System.Windows.Forms.ColumnHeader();
            this.colDescricao = new System.Windows.Forms.ColumnHeader();
            this.colPrecoUnitario = new System.Windows.Forms.ColumnHeader();
            this.colTotalProduto = new System.Windows.Forms.ColumnHeader();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_TotalCompra = new System.Windows.Forms.Label();
            this.btn_fecharCaixa = new System.Windows.Forms.Button();
            this.btn_fecharVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fotoProduto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "FRENTE DE ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "CAIXA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(192, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "CGL Desenvolvedor";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_data.Location = new System.Drawing.Point(243, 75);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(48, 18);
            this.lbl_data.TabIndex = 4;
            this.lbl_data.Text = "data";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_estAtual);
            this.panel1.Controls.Add(this.lbl_idProduto);
            this.panel1.Controls.Add(this.lbl_estoque);
            this.panel1.Controls.Add(this.btn_salvarProduto);
            this.panel1.Controls.Add(this.txt_totalProduto);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_quantidade);
            this.panel1.Controls.Add(this.btn_mais);
            this.panel1.Controls.Add(this.btn_menos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_precoUnitario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pbx_fotoProduto);
            this.panel1.Controls.Add(this.txt_codigoProduto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_descricaoProduto);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_pesquisarProduto);
            this.panel1.Controls.Add(this.txt_pesquisarProduto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 546);
            this.panel1.TabIndex = 5;
            // 
            // lbl_estAtual
            // 
            this.lbl_estAtual.AutoSize = true;
            this.lbl_estAtual.Location = new System.Drawing.Point(436, 22);
            this.lbl_estAtual.Name = "lbl_estAtual";
            this.lbl_estAtual.Size = new System.Drawing.Size(44, 15);
            this.lbl_estAtual.TabIndex = 25;
            this.lbl_estAtual.Text = "estoqA";
            this.lbl_estAtual.Visible = false;
            // 
            // lbl_idProduto
            // 
            this.lbl_idProduto.AutoSize = true;
            this.lbl_idProduto.Location = new System.Drawing.Point(408, 60);
            this.lbl_idProduto.Name = "lbl_idProduto";
            this.lbl_idProduto.Size = new System.Drawing.Size(17, 15);
            this.lbl_idProduto.TabIndex = 24;
            this.lbl_idProduto.Text = "id";
            this.lbl_idProduto.Visible = false;
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.Location = new System.Drawing.Point(383, 21);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(36, 15);
            this.lbl_estoque.TabIndex = 23;
            this.lbl_estoque.Text = "estoq";
            this.lbl_estoque.Visible = false;
            // 
            // btn_salvarProduto
            // 
            this.btn_salvarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarProduto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvarProduto.Location = new System.Drawing.Point(91, 476);
            this.btn_salvarProduto.Name = "btn_salvarProduto";
            this.btn_salvarProduto.Size = new System.Drawing.Size(280, 50);
            this.btn_salvarProduto.TabIndex = 22;
            this.btn_salvarProduto.Text = "SALVAR PRODUTO";
            this.btn_salvarProduto.UseVisualStyleBackColor = true;
            this.btn_salvarProduto.Click += new System.EventHandler(this.btn_salvarProduto_Click);
            // 
            // txt_totalProduto
            // 
            this.txt_totalProduto.Enabled = false;
            this.txt_totalProduto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_totalProduto.Location = new System.Drawing.Point(240, 420);
            this.txt_totalProduto.Name = "txt_totalProduto";
            this.txt_totalProduto.Size = new System.Drawing.Size(131, 26);
            this.txt_totalProduto.TabIndex = 21;
            this.txt_totalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(240, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Valor Total R$";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_quantidade.Location = new System.Drawing.Point(300, 320);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(40, 40);
            this.lbl_quantidade.TabIndex = 19;
            this.lbl_quantidade.Text = "0";
            this.lbl_quantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mais
            // 
            this.btn_mais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mais.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mais.Location = new System.Drawing.Point(358, 320);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(40, 40);
            this.btn_mais.TabIndex = 18;
            this.btn_mais.Text = "+";
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.btn_mais_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menos.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_menos.Location = new System.Drawing.Point(244, 320);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(40, 40);
            this.btn_menos.TabIndex = 17;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.btn_menos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(240, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quantidade";
            // 
            // txt_precoUnitario
            // 
            this.txt_precoUnitario.Enabled = false;
            this.txt_precoUnitario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_precoUnitario.Location = new System.Drawing.Point(240, 238);
            this.txt_precoUnitario.Name = "txt_precoUnitario";
            this.txt_precoUnitario.Size = new System.Drawing.Size(131, 26);
            this.txt_precoUnitario.TabIndex = 15;
            this.txt_precoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(240, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Preço Unitário R$";
            // 
            // pbx_fotoProduto
            // 
            this.pbx_fotoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_fotoProduto.Location = new System.Drawing.Point(44, 236);
            this.pbx_fotoProduto.Name = "pbx_fotoProduto";
            this.pbx_fotoProduto.Size = new System.Drawing.Size(130, 170);
            this.pbx_fotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fotoProduto.TabIndex = 13;
            this.pbx_fotoProduto.TabStop = false;
            // 
            // txt_codigoProduto
            // 
            this.txt_codigoProduto.Enabled = false;
            this.txt_codigoProduto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_codigoProduto.Location = new System.Drawing.Point(312, 138);
            this.txt_codigoProduto.Name = "txt_codigoProduto";
            this.txt_codigoProduto.Size = new System.Drawing.Size(166, 26);
            this.txt_codigoProduto.TabIndex = 12;
            this.txt_codigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(312, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Código";
            // 
            // txt_descricaoProduto
            // 
            this.txt_descricaoProduto.Enabled = false;
            this.txt_descricaoProduto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_descricaoProduto.Location = new System.Drawing.Point(18, 138);
            this.txt_descricaoProduto.Name = "txt_descricaoProduto";
            this.txt_descricaoProduto.Size = new System.Drawing.Size(264, 26);
            this.txt_descricaoProduto.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome do Produto";
            // 
            // btn_pesquisarProduto
            // 
            this.btn_pesquisarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisarProduto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pesquisarProduto.Location = new System.Drawing.Point(239, 35);
            this.btn_pesquisarProduto.Name = "btn_pesquisarProduto";
            this.btn_pesquisarProduto.Size = new System.Drawing.Size(130, 40);
            this.btn_pesquisarProduto.TabIndex = 8;
            this.btn_pesquisarProduto.Text = "PESQUISAR";
            this.btn_pesquisarProduto.UseVisualStyleBackColor = true;
            this.btn_pesquisarProduto.Click += new System.EventHandler(this.btn_pesquisarProduto_Click);
            // 
            // txt_pesquisarProduto
            // 
            this.txt_pesquisarProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisarProduto.Location = new System.Drawing.Point(18, 52);
            this.txt_pesquisarProduto.Name = "txt_pesquisarProduto";
            this.txt_pesquisarProduto.Size = new System.Drawing.Size(197, 27);
            this.txt_pesquisarProduto.TabIndex = 7;
            this.txt_pesquisarProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Digite o código do produto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_nomeAtendente);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lbl_caixaLivre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_data);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 118);
            this.panel2.TabIndex = 6;
            // 
            // lbl_nomeAtendente
            // 
            this.lbl_nomeAtendente.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeAtendente.Location = new System.Drawing.Point(1107, 65);
            this.lbl_nomeAtendente.Name = "lbl_nomeAtendente";
            this.lbl_nomeAtendente.Size = new System.Drawing.Size(172, 28);
            this.lbl_nomeAtendente.TabIndex = 7;
            this.lbl_nomeAtendente.Text = "nome";
            this.lbl_nomeAtendente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(1107, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 18);
            this.label16.TabIndex = 6;
            this.label16.Text = "Nome do Atendente";
            // 
            // lbl_caixaLivre
            // 
            this.lbl_caixaLivre.AutoSize = true;
            this.lbl_caixaLivre.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_caixaLivre.Location = new System.Drawing.Point(500, 25);
            this.lbl_caixaLivre.Name = "lbl_caixaLivre";
            this.lbl_caixaLivre.Size = new System.Drawing.Size(504, 78);
            this.lbl_caixaLivre.TabIndex = 5;
            this.lbl_caixaLivre.Text = "CAIXA LIVRE";
            // 
            // ltv_produtos
            // 
            this.ltv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodigo,
            this.colQuantidade,
            this.colDescricao,
            this.colPrecoUnitario,
            this.colTotalProduto});
            this.ltv_produtos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltv_produtos.FullRowSelect = true;
            this.ltv_produtos.Location = new System.Drawing.Point(512, 136);
            this.ltv_produtos.Name = "ltv_produtos";
            this.ltv_produtos.Size = new System.Drawing.Size(846, 405);
            this.ltv_produtos.TabIndex = 7;
            this.ltv_produtos.UseCompatibleStateImageBehavior = false;
            this.ltv_produtos.View = System.Windows.Forms.View.Details;
            // 
            // colCodigo
            // 
            this.colCodigo.Text = "Código";
            this.colCodigo.Width = 100;
            // 
            // colQuantidade
            // 
            this.colQuantidade.DisplayIndex = 3;
            this.colQuantidade.Text = "Quantidade";
            this.colQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQuantidade.Width = 120;
            // 
            // colDescricao
            // 
            this.colDescricao.DisplayIndex = 1;
            this.colDescricao.Text = "Descrição";
            this.colDescricao.Width = 360;
            // 
            // colPrecoUnitario
            // 
            this.colPrecoUnitario.DisplayIndex = 2;
            this.colPrecoUnitario.Text = "Preço Unitário";
            this.colPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrecoUnitario.Width = 120;
            // 
            // colTotalProduto
            // 
            this.colTotalProduto.Text = "Total Produto";
            this.colTotalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTotalProduto.Width = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGray;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(559, 561);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(362, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "VALOR TOTAL DAS COMPRAS R$";
            // 
            // lbl_TotalCompra
            // 
            this.lbl_TotalCompra.BackColor = System.Drawing.Color.Green;
            this.lbl_TotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalCompra.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalCompra.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalCompra.Location = new System.Drawing.Point(955, 551);
            this.lbl_TotalCompra.Name = "lbl_TotalCompra";
            this.lbl_TotalCompra.Size = new System.Drawing.Size(160, 40);
            this.lbl_TotalCompra.TabIndex = 9;
            this.lbl_TotalCompra.Text = "0";
            this.lbl_TotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_fecharCaixa
            // 
            this.btn_fecharCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fecharCaixa.Enabled = false;
            this.btn_fecharCaixa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fecharCaixa.Location = new System.Drawing.Point(559, 613);
            this.btn_fecharCaixa.Name = "btn_fecharCaixa";
            this.btn_fecharCaixa.Size = new System.Drawing.Size(280, 50);
            this.btn_fecharCaixa.TabIndex = 10;
            this.btn_fecharCaixa.Text = "FECHAR CAIXA";
            this.btn_fecharCaixa.UseVisualStyleBackColor = true;
            this.btn_fecharCaixa.Click += new System.EventHandler(this.btn_fecharCaixa_Click);
            // 
            // btn_fecharVenda
            // 
            this.btn_fecharVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fecharVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fecharVenda.Location = new System.Drawing.Point(1049, 613);
            this.btn_fecharVenda.Name = "btn_fecharVenda";
            this.btn_fecharVenda.Size = new System.Drawing.Size(280, 50);
            this.btn_fecharVenda.TabIndex = 11;
            this.btn_fecharVenda.Text = "FECHAR VENDA";
            this.btn_fecharVenda.UseVisualStyleBackColor = true;
            this.btn_fecharVenda.Click += new System.EventHandler(this.btn_fecharVenda_Click);
            // 
            // FrmCaixaPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 694);
            this.Controls.Add(this.btn_fecharVenda);
            this.Controls.Add(this.btn_fecharCaixa);
            this.Controls.Add(this.lbl_TotalCompra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ltv_produtos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmCaixaPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCaixaPDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fotoProduto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_data;
        private Panel panel1;
        private Button btn_salvarProduto;
        private TextBox txt_totalProduto;
        private Label label12;
        private Label lbl_quantidade;
        private Button btn_mais;
        private Button btn_menos;
        private Label label10;
        private TextBox txt_precoUnitario;
        private Label label9;
        private PictureBox pbx_fotoProduto;
        private TextBox txt_codigoProduto;
        private Label label8;
        private TextBox txt_descricaoProduto;
        private Label label7;
        private Button btn_pesquisarProduto;
        private Label label6;
        private Panel panel2;
        private ListView ltv_produtos;
        private Label label13;
        private Label lbl_TotalCompra;
        private Button btn_fecharCaixa;
        private Button btn_fecharVenda;
        private Label lbl_nomeAtendente;
        private Label label16;
        private Label lbl_caixaLivre;
        private ColumnHeader colCodigo;
        private ColumnHeader colDescricao;
        private ColumnHeader colPrecoUnitario;
        private ColumnHeader colQuantidade;
        private ColumnHeader colTotalProduto;
        private Label lbl_estoque;
        private Label lbl_idProduto;
        private Label lbl_estAtual;
        public TextBox txt_pesquisarProduto;
    }
}