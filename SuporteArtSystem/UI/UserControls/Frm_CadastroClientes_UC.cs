using System.Diagnostics;
using Microsoft.Data.SqlClient;
using SuporteArtSystem.Databases;
using SuporteArtSystem.Models;

namespace SuporteArtSystem.UI.UserControls
{
    public partial class Frm_CadastroClientes_UC : UserControl
    {

        private readonly ASENTENT clientes = new ASENTENT();

        public Frm_CadastroClientes_UC()
        {
            InitializeComponent();
            TXB_Nome.CharacterCasing = CharacterCasing.Upper;
            TXB_Apelido.CharacterCasing = CharacterCasing.Upper;
            AutoCompleteNome();
            AutoCompleteApelido();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Consulta finder = new Frm_Consulta();
            finder.ShowDialog();

            var id = finder.idSelect;

            if (finder.DialogResult == DialogResult.OK)
            {
                Preencher(id);
            }
        }

        private void PreencherBuscaPorNome(string nome)
        {
            try
            {
                var consulta = clientes.RetornaClientePorNome(nome);
                int id = consulta.ENTNID_ENT;
                Preencher(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void PreencherBuscaPorApelido(string apelido)
        {
            var consulta = clientes.RetornaClientePorApelido(apelido);
            int id = consulta.ENTNID_ENT;
            Preencher(id);
        }

        private void Preencher(int id)
        {

            var recuperaClientePorNome = clientes.RetornaClientePorId(id);
            var idCliente = recuperaClientePorNome.ENTNID_ENT;
            TXB_ID.Text = Convert.ToString(idCliente);
            TXB_Nome.Text = recuperaClientePorNome.ENTCNOMENT;
            TXB_Apelido.Text = recuperaClientePorNome.ENTCAPELID;
            MTXB_Cnpj.Text = recuperaClientePorNome.ENTCCODCPF;
            var context = new SuporteContext();
            var conexoesDal = new DAL<ASENTENT_CON>(context);
            var resultado = conexoesDal.listFor(r => r.CONNIDCLI.Equals(idCliente));

            DGV_ConexoesRemotas.DataSource = resultado;
            DGV_ConexoesRemotas.Columns["CONNID_CON"].Visible = false;
            DGV_ConexoesRemotas.Columns["CONCTIPCO"].HeaderText = "TIPO CONEXÃO";
            DGV_ConexoesRemotas.Columns["CONCDESC"].HeaderText = "DESCRIÇÃO";
            DGV_ConexoesRemotas.Columns["CONCIPCON"].HeaderText = "IP CONEXÃO";
            DGV_ConexoesRemotas.Columns["CONCTIP"].HeaderText = "TIPO";
            DGV_ConexoesRemotas.Columns["CONCUSRTS"].HeaderText = "USUÁRIO CONEXÃO";
            DGV_ConexoesRemotas.Columns["CONCSENTS"].HeaderText = "SENHA CONEXÃO";
            DGV_ConexoesRemotas.Columns["CONCUSRART"].HeaderText = "USUÁRIO ARTSYSTEM";
            DGV_ConexoesRemotas.Columns["CONCSENART"].HeaderText = "SENHA ARTSYSTEM";
            DGV_ConexoesRemotas.Columns["CONNIDCLI"].Visible = false;
        }

        private void AlterarDadosSelecionados()
        {
            DialogResult msg = MessageBox.Show("Deseja alterar a Conexão selecionada? ", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = DGV_ConexoesRemotas.SelectedRows[0];

                string ids = selectedRow.Cells[0].Value.ToString();
                var nomeCliente = TXB_Nome.Text;
                int id = int.Parse(ids);
                Frm_CadastroConexao frm = new Frm_CadastroConexao(id, nomeCliente, true);
                frm.ShowDialog();
                int idCliente = int.Parse(TXB_ID.Text);
                Preencher(idCliente);

            }
        }

        private void AutoCompleteNome()
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();
            var todosOsClientes = clientes.RetornaClientes();

            foreach (var item in todosOsClientes)
            {
                autoCompleteCollection.Add(item.ENTCNOMENT.Trim());
            }

            TXB_Nome.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TXB_Nome.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TXB_Nome.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void AutoCompleteApelido()
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();
            var todosOsClientes = clientes.RetornaClientes();

            foreach (var item in todosOsClientes)
            {
                autoCompleteCollection.Add(item.ENTCAPELID.Trim());
            }

            TXB_Apelido.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TXB_Apelido.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TXB_Apelido.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TXB_ID.Text))
            {
                int idCliente = Convert.ToInt32(TXB_ID.Text);
                var nomeCliente = TXB_Nome.Text;
                Frm_CadastroConexao frm = new Frm_CadastroConexao(idCliente, nomeCliente, false);
                frm.ShowDialog();
                Preencher(idCliente);

            }

        }

        private void DGV_ConexoesRemotas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = DGV_ConexoesRemotas.Rows[e.RowIndex];
                string value = row.Cells[3].Value.ToString();
                string tipoConexao = row.Cells[1].Value.ToString();
                string username = row.Cells[5].Value.ToString();
                Process process = new Process();
                Settings settings = new Settings();
                string anydesk = settings.Anydesk;

                switch (tipoConexao)
                {
                    case "ANYDESK":
                        if (!string.IsNullOrEmpty(anydesk))
                        {
                            process.StartInfo.FileName = anydesk;
                            process.StartInfo.Arguments = $"{value}";
                        }
                        else
                        {
                            MessageBox.Show("Falta configurar o anydesk");
                            return;
                        }

                        break;
                    case "TS":
                        string rdpFilePath = Path.Combine(Path.GetTempPath(), "remote_connection.rdp");
                        using (StreamWriter sw = new StreamWriter(rdpFilePath))
                        {
                            sw.WriteLine($"full address:s:{value}");
                            sw.WriteLine($"username:s:{username}");
                        }
                        process.StartInfo.FileName = "mstsc.exe";
                        process.StartInfo.Arguments = $"{rdpFilePath}";
                        break;
                }
                process.Start();
            }
        }

        private void DGV_ConexoesRemotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult msg = MessageBox.Show("Deseja Excluir a Conexão selecionada? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    var context = new SuporteContext();
                    var conexoesDal = new DAL<ASENTENT_CON>(context);

                    DataGridViewRow selectedRow = DGV_ConexoesRemotas.SelectedRows[0];


                    string ids = selectedRow.Cells[0].Value.ToString();
                    int id = int.Parse(ids);
                    ASENTENT_CON resultado = conexoesDal.GetFor(c => c.CONNID_CON.Equals(id));
                    conexoesDal.DeleteDB(resultado);
                    MessageBox.Show("Dados Excluidos Com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int idCliente = int.Parse(TXB_ID.Text);
                    Preencher(idCliente);

                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (!(string.IsNullOrEmpty(TXB_Nome.Text)))
                {
                    AlterarDadosSelecionados();
                }
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                if (DGV_ConexoesRemotas.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = DGV_ConexoesRemotas.SelectedRows[0];
                    string value = row.Cells[3].Value.ToString();
                    MessageBox.Show("Dados de IP copiados com sucesso! ");
                    Clipboard.SetText(value);
                }
            }
        }

        private void TXB_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = int.Parse(TXB_ID.Text);
                Preencher(id);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TXB_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherBuscaPorNome(TXB_Nome.Text);
            }
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXB_ID.Text))
            {
                AlterarDadosSelecionados();
            }

        }

        private void TXB_Apelido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherBuscaPorApelido(TXB_Apelido.Text);
            }
        }
    }
}
