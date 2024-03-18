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
        List<ItemBox> _ListaBusca = new List<ItemBox>();
        public int idSelect { get; set; }
        public Finder()
        {
            InitializeComponent();
            PreencherLista();
            LB_Finder.Sorted = true;
            TXT_Filtro.TextChanged += TXT_Filtro_TextChanged;

        }

        private void PreencherLista()
        {
            var context = new SuporteContext();
            var clienteDal = new DAL<ASENTENT>(context);

            LB_Finder.Items.Clear();
            _ListaBusca.Clear();

            var retornoTodosOsClientes = clienteDal.GetAll().Where(c => c.ENTCTIPPES.ToString() == "J");
            foreach (var cliente in retornoTodosOsClientes)
            {
                ItemBox x = new ItemBox();
                x.Id = cliente.ENTNID_ENT;
                x.Nome = $"{cliente.ENTCNOMENT} => {cliente.ENTCAPELID}";
                _ListaBusca.Add(x);
                LB_Finder.Items.Add(x);
            }
        }
        private void TXT_Filtro_TextChanged(object sender, EventArgs e)
        {
            string filtro = TXT_Filtro.Text.ToLower();
            List<ItemBox> itensFiltrados = _ListaBusca.Where(x => x.Nome.ToLower().Contains(filtro)).ToList();

            LB_Finder.Items.Clear();
            foreach (var item in itensFiltrados)
            {
                LB_Finder.Items.Add(item);
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
