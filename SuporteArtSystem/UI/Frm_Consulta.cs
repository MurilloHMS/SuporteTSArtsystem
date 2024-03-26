using System.Data;
using SuporteArtSystem.Models;

namespace SuporteArtSystem.UI
{
    public partial class Frm_Consulta : Form
    {
        List<ItemBox> _ListaBusca = new List<ItemBox>();
        public int idSelect { get; set; }

        ASENTENT clientes = new ASENTENT();
        public Frm_Consulta()
        {
            InitializeComponent();
            PreencherLista();
            LB_Finder.Sorted = true;
            TXT_Filtro.TextChanged += TXT_Filtro_TextChanged;

        }

        private void PreencherLista()
        {
            
            LB_Finder.Items.Clear();
            _ListaBusca.Clear();

            var retornoTodosOsClientes = clientes.RetornaClientes();
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
