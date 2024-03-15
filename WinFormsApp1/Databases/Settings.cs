using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1.Databases
{
    internal class Settings
    {
        private string _databaseName;
        private string _Anydesk; 

        public string DatabaseName { 
            get { return RetornaDatabaseName();}
            set { _databaseName = value; UpdateConnectionStrings("SuporteContexto", _databaseName); }
        }

        public string ConnectionString
        {
            get { return ObterConnectionString("SuporteContexto"); }
        }

        public string Anydesk
        {
            get { return GetConfigValue("Anydesk"); }
            set
            {
                _Anydesk = value;
                UpdateConfig("Anydesk", value);
            }
        }
        private string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        
        private void UpdateConfig(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }


        static string RetornaDatabaseName()
        {
            string connectionString = ObterConnectionString("SuporteContexto");
            var builder = new SqlConnectionStringBuilder(connectionString);
            string serverAdress = builder.DataSource;
            return serverAdress;
        }
        static string ObterConnectionString(string name)
        {
            
            if (ConfigurationManager.ConnectionStrings[name] != null)
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
            else
            {
                
                throw new Exception("A connection string especificada não foi encontrada.");
            }
        }
        static void UpdateConnectionStrings(string nomeConnectionString, string dataSource)
        {

            string connectionString = ObterConnectionString("SuporteContexto");
            var builder = new SqlConnectionStringBuilder(connectionString);
            builder.DataSource = dataSource;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            
            ConnectionStringSettings connectionStringSettings = config.ConnectionStrings.ConnectionStrings[nomeConnectionString];

            if (connectionStringSettings != null)
            {
                connectionStringSettings.ConnectionString = builder.ConnectionString;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            else
            {
                throw new InvalidOperationException("A connection string especificada não foi encontrada.");
            }
        }

    }
}
