//using Microsoft.Data.Sqlite;
using Microsoft.Data.Sqlite;
using System;
//using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
//using System.Data.SQLite;
//using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SQLite;


namespace SistemaEstacionamento.Db
{
    internal static class CreateDB
    {
        static  readonly string path = "../../../Db/Banco.sqlite";
        private static SQLiteConnection sqliteConnection;
        public static void MonstarBanco()
        {
            CriarTabelas();
            if (!File.Exists(path))
            {
                CriarBancoSQLite();
                CriarTabelas();
            }
        }
        public static void CriarBancoSQLite()
        {
            System.Data.SQLite.SQLiteConnection.CreateFile("../../../Db/Banco.sqlite"); 
        }
        public static void CriarTabelas()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE [Car] ([Id] INT NOT NULL AUTOINCREMENT, [Modelo] NVARCHAR(60) NOT NULL," +
    "[Color] VARCHAR(50) NOT NULL,[LicensePlate] VARCHAR(255) NOT NULL,CONSTRAINT[PK_Car] PRIMARY KEY([Id])";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection($"Data Source={path}; Version=3");
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }
}
