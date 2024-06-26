﻿namespace SuporteArtSystem.UI.UserControls
{
    partial class Frm_CadastroClientes_UC
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
            MTXB_Cnpj = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            TXB_Apelido = new TextBox();
            label2 = new Label();
            TXB_Nome = new TextBox();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DGV_ConexoesRemotas = new DataGridView();
            Btn_Alterar = new Button();
            button5 = new Button();
            Btn_Inserir = new Button();
            tabPage2 = new TabPage();
            button8 = new Button();
            button10 = new Button();
            LSTB_Contatos = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_ConexoesRemotas).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // TXB_ID
            // 
            TXB_ID.Location = new Point(15, 48);
            TXB_ID.Name = "TXB_ID";
            TXB_ID.Size = new Size(55, 23);
            TXB_ID.TabIndex = 1;
            TXB_ID.KeyDown += TXB_ID_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
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
            groupBox1.Size = new Size(780, 107);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // button4
            // 
            button4.Location = new Point(76, 47);
            button4.Name = "button4";
            button4.Size = new Size(28, 23);
            button4.TabIndex = 7;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            TXB_Apelido.KeyDown += TXB_Apelido_KeyDown;
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
            TXB_Nome.KeyDown += TXB_Nome_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(21, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 396);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados De Conexão";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 18);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(769, 373);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DGV_ConexoesRemotas);
            tabPage1.Controls.Add(Btn_Alterar);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(Btn_Inserir);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(761, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Conexões Remotas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGV_ConexoesRemotas
            // 
            DGV_ConexoesRemotas.AllowUserToAddRows = false;
            DGV_ConexoesRemotas.AllowUserToDeleteRows = false;
            DGV_ConexoesRemotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_ConexoesRemotas.BackgroundColor = SystemColors.Control;
            DGV_ConexoesRemotas.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            DGV_ConexoesRemotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ConexoesRemotas.EditMode = DataGridViewEditMode.EditOnKeystroke;
            DGV_ConexoesRemotas.Location = new Point(3, 2);
            DGV_ConexoesRemotas.Margin = new Padding(3, 2, 3, 2);
            DGV_ConexoesRemotas.MultiSelect = false;
            DGV_ConexoesRemotas.Name = "DGV_ConexoesRemotas";
            DGV_ConexoesRemotas.RowHeadersWidth = 51;
            DGV_ConexoesRemotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_ConexoesRemotas.Size = new Size(747, 308);
            DGV_ConexoesRemotas.TabIndex = 15;
            DGV_ConexoesRemotas.CellMouseDoubleClick += DGV_ConexoesRemotas_CellMouseDoubleClick;
            DGV_ConexoesRemotas.KeyDown += DGV_ConexoesRemotas_KeyDown;
            // 
            // Btn_Alterar
            // 
            Btn_Alterar.Location = new Point(340, 315);
            Btn_Alterar.Name = "Btn_Alterar";
            Btn_Alterar.Size = new Size(75, 23);
            Btn_Alterar.TabIndex = 14;
            Btn_Alterar.Text = "&Alterar";
            Btn_Alterar.UseVisualStyleBackColor = true;
            Btn_Alterar.Click += Btn_Alterar_Click;
            // 
            // button5
            // 
            button5.Location = new Point(421, 315);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "&Cancelar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Btn_Inserir
            // 
            Btn_Inserir.Location = new Point(259, 315);
            Btn_Inserir.Name = "Btn_Inserir";
            Btn_Inserir.Size = new Size(75, 23);
            Btn_Inserir.TabIndex = 12;
            Btn_Inserir.Text = "&Inserir";
            Btn_Inserir.UseVisualStyleBackColor = true;
            Btn_Inserir.Click += button7_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(LSTB_Contatos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(761, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados de Contato";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(381, 317);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 15;
            button8.Text = "Cancelar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(301, 317);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 13;
            button10.Text = "Inserir";
            button10.UseVisualStyleBackColor = true;
            // 
            // LSTB_Contatos
            // 
            LSTB_Contatos.Dock = DockStyle.Top;
            LSTB_Contatos.FormattingEnabled = true;
            LSTB_Contatos.ItemHeight = 15;
            LSTB_Contatos.Location = new Point(3, 2);
            LSTB_Contatos.Name = "LSTB_Contatos";
            LSTB_Contatos.Size = new Size(755, 304);
            LSTB_Contatos.TabIndex = 12;
            // 
            // Frm_CadastroClientes_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroClientes_UC";
            Size = new Size(821, 580);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_ConexoesRemotas).EndInit();
            tabPage2.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox LSTB_Contatos;
        private Button button5;
        private Button Btn_Inserir;
        private Button button8;
        private Button button10;
        private DataGridView DGV_ConexoesRemotas;
        private Button Btn_Alterar;
    }
}
