namespace WinFormsApp1.UI.UserControls
{
    partial class Frm_CadastroClientes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TXB_ID = new TextBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label5 = new Label();
            TXB_Observacao = new TextBox();
            MTXB_Cnpj = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            TXB_Apelido = new TextBox();
            label2 = new Label();
            TXB_Nome = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            LSTB_Contatos = new ListBox();
            LSTB_Conexoes = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // TXB_ID
            // 
            TXB_ID.Location = new Point(15, 48);
            TXB_ID.Name = "TXB_ID";
            TXB_ID.Size = new Size(55, 23);
            TXB_ID.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TXB_Observacao);
            groupBox1.Controls.Add(MTXB_Cnpj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TXB_Apelido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TXB_Nome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TXB_ID);
            groupBox1.Location = new Point(21, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 192);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // button4
            // 
            button4.Location = new Point(76, 48);
            button4.Name = "button4";
            button4.Size = new Size(28, 23);
            button4.TabIndex = 7;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 79);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 9;
            label5.Text = "Observações";
            // 
            // TXB_Observacao
            // 
            TXB_Observacao.AcceptsReturn = true;
            TXB_Observacao.AcceptsTab = true;
            TXB_Observacao.HideSelection = false;
            TXB_Observacao.Location = new Point(15, 97);
            TXB_Observacao.MaxLength = 1000;
            TXB_Observacao.Multiline = true;
            TXB_Observacao.Name = "TXB_Observacao";
            TXB_Observacao.Size = new Size(744, 76);
            TXB_Observacao.TabIndex = 8;
            // 
            // MTXB_Cnpj
            // 
            MTXB_Cnpj.Location = new Point(484, 48);
            MTXB_Cnpj.Mask = "00,000,000/0000-00";
            MTXB_Cnpj.Name = "MTXB_Cnpj";
            MTXB_Cnpj.Size = new Size(134, 23);
            MTXB_Cnpj.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 30);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(625, 30);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Apelido";
            // 
            // TXB_Apelido
            // 
            TXB_Apelido.Location = new Point(624, 49);
            TXB_Apelido.Name = "TXB_Apelido";
            TXB_Apelido.Size = new Size(134, 23);
            TXB_Apelido.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 30);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome/Razão Social";
            // 
            // TXB_Nome
            // 
            TXB_Nome.Location = new Point(110, 48);
            TXB_Nome.Name = "TXB_Nome";
            TXB_Nome.Size = new Size(369, 23);
            TXB_Nome.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(LSTB_Contatos);
            groupBox2.Controls.Add(LSTB_Conexoes);
            groupBox2.Location = new Point(21, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 224);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados De Conexão";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(533, 29);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 11;
            label7.Text = "Contatos Loja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 29);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 10;
            label6.Text = "Conexões Remotas";
            label6.Click += label6_Click;
            // 
            // LSTB_Contatos
            // 
            LSTB_Contatos.FormattingEnabled = true;
            LSTB_Contatos.ItemHeight = 15;
            LSTB_Contatos.Location = new Point(395, 47);
            LSTB_Contatos.Name = "LSTB_Contatos";
            LSTB_Contatos.Size = new Size(369, 169);
            LSTB_Contatos.TabIndex = 1;
            // 
            // LSTB_Conexoes
            // 
            LSTB_Conexoes.FormattingEnabled = true;
            LSTB_Conexoes.ItemHeight = 15;
            LSTB_Conexoes.Location = new Point(15, 47);
            LSTB_Conexoes.Name = "LSTB_Conexoes";
            LSTB_Conexoes.Size = new Size(369, 169);
            LSTB_Conexoes.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(280, 465);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(375, 465);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(469, 465);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroClientes";
            Size = new Size(821, 551);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox TXB_ID;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox TXB_Nome;
        private Label label4;
        private Label label3;
        private TextBox TXB_Apelido;
        private MaskedTextBox MTXB_Cnpj;
        private Label label5;
        private TextBox TXB_Observacao;
        private GroupBox groupBox2;
        private ListBox LSTB_Contatos;
        private ListBox LSTB_Conexoes;
        private Label label6;
        private Button button4;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
