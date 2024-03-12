using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Databases;

namespace WinFormsApp1.Models
{
    public class Cliente
    {
        [Key]
        public int CLINID_CLI { get; set; }
        public string CLICRZS { get; set; }
        public string CLICAPE { get; set; }
        public string CLICCNPJ { get; set; }
        public string CLICDES { get; set; }
        public virtual ICollection<Conexoes> Conexao { get; set; } = new List<Conexoes>();
        
        public void AdicionarConexao(Conexoes conexao)
        {
            Conexao.Add(conexao);
        }
    }

}
