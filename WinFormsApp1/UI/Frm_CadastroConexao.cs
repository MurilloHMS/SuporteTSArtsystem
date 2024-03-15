using Microsoft.Identity.Client;
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
        public string idConexao { get; set; }
        public Frm_CadastroConexao(int id, string nomeCliente, bool status)
        {
            _Id = id;
            _Nome = nomeCliente;
            InitializeComponent();
            TXB_Cliente.Text = _Nome;
            if (status)
            {
                Preencher(_Id);
            }
        }


        private void Preencher(int id)
        {
            var context = new SuporteContext();
            var conexoesDal = new DAL<ASENTENT_CON>(context);
            ASENTENT_CON resultado = conexoesDal.GetFor(c => c.CONNID_CON.Equals(id));
            TXB_IDConexao.Text = resultado.CONNID_CON.ToString();
            TXB_Endereco.Text = resultado.CONCIPCON;
            TXB_Observacoes.Text = resultado.CONCDESC;
            TXB_SenhaArtsystem.Text = resultado.CONCSENART;
            TXB_SenhaConexaoRemota.Text = resultado.CONCSENTS;
            TXB_UsrArtsystem.Text = resultado.CONCUSRART;
            for (int i = 0; i < CB_Tipo.Items.Count; i++)
            {
                if (CB_Tipo.Items[i].ToString() == resultado.CONCTIP)
                {
                    CB_Tipo.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < CB_TipoConexao.Items.Count; i++)
            {
                if (CB_TipoConexao.Items[i].ToString() == resultado.CONCTIPCO)
                {
                    CB_TipoConexao.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < CB_UsrConexaoRemota.Items.Count; i++)
            {
                if (CB_UsrConexaoRemota.Items[i].ToString() == resultado.CONCUSRTS)
                {
                    CB_UsrConexaoRemota.SelectedIndex = i;
                    break;
                }
            }

            BTN_Alterar.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = TXB_IDConexao.Text;
            string cliente = TXB_Cliente.Text;
            string tipoConexao = CB_TipoConexao.SelectedItem.ToString();
            string enderecos = TXB_Endereco.Text;
            string tipo = CB_Tipo.SelectedItem.ToString();
            string usrConexao = CB_UsrConexaoRemota.SelectedItem.ToString();
            string senhaConexao = TXB_SenhaConexaoRemota.Text;
            string usuarioArtsystem = TXB_UsrArtsystem.Text;
            string senhaArtsystem = TXB_SenhaArtsystem.Text;
            string observacoes = TXB_Observacoes.Text;

            var context = new SuporteContext();
            var clienteDal = new DAL<ASENTENT>(context);
            var conexoesDal = new DAL<ASENTENT_CON>(context);
            var recuperaClientePorNome = clienteDal.GetFor(c => c.ENTCNOMENT.Equals(cliente));


            List<string> usuarios = new List<string>() { "ART", "ARTSYSTEM", "AS_BXALOGS", "AS_INSTALL" };

            if (usrConexao.Equals("TODOS"))
            {
                foreach (string i in usuarios)
                {
                    ASENTENT_CON conexoes = new ASENTENT_CON();
                    conexoes.CONCTIPCO = tipoConexao;
                    conexoes.CONCIPCON = enderecos;
                    conexoes.CONCTIP = tipo;
                    conexoes.CONCUSRTS = i;
                    conexoes.CONCSENTS = senhaConexao;
                    conexoes.CONCUSRART = usuarioArtsystem;
                    conexoes.CONCSENART = senhaArtsystem;
                    conexoes.CONCDESC = observacoes;
                    conexoes.CONNIDCLI = _Id;
                    ConexoesProfile profile = new ConexoesProfile();
                    profile.Executar(conexoesDal, conexoes);
                }
            }
            else
            {
                ASENTENT_CON conexoes = new ASENTENT_CON();
                conexoes.CONCTIPCO = tipoConexao;
                conexoes.CONCIPCON = enderecos;
                conexoes.CONCTIP = tipo;
                conexoes.CONCUSRTS = usrConexao;
                conexoes.CONCSENTS = senhaConexao;
                conexoes.CONCUSRART = usuarioArtsystem;
                conexoes.CONCSENART = senhaArtsystem;
                conexoes.CONCDESC = observacoes;
                conexoes.CONNIDCLI = _Id;
                ConexoesProfile profile = new ConexoesProfile();
                profile.Executar(conexoesDal, conexoes);
            }
        }

        private void Frm_CadastroConexao_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Alterar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TXB_IDConexao.Text);
            string cliente = TXB_Cliente.Text;

            var context = new SuporteContext();
            var clienteDal = new DAL<ASENTENT>(context);
            var conexoesDal = new DAL<ASENTENT_CON>(context);
            var recuperaClientePorNome = clienteDal.GetFor(c => c.ENTCNOMENT.Equals(cliente));
            var recuperaConexaoPorNome = conexoesDal.GetFor(c => c.CONNID_CON.Equals(id));

            if (recuperaConexaoPorNome != null) 
            {
                //recuperaConexaoPorNome.CONNID_CON = id;
                recuperaConexaoPorNome.CONCTIPCO = CB_TipoConexao.SelectedItem.ToString(); 
                recuperaConexaoPorNome.CONCIPCON = TXB_Endereco.Text;
                recuperaConexaoPorNome.CONCTIP = CB_Tipo.SelectedItem.ToString();
                recuperaConexaoPorNome.CONCUSRTS = CB_UsrConexaoRemota.SelectedItem.ToString();
                recuperaConexaoPorNome.CONCSENTS = TXB_SenhaConexaoRemota.Text;
                recuperaConexaoPorNome.CONCUSRART = TXB_UsrArtsystem.Text;
                recuperaConexaoPorNome.CONCSENART = TXB_SenhaArtsystem.Text;
                recuperaConexaoPorNome.CONCDESC = TXB_Observacoes.Text;
                //recuperaConexaoPorNome.CONNIDCLI = recuperaClientePorNome.ENTNID_ENT;
                conexoesDal.UpdateDB(recuperaConexaoPorNome);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Preencher(Convert.ToInt32(TXB_IDConexao));
        }
    }
}
