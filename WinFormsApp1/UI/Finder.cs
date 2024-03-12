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

namespace WinFormsApp1.UI
{
    public partial class Finder : Form
    {
        List<string> _ListaBusca = new List<string>();
        public int idSelect { get; set; }
        public Finder()
        {

            InitializeComponent();
            PreencherLista();
            LB_Finder.Sorted = true;
        }

        private void PreencherLista()
        {
            var context = new SuporteContext();
            var clienteDal = new DAL<Cliente>(context);

            ItemBox x = new ItemBox();
            LB_Finder.Items.Clear();
            foreach (var cliente in clienteDal.GetAll())
            {
                x.Id = cliente.CLINID_CLI;
                x.Nome = cliente.CLICRZS;
                LB_Finder.Items.Add(x);
            }
        }

        private class ItemBox
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        private void LB_Finder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LB_Finder_DoubleClick(object sender, EventArgs e)
        {
            ItemBox itemSelecionado = (ItemBox)LB_Finder.Items[LB_Finder.SelectedIndex];
            DialogResult = DialogResult.OK;
            idSelect = itemSelecionado.Id;
            this.Close();
        }
    }
}
