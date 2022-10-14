﻿using System.Data.SqlClient;

namespace PRUEBA_TECNICA_4.Data
{
    public class Conection
    {
        private string cadenaSQL = string.Empty;

        public Conection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        public string getCadenaSQL()
        {
            return cadenaSQL;
        }
    }
}
