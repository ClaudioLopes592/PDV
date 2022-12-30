namespace PDV
{
    partial class FrmFecharCompra
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
            this.txt_valorRecebido = new System.Windows.Forms.TextBox();
            this.btn_receber = new System.Windows.Forms.Button();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_faturado = new System.Windows.Forms.Button();
            this.btn_pix = new System.Windows.Forms.Button();
            this.btn_cartao = new System.Windows.Forms.Button();
            this.btn_dinheiro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalAReceber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_valorRecebido);
            this.groupBox1.Controls.Add(this.btn_receber);
            this.groupBox1.Controls.Add(this.lbl_troco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_faturado);
            this.groupBox1.Controls.Add(this.btn_pix);
            this.groupBox1.Controls.Add(this.btn_cartao);
            this.groupBox1.Controls.Add(this.btn_dinheiro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_totalAReceber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encerrar Venda";
            // 
            // txt_valorRecebido
            // 
            this.txt_valorRecebido.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_valorRecebido.Location = new System.Drawing.Point(249, 300);
            this.txt_valorRecebido.Name = "txt_valorRecebido";
            this.txt_valorRecebido.Size = new System.Drawing.Size(141, 31);
            this.txt_valorRecebido.TabIndex = 13;
            this.txt_valorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valorRecebido.TextChanged += new System.EventHandler(this.txt_valorRecebido_TextChanged);
            this.txt_valorRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorRecebido_KeyPress);
            // 
            // btn_receber
            // 
            this.btn_receber.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_receber.Location = new System.Drawing.Point(491, 372);
            this.btn_receber.Name = "btn_receber";
            this.btn_receber.Size = new System.Drawing.Size(213, 50);
            this.btn_receber.TabIndex = 12;
            this.btn_receber.Text = "RECEBER";
            this.btn_receber.UseVisualStyleBackColor = true;
            this.btn_receber.Click += new System.EventHandler(this.btn_receber_Click);
            // 
            // lbl_troco
            // 
            this.lbl_troco.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_troco.Location = new System.Drawing.Point(554, 294);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.Size = new System.Drawing.Size(150, 40);
            this.lbl_troco.TabIndex = 11;
            this.lbl_troco.Text = "0";
            this.lbl_troco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(428, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "TROCO R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "VALOR RECEBIDO R$";
            // 
            // btn_faturado
            // 
            this.btn_faturado.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_faturado.Location = new System.Drawing.Point(554, 203);
            this.btn_faturado.Name = "btn_faturado";
            this.btn_faturado.Size = new System.Drawing.Size(150, 50);
            this.btn_faturado.TabIndex = 7;
            this.btn_faturado.Text = "FATURADO";
            this.btn_faturado.UseVisualStyleBackColor = true;
            // 
            // btn_pix
            // 
            this.btn_pix.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_pix.Location = new System.Drawing.Point(372, 203);
            this.btn_pix.Name = "btn_pix";
            this.btn_pix.Size = new System.Drawing.Size(150, 50);
            this.btn_pix.TabIndex = 6;
            this.btn_pix.Text = "PIX";
            this.btn_pix.UseVisualStyleBackColor = true;
            // 
            // btn_cartao
            // 
            this.btn_cartao.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_cartao.Location = new System.Drawing.Point(190, 203);
            this.btn_cartao.Name = "btn_cartao";
            this.btn_cartao.Size = new System.Drawing.Size(150, 50);
            this.btn_cartao.TabIndex = 5;
            this.btn_cartao.Text = "CARTÃO";
            this.btn_cartao.UseVisualStyleBackColor = true;
            // 
            // btn_dinheiro
            // 
            this.btn_dinheiro.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_dinheiro.Location = new System.Drawing.Point(6, 203);
            this.btn_dinheiro.Name = "btn_dinheiro";
            this.btn_dinheiro.Size = new System.Drawing.Size(150, 50);
            this.btn_dinheiro.TabIndex = 4;
            this.btn_dinheiro.Text = "DINHEIRO";
            this.btn_dinheiro.UseVisualStyleBackColor = true;
            this.btn_dinheiro.Click += new System.EventHandler(this.btn_dinheiro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "FORMA DE PAGAMENTO";
            // 
            // lbl_totalAReceber
            // 
            this.lbl_totalAReceber.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalAReceber.Location = new System.Drawing.Point(253, 95);
            this.lbl_totalAReceber.Name = "lbl_totalAReceber";
            this.lbl_totalAReceber.Size = new System.Drawing.Size(150, 40);
            this.lbl_totalAReceber.TabIndex = 2;
            this.lbl_totalAReceber.Text = "0";
            this.lbl_totalAReceber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL A RECEBER R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGAMENTO";
            // 
            // FrmFecharCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 458);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "FrmFecharCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - Fechar Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_receber;
        private Label lbl_troco;
        private Label label8;
        private Label label6;
        private Button btn_faturado;
        private Button btn_pix;
        private Button btn_cartao;
        private Button btn_dinheiro;
        private Label label4;
        private Label label2;
        private Label label1;
        public Label lbl_totalAReceber;
        private TextBox txt_valorRecebido;
    }
}