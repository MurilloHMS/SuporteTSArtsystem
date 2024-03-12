﻿namespace WinFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClientesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeConexõesToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            TB_MainWindow = new TabControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, cadastrosToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(943, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(73, 24);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeClientesToolStripMenuItem, cadastroDeConexõesToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            cadastroDeClientesToolStripMenuItem.Size = new Size(240, 26);
            cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            cadastroDeClientesToolStripMenuItem.Click += cadastroDeClientesToolStripMenuItem_Click;
            // 
            // cadastroDeConexõesToolStripMenuItem
            // 
            cadastroDeConexõesToolStripMenuItem.Name = "cadastroDeConexõesToolStripMenuItem";
            cadastroDeConexõesToolStripMenuItem.Size = new Size(240, 26);
            cadastroDeConexõesToolStripMenuItem.Text = "Cadastro de Conexões";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(62, 24);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // TB_MainWindow
            // 
            TB_MainWindow.Dock = DockStyle.Fill;
            TB_MainWindow.Location = new Point(0, 30);
            TB_MainWindow.Margin = new Padding(3, 4, 3, 4);
            TB_MainWindow.Name = "TB_MainWindow";
            TB_MainWindow.SelectedIndex = 0;
            TB_MainWindow.Size = new Size(943, 791);
            TB_MainWindow.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 821);
            Controls.Add(TB_MainWindow);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "ArtSystem Suporte";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeConexõesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private TabControl TB_MainWindow;
    }
}
