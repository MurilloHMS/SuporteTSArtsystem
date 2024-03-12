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

            if (finder.DialogResult == DialogResult.OK)
            {
                var id = finder.idSelect;
                MessageBox.Show($"Id Selecionado: {id}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.CLICRZS = TXB_Nome.Text;
            cliente.CLICAPE = TXB_Apelido.Text;
            cliente.CLICCNPJ = MTXB_Cnpj.Text;
            cliente.CLICDES = TXB_Observacao.Text;

            var context = new SuporteContext();
            var clienteDal = new DAL<Cliente>(context);

            ClienteProfile profile = new ClienteProfile();
            profile.Executar(clienteDal, cliente);

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_CadastroConexao frm = new Frm_CadastroConexao();
            frm.ShowDialog();
        }
    }
}
