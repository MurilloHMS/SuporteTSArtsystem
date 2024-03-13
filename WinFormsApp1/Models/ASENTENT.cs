using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Databases;

namespace WinFormsApp1.Models
{
    public class ASENTENT
    {
        [Key]
        [NotNull]
        public int ENTNID_ENT { get; set; } //ID Cliente
        [NotNull]
        public char ENTCTIPPES { get; set; } // Tipo Pessoa Juridica ou Fisica
        [NotNull]
        public string ENTCCODCPF { get; set; } //cpf/cnpj
        public string? ENTCCOD_RG {  get; set; } //rg ou inscrição estadual
        [NotNull]
        public string ENTCNOMENT { get; set; } //nome da entidade/ razao social
        public string? ENTCAPELID { get; set; } //apelido
        [Key]
        [NotNull]
        public int ENTNID_CEP { get; set; } //Cep
        [NotNull]
        public int ENTNENDNUM { get; set; } //Número endereço
        public string? ENTCENDCOM { get; set; } // complemento
        public string? ENTCE_MAIL { get; set; } //e-mail do cliente
        public string? ENTCUSUCAD { get; set; } //usuário cadastro
        public DateTime? ENTDDATCAD { get; set; } //data de cadastro
        public string? ENTCUSUALT { get; set; } //usuario alteração
        public DateTime? ENTDDATALT { get; set; } //data de alteração
        /*public virtual ICollection<Conexoes> Conexao { get; set; } = new List<Conexoes>();
        
        public void AdicionarConexao(Conexoes conexao)
        {
            Conexao.Add(conexao);
        }*/
    }

}
