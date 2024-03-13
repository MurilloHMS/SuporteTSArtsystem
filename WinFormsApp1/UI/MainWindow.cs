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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Frm_CadastroClientes frm = new Frm_CadastroClientes();
            frm.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Cadastro Clientes";
            tb.Text = "Clientes";
            tb.Controls.Add(frm);
            TB_MainWindow.TabPages.Add(tb);
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Configuracoes frm = new Frm_Configuracoes();
            frm.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "ConfiguracoesGerais";
            tb.Text = "Configurações Gerais";
            tb.Controls.Add(frm);
            TB_MainWindow.TabPages.Add(tb);
        }
        private ToolStripMenuItem CriaItemMenu(String text, string nomeDoIcone)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            //Icon myIcon = (Icon)global::WinFormsApp1.Properties.Resources.ResourceManager.GetObject(nomeDoIcone)!;
            //vToolTip.Image = myIcon.ToBitmap();
            return vToolTip;

        }
        private void TB_MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = CriaItemMenu("Fechar Aba", "Close Tab");
                var vToolTip002 = CriaItemMenu("Fechar Todas as Abas", "Close All Tabs");
                var vToolTip003 = CriaItemMenu("Fechar Todas as Abas a Direita", "Close Pane");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);

                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);

            }

            void vToolTip001_Click(object sender, EventArgs e)
            {
                //apaga a aba selecionada 
                if (!(TB_MainWindow.SelectedTab == null))
                {
                    TB_MainWindow.TabPages.Remove(TB_MainWindow.SelectedTab);
                }
            }
            void vToolTip002_Click(object sender, EventArgs e)
            {
                //apaga todas as abas
                TB_MainWindow.TabPages.Clear();
            }
            void vToolTip003_Click(object sender, EventArgs e)
            {
                //apaga todas as abas a direita
                if (!(TB_MainWindow.SelectedTab == null))
                {
                    int ItemSelecionado = TB_MainWindow.SelectedIndex;

                    for (int i = TB_MainWindow.TabCount - 1; i > ItemSelecionado; i += -1)
                    {

                        TB_MainWindow.TabPages.Remove(TB_MainWindow.TabPages[i]);

                    }
                }
            }
        }
    }
}
