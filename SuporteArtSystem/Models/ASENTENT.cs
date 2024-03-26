using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using SuporteArtSystem.Databases;

namespace SuporteArtSystem.Models
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

        private SuporteContext context = new SuporteContext();


        public IEnumerable<ASENTENT> RetornaClientes()
        {
            var clienteDal = new DAL<ASENTENT>(context);

            return clienteDal.GetAll().Where(c => c.ENTCTIPPES.ToString() == "J");

        }
        public ASENTENT RetornaClientePorNome(string cliente)
        {
            var clienteDAL = new DAL<ASENTENT>(context);

            return clienteDAL.GetFor(c => c.ENTCNOMENT.Equals(cliente));
        }

        public ASENTENT RetornaClientePorId(int id)
        {
            var clienteDAL = new DAL<ASENTENT>(context);
            return clienteDAL.GetFor(c => c.ENTNID_ENT.Equals(id));
        }

    }

}
