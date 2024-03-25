using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Databases;
using WinFormsApp1.Models.Profiles;

namespace WinFormsApp1.Models
{
    public class ASENTENT_CON
    {
        [Key]
        public int CONNID_CON { get; set; }
        [StringLength(100)]
        public string CONCTIPCO { get; set; }
        [StringLength(100)]
        public string CONCDESC { get; set; }
        [StringLength(1000)]
        public string CONCIPCON { get; set; }
        [StringLength(100)]
        public string CONCTIP { get; set; }
        [StringLength(100)]
        public string CONCUSRTS { get; set; }
        [StringLength(100)]
        public string CONCSENTS { get; set; }
        [StringLength(100)]
        public string CONCUSRART { get; set; }
        [StringLength(100)]
        public string CONCSENART { get; set; }
        public int CONNIDCLI { get; set; }

        private SuporteContext context = new SuporteContext();
        public ASENTENT_CON RetornaConexaoPorID(int id) 
        {
            var conexoesDal = new DAL<ASENTENT_CON>(context);
            return conexoesDal.GetFor(c => c.CONNID_CON.Equals(id));
        }

        public void Incluir()
        {
            DAL<ASENTENT_CON> conexoes = new DAL<ASENTENT_CON>(context);
            conexoes.AddToDB(this);
        }

        public void Atualizar()
        {
            DAL<ASENTENT_CON> conexoes = new DAL<ASENTENT_CON>(context);
            conexoes.UpdateDB(this);
        }
    }

}
