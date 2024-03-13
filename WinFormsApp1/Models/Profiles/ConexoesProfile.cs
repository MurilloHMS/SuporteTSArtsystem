using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Databases;

namespace WinFormsApp1.Models.Profiles
{
    internal class ConexoesProfile
    {
        public void Executar(DAL<Conexoes> conexoesDAL, Conexoes conexoes)
        {
            conexoesDAL.AddToDB(conexoes);
        }
        public void Deletar(DAL<Conexoes> conexoesDAL, Conexoes conexoes)
        {
            conexoesDAL.DeleteDB(conexoes);
        }
    }
}
