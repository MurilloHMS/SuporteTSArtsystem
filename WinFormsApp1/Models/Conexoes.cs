using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Conexoes
    {
        [Key]
        public int CONNID_CON { get; set; }
        public string CONCTIP { get; set; }
        public string CONCDES { get; set; }
        public string CONCIPCON { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }

}
