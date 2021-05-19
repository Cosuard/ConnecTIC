    using System;
    using System.Configuration;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace Registro
{
    public class SqliteDataAccess
    {
        public static List<QRModel> LoadQRs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QRModel>("select * from qrs_save", new DynamicParameters());
                return output.ToList();
            }
        }
        
        public static void SaveQR(QRModel qr)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into qrs_save (qr) values (@Qr)", qr);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
