namespace WinFormsApp1.UI
{
    partial class Frm_CadastroConexao
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
            label1 = new Label();
            TXB_IDConexao = new TextBox();
            label2 = new Label();
            CB_TipoConexao = new ComboBox();
            TXB_Endereco = new TextBox();
            label3 = new Label();
            CB_Tipo = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            TXB_Cliente = new TextBox();
            label6 = new Label();
            TXB_SenhaConexaoRemota = new TextBox();
            label7 = new Label();
            TXB_UsrArtsystem = new TextBox();
            label8 = new Label();
            TXB_SenhaArtsystem = new TextBox();
            label9 = new Label();
            TXB_Observacoes = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label10 = new Label();
            CB_UsrConexaoRemota = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // TXB_IDConexao
            // 
            TXB_IDConexao.Location = new Point(25, 32);
            TXB_IDConexao.Name = "TXB_IDConexao";
            TXB_IDConexao.Size = new Size(43, 27);
            TXB_IDConexao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Conexão";
            // 
            // CB_TipoConexao
            // 
            CB_TipoConexao.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_TipoConexao.FormattingEnabled = true;
            CB_TipoConexao.Items.AddRange(new object[] { "TS", "ANYDESK" });
            CB_TipoConexao.Location = new Point(21, 105);
            CB_TipoConexao.Name = "CB_TipoConexao";
            CB_TipoConexao.Size = new Size(151, 28);
            CB_TipoConexao.TabIndex = 3;
            // 
            // TXB_Endereco
            // 
            TXB_Endereco.Location = new Point(213, 105);
            TXB_Endereco.Name = "TXB_Endereco";
            TXB_Endereco.Size = new Size(138, 27);
            TXB_Endereco.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 82);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Endereço";
            // 
            // CB_Tipo
            // 
            CB_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Tipo.FormattingEnabled = true;
            CB_Tipo.Items.AddRange(new object[] { "SERVIDOR", "SERVERSAT", "RETAG", "OUTROS" });
            CB_Tipo.Location = new Point(377, 105);
            CB_Tipo.Name = "CB_Tipo";
            CB_Tipo.Size = new Size(151, 28);
            CB_Tipo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 82);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 6;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 9);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Cliente";
            // 
            // TXB_Cliente
            // 
            TXB_Cliente.Location = new Point(102, 32);
            TXB_Cliente.Name = "TXB_Cliente";
            TXB_Cliente.ReadOnly = true;
            TXB_Cliente.Size = new Size(414, 27);
            TXB_Cliente.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 229);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 11;
            label6.Text = "Senha Conexão Remota";
            // 
            // TXB_SenhaConexaoRemota
            // 
            TXB_SenhaConexaoRemota.Location = new Point(25, 252);
            TXB_SenhaConexaoRemota.Name = "TXB_SenhaConexaoRemota";
            TXB_SenhaConexaoRemota.Size = new Size(205, 27);
            TXB_SenhaConexaoRemota.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 164);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 13;
            label7.Text = "Usuário ArtSystem";
            // 
            // TXB_UsrArtsystem
            // 
            TXB_UsrArtsystem.Location = new Point(336, 187);
            TXB_UsrArtsystem.Name = "TXB_UsrArtsystem";
            TXB_UsrArtsystem.Size = new Size(192, 27);
            TXB_UsrArtsystem.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 229);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 15;
            label8.Text = "Senha ArtSystem";
            // 
            // TXB_SenhaArtsystem
            // 
            TXB_SenhaArtsystem.Location = new Point(336, 252);
            TXB_SenhaArtsystem.Name = "TXB_SenhaArtsystem";
            TXB_SenhaArtsystem.Size = new Size(192, 27);
            TXB_SenhaArtsystem.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 320);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 17;
            label9.Text = "Observações";
            // 
            // TXB_Observacoes
            // 
            TXB_Observacoes.Location = new Point(25, 343);
            TXB_Observacoes.Multiline = true;
            TXB_Observacoes.Name = "TXB_Observacoes";
            TXB_Observacoes.Size = new Size(503, 66);
            TXB_Observacoes.TabIndex = 16;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(136, 451);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(236, 451);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(336, 451);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 20;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 148);
            label10.Name = "label10";
            label10.Size = new Size(177, 20);
            label10.TabIndex = 21;
            label10.Text = "Usuário Conexão Remota";
            // 
            // CB_UsrConexaoRemota
            // 
            CB_UsrConexaoRemota.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_UsrConexaoRemota.FormattingEnabled = true;
            CB_UsrConexaoRemota.Items.AddRange(new object[] { "ART", "ARTYSTEM", "AS_BXALOGS", "AS_INSTALL", "TODOS" });
            CB_UsrConexaoRemota.Location = new Point(21, 184);
            CB_UsrConexaoRemota.Name = "CB_UsrConexaoRemota";
            CB_UsrConexaoRemota.Size = new Size(209, 28);
            CB_UsrConexaoRemota.TabIndex = 22;
            // 
            // Frm_CadastroConexao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 511);
            Controls.Add(CB_UsrConexaoRemota);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(TXB_Observacoes);
            Controls.Add(label8);
            Controls.Add(TXB_SenhaArtsystem);
            Controls.Add(label7);
            Controls.Add(TXB_UsrArtsystem);
            Controls.Add(label6);
            Controls.Add(TXB_SenhaConexaoRemota);
            Controls.Add(label5);
            Controls.Add(TXB_Cliente);
            Controls.Add(CB_Tipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TXB_Endereco);
            Controls.Add(CB_TipoConexao);
            Controls.Add(label2);
            Controls.Add(TXB_IDConexao);
            Controls.Add(label1);
            Name = "Frm_CadastroConexao";
            Text = "Cadastro Conexões";
            Load += Frm_CadastroConexao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TXB_IDConexao;
        private Label label2;
        private ComboBox CB_TipoConexao;
        private TextBox TXB_Endereco;
        private Label label3;
        private ComboBox CB_Tipo;
        private Label label4;
        private Label label5;
        private TextBox TXB_Cliente;
        private Label label6;
        private TextBox TXB_SenhaConexaoRemota;
        private Label label7;
        private TextBox TXB_UsrArtsystem;
        private Label label8;
        private TextBox TXB_SenhaArtsystem;
        private Label label9;
        private TextBox TXB_Observacoes;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label10;
        private ComboBox CB_UsrConexaoRemota;
    }
}