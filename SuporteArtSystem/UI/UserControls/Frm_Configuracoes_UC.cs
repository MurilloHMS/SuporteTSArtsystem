﻿using SuporteArtSystem.Databases;

namespace SuporteArtSystem.UI.UserControls
{
    public partial class Frm_Configuracoes_UC : UserControl
    {
        public Frm_Configuracoes_UC()
        {
            InitializeComponent();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.DatabaseName = TXB_EnderecoSql.Text;
            settings.Anydesk = TXT_enderecoAnydesk.Text;
            MessageBox.Show("Dados salvos com sucesso! ");

        }

        private void Frm_Configuracoes_Load(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            TXB_EnderecoSql.Text = settings.DatabaseName;
            TXT_enderecoAnydesk.Text = settings.Anydesk;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        TXT_enderecoAnydesk.Text = ofd.FileName;
                    }
                }
            }
            catch (Exception)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.InitialDirectory = @"C:\";
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        TXT_enderecoAnydesk.Text = ofd.FileName;
                    }
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SuporteContext context = new SuporteContext();
            context.CriarTabelaASENTENT_CON();
            MessageBox.Show("Tabela de Conexão criada com sucesso!", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}