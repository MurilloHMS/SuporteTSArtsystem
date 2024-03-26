namespace SuporteArtSystem
{
    partial class Frm_MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainWindow));
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            geralToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClientesToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            TB_MainWindow = new TabControl();
            cadastroDeContatosToolStripMenuItem = new ToolStripMenuItem();
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
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configuraçõesToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(73, 24);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geralToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(187, 26);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // geralToolStripMenuItem
            // 
            geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            geralToolStripMenuItem.Size = new Size(127, 26);
            geralToolStripMenuItem.Text = "Geral";
            geralToolStripMenuItem.Click += geralToolStripMenuItem_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeClientesToolStripMenuItem, cadastroDeContatosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            cadastroDeClientesToolStripMenuItem.Size = new Size(240, 26);
            cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Conexões";
            cadastroDeClientesToolStripMenuItem.Click += cadastroDeClientesToolStripMenuItem_Click;
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
            TB_MainWindow.MouseDown += TB_MainWindow_MouseDown;
            // 
            // cadastroDeContatosToolStripMenuItem
            // 
            cadastroDeContatosToolStripMenuItem.Name = "cadastroDeContatosToolStripMenuItem";
            cadastroDeContatosToolStripMenuItem.Size = new Size(240, 26);
            cadastroDeContatosToolStripMenuItem.Text = "Cadastro de Contatos";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 821);
            Controls.Add(TB_MainWindow);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private TabControl TB_MainWindow;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem geralToolStripMenuItem;
        private ToolStripMenuItem cadastroDeContatosToolStripMenuItem;
    }
}
