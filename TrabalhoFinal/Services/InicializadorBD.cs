using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMax.Services
{
    public static class InicializadorBD
    {
        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=TsukiLoja.db");
                string commandoSQL = @"
                 CREATE TABLE IF NOT EXISTS Mangass (
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 NumeroCapitulo DECIMAL NOT NULL,
                 AnoLancamento INT NOT NULL,
                 Autor TEXT NOT NULL
                );";
            connection.Execute(commandoSQL);
        }
    }
}
