using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class ASENTENT_CON
    {
        [Key]
        public int CONNID_CON { get; set; }
        public string CONCTIPCO { get; set; }
        public string CONCDESC { get; set; }
        public string CONCIPCON { get; set; }
        public string CONCTIP { get; set; }
        public string CONCUSRTS { get; set; }
        public string CONCSENTS { get; set; }
        public string CONCUSRART { get; set; }
        public string CONCSENART { get; set; }
        public int CONNIDCLI { get; set; }
    }

}
