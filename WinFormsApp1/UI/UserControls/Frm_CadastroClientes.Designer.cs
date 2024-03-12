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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button5 = new Button();
            button7 = new Button();
            tabPage2 = new TabPage();
            button8 = new Button();
            button10 = new Button();
            LSTB_Contatos = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            DGV_ConexoesRemotas = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_ConexoesRemotas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // TXB_ID
            // 
            TXB_ID.Location = new Point(17, 64);
            TXB_ID.Margin = new Padding(3, 4, 3, 4);
            TXB_ID.Name = "TXB_ID";
            TXB_ID.Size = new Size(62, 27);
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
            groupBox1.Location = new Point(24, 24);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(891, 256);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // button4
            // 
            button4.Location = new Point(87, 60);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(32, 31);
            button4.TabIndex = 7;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 148);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "Observações";
            // 
            // TXB_Observacao
            // 
            TXB_Observacao.AcceptsReturn = true;
            TXB_Observacao.AcceptsTab = true;
            TXB_Observacao.HideSelection = false;
            TXB_Observacao.Location = new Point(17, 181);
            TXB_Observacao.Margin = new Padding(3, 4, 3, 4);
            TXB_Observacao.MaxLength = 1000;
            TXB_Observacao.Multiline = true;
            TXB_Observacao.Name = "TXB_Observacao";
            TXB_Observacao.Size = new Size(850, 48);
            TXB_Observacao.TabIndex = 8;
            // 
            // MTXB_Cnpj
            // 
            MTXB_Cnpj.Location = new Point(553, 64);
            MTXB_Cnpj.Margin = new Padding(3, 4, 3, 4);
            MTXB_Cnpj.Mask = "00,000,000/0000-00";
            MTXB_Cnpj.Name = "MTXB_Cnpj";
            MTXB_Cnpj.Size = new Size(153, 27);
            MTXB_Cnpj.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 40);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(714, 40);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Apelido";
            // 
            // TXB_Apelido
            // 
            TXB_Apelido.Location = new Point(713, 65);
            TXB_Apelido.Margin = new Padding(3, 4, 3, 4);
            TXB_Apelido.Name = "TXB_Apelido";
            TXB_Apelido.Size = new Size(153, 27);
            TXB_Apelido.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 40);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome/Razão Social";
            // 
            // TXB_Nome
            // 
            TXB_Nome.Location = new Point(126, 64);
            TXB_Nome.Margin = new Padding(3, 4, 3, 4);
            TXB_Nome.Name = "TXB_Nome";
            TXB_Nome.Size = new Size(421, 27);
            TXB_Nome.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(24, 330);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(891, 372);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados De Conexão";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(17, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(868, 341);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DGV_ConexoesRemotas);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button7);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(860, 308);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Conexões Remotas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(439, 271);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 14;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(347, 270);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 31);
            button7.TabIndex = 12;
            button7.Text = "Inserir";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(LSTB_Contatos);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(860, 308);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados de Contato";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(432, 270);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 15;
            button8.Text = "Cancelar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(340, 270);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(86, 31);
            button10.TabIndex = 13;
            button10.Text = "Inserir";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // LSTB_Contatos
            // 
            LSTB_Contatos.FormattingEnabled = true;
            LSTB_Contatos.Location = new Point(11, 16);
            LSTB_Contatos.Margin = new Padding(3, 4, 3, 4);
            LSTB_Contatos.Name = "LSTB_Contatos";
            LSTB_Contatos.Size = new Size(834, 244);
            LSTB_Contatos.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(325, 710);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(434, 710);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 5;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(541, 710);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 6;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // DGV_ConexoesRemotas
            // 
            DGV_ConexoesRemotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ConexoesRemotas.Dock = DockStyle.Fill;
            DGV_ConexoesRemotas.Location = new Point(3, 3);
            DGV_ConexoesRemotas.Name = "DGV_ConexoesRemotas";
            DGV_ConexoesRemotas.RowHeadersWidth = 51;
            DGV_ConexoesRemotas.Size = new Size(854, 302);
            DGV_ConexoesRemotas.TabIndex = 15;
            // 
            // Frm_CadastroClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_CadastroClientes";
            Size = new Size(938, 774);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_ConexoesRemotas).EndInit();
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
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox LSTB_Contatos;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView DGV_ConexoesRemotas;
    }
}
