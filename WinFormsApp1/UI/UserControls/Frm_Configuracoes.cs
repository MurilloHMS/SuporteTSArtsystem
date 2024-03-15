using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Databases;

namespace WinFormsApp1.UI.UserControls
{
    public partial class Frm_Configuracoes : UserControl
    {
        public Frm_Configuracoes()
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
            }catch(Exception)
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
    }
}
