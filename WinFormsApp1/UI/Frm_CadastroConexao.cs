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

namespace WinFormsApp1.UI
{
    public partial class Frm_CadastroConexao : Form
    {
        private int _Id { get; set; }
        private string _Nome { get; set; }
        public Frm_CadastroConexao(int id, string nomeCliente)
        {
            _Id = id;
            _Nome = nomeCliente;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //var id = TXB_IDConexao.Text;
            string cliente = TXB_Cliente.Text;
            string tipoConexao = CB_TipoConexao.SelectedText;
            string enderecos = TXB_Endereco.Text;
            string tipo = CB_Tipo.SelectedText;
            string usrConexao = CB_UsrConexaoRemota.SelectedText;
            string senhaConexao = TXB_SenhaConexaoRemota.Text;
            string usuarioArtsystem = TXB_UsrArtsystem.Text;
            string senhaArtsystem = TXB_SenhaArtsystem.Text;
            string observacoes = TXB_Observacoes.Text;

            var context = new SuporteContext();
            var clienteDal = new DAL<Cliente>(context);
            var conexoesDal = new DAL<Conexoes>(context);
            var recuperaClientePorNome = clienteDal.GetFor(c => c.CLICRZS.Equals(cliente));


            Conexoes conexoes = new Conexoes();
            conexoes.CONCTIPCO = tipoConexao;
            conexoes.CONCIPCON = enderecos;
            conexoes.CONCTIP = tipo;
            conexoes.CONCUSRTS = usrConexao;
            conexoes.CONCSENTS = senhaConexao;
            conexoes.CONCUSRART = usuarioArtsystem;
            conexoes.CONCSENART = senhaArtsystem;
            conexoes.CONCDESC = observacoes;
            conexoes.Cliente = recuperaClientePorNome;

            ConexoesProfile profile = new ConexoesProfile();
            profile.Executar(conexoesDal, conexoes);

        }

        private void Frm_CadastroConexao_Load(object sender, EventArgs e)
        {
            TXB_Cliente.Text = _Nome;
        }
    }
}
