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
    }

}
