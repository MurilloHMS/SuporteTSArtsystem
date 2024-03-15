using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Databases;
using WinFormsApp1.Models;
using WinFormsApp1.Models.Profiles;

namespace WinFormsApp1.UI.UserControls
{
    public partial class Frm_CadastroClientes : UserControl
    {

        public Frm_CadastroClientes()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Finder finder = new Finder();
            finder.ShowDialog();

            var context = new SuporteContext();
            var clienteDal = new DAL<ASENTENT>(context);
            var conexoesDal = new DAL<ASENTENT_CON>(context);
            var id = finder.idSelect;
            var recuperaClientePorNome = clienteDal.GetFor(c => c.ENTNID_ENT.Equals(id));

            if (finder.DialogResult == DialogResult.OK)
            {
                var idCliente = recuperaClientePorNome.ENTNID_ENT;
                TXB_ID.Text = Convert.ToString(idCliente);
                TXB_Nome.Text = recuperaClientePorNome.ENTCNOMENT;
                TXB_Apelido.Text = recuperaClientePorNome.ENTCAPELID;
                MTXB_Cnpj.Text = recuperaClientePorNome.ENTCCODCPF;

                var resultado = conexoesDal.listFor(r => r.CONNIDCLI.Equals(idCliente));
                DGV_ConexoesRemotas.DataSource = resultado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASENTENT cliente = new ASENTENT();
            cliente.ENTCNOMENT = TXB_Nome.Text;
            cliente.ENTCAPELID = TXB_Apelido.Text;
            cliente.ENTCCODCPF = MTXB_Cnpj.Text;

            var context = new SuporteContext();
            var clienteDal = new DAL<ASENTENT>(context);

            ClienteProfile profile = new ClienteProfile();
            profile.Executar(clienteDal, cliente);

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TXB_ID.Text))
            {
                int idCliente = Convert.ToInt32(TXB_ID.Text);
                var nomeCliente = TXB_Nome.Text;
                Frm_CadastroConexao frm = new Frm_CadastroConexao(idCliente, nomeCliente, false);
                frm.ShowDialog();
            }

        }

        private void DGV_ConexoesRemotas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

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
                        process.StartInfo.FileName = anydesk;
                        process.StartInfo.Arguments = $"{value}";
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

        private void DGV_ConexoesRemotas_KeyPress(object sender, KeyPressEventArgs e)
        {

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

                }
            }

            if (e.KeyCode == Keys.Enter) 
            {
                DialogResult msg = MessageBox.Show("Deseja alterar a Conexão selecionada? ", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    var context = new SuporteContext();
                    var conexoesDal = new DAL<ASENTENT_CON>(context);

                    DataGridViewRow selectedRow = DGV_ConexoesRemotas.SelectedRows[0];


                    string ids = selectedRow.Cells[0].Value.ToString();
                    var nomeCliente = TXB_Nome.Text;
                    int id = int.Parse(ids);
                    Frm_CadastroConexao frm = new Frm_CadastroConexao(id, nomeCliente, true);
                    frm.ShowDialog();

                }
            }
        }
    }
}
