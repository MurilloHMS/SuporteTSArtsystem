using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Databases;

namespace WinFormsApp1.Models.Profiles
{
    internal class ClienteProfile
    {
        public void Executar (DAL<Cliente> clienteDAL, Cliente cliente)
        {
            clienteDAL.AddToDB(cliente);
        }
    }
}
