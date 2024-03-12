using WinFormsApp1.UI.UserControls;

namespace WinFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroClientes frm = new Frm_CadastroClientes();
            frm.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Cadastro de Clientes";
            tb.Text = "Conexão Remota Cliente";
            tb.Controls.Add(frm);
            TB_MainWindow.TabPages.Add(tb);
        }
    }
}
