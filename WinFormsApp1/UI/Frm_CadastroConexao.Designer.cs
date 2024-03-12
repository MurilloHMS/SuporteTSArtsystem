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
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label10 = new Label();
            comboBox3 = new ComboBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(25, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 27);
            textBox1.TabIndex = 1;
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TS", "ANYDESK" });
            comboBox1.Location = new Point(21, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 82);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 5;
            label3.Text = "IP";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SERVIDOR", "SERVERSAT", "RETAG", "OUTROS" });
            comboBox2.Location = new Point(377, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 7;
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
            // textBox3
            // 
            textBox3.Location = new Point(102, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 27);
            textBox3.TabIndex = 8;
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
            // textBox4
            // 
            textBox4.Location = new Point(25, 252);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 27);
            textBox4.TabIndex = 10;
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
            // textBox5
            // 
            textBox5.Location = new Point(336, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(192, 27);
            textBox5.TabIndex = 12;
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
            // textBox6
            // 
            textBox6.Location = new Point(336, 252);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(192, 27);
            textBox6.TabIndex = 14;
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
            // textBox7
            // 
            textBox7.Location = new Point(25, 343);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(503, 66);
            textBox7.TabIndex = 16;
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
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "ART", "ARTYSTEM", "AS_BXALOGS", "AS_INSTALL", "TODOS" });
            comboBox3.Location = new Point(21, 184);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(209, 28);
            comboBox3.TabIndex = 22;
            // 
            // Frm_CadastroConexao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 511);
            Controls.Add(comboBox3);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Frm_CadastroConexao";
            Text = "Cadastro Conexões";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label10;
        private ComboBox comboBox3;
    }
}