﻿namespace WinFormsApp1.UI.UserControls
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
            button5 = new Button();
            button7 = new Button();
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
            groupBox1.Size = new Size(780, 192);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // button4
            // 
            button4.Location = new Point(76, 45);
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
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(21, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 279);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados De Conexão";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 18);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(760, 256);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DGV_ConexoesRemotas);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(752, 228);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Conexões Remotas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGV_ConexoesRemotas
            // 
            DGV_ConexoesRemotas.AllowUserToAddRows = false;
            DGV_ConexoesRemotas.AllowUserToDeleteRows = false;
            DGV_ConexoesRemotas.BackgroundColor = SystemColors.Control;
            DGV_ConexoesRemotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ConexoesRemotas.Location = new Point(3, 2);
            DGV_ConexoesRemotas.Margin = new Padding(3, 2, 3, 2);
            DGV_ConexoesRemotas.MultiSelect = false;
            DGV_ConexoesRemotas.Name = "DGV_ConexoesRemotas";
            DGV_ConexoesRemotas.ReadOnly = true;
            DGV_ConexoesRemotas.RowHeadersWidth = 51;
            DGV_ConexoesRemotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_ConexoesRemotas.Size = new Size(747, 196);
            DGV_ConexoesRemotas.TabIndex = 15;
            DGV_ConexoesRemotas.CellMouseDoubleClick += DGV_ConexoesRemotas_CellMouseDoubleClick;
            DGV_ConexoesRemotas.KeyDown += DGV_ConexoesRemotas_KeyDown;
            DGV_ConexoesRemotas.KeyPress += DGV_ConexoesRemotas_KeyPress;
            DGV_ConexoesRemotas.MouseDoubleClick += DGV_ConexoesRemotas_MouseDoubleClick;
            // 
            // button5
            // 
            button5.Location = new Point(385, 202);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(304, 200);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(752, 228);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados de Contato";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(378, 202);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 15;
            button8.Text = "Cancelar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(298, 202);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 13;
            button10.Text = "Inserir";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // LSTB_Contatos
            // 
            LSTB_Contatos.FormattingEnabled = true;
            LSTB_Contatos.ItemHeight = 15;
            LSTB_Contatos.Location = new Point(10, 12);
            LSTB_Contatos.Name = "LSTB_Contatos";
            LSTB_Contatos.Size = new Size(730, 184);
            LSTB_Contatos.TabIndex = 12;
            // 
            // Frm_CadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroClientes";
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
        private Button button7;
        private Button button8;
        private Button button10;
        private DataGridView DGV_ConexoesRemotas;
    }
}
