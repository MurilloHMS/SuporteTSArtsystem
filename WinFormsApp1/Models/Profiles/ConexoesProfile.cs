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
        public void Executar(DAL<ASENTENT_CON> conexoesDAL, ASENTENT_CON conexoes)
        {
            conexoesDAL.AddToDB(conexoes);
        }
        public void Deletar(DAL<ASENTENT_CON> conexoesDAL, ASENTENT_CON conexoes)
        {
            conexoesDAL.DeleteDB(conexoes);
        }
        public void Atualizar(DAL<ASENTENT_CON> conexoesDAL, ASENTENT_CON conexoes)
        {
            conexoesDAL.UpdateDB(conexoes);
        }

    }
}
