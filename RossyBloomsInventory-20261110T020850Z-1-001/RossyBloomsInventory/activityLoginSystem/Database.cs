using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;


namespace activityLoginSystem
{
    public static class Database
    {
        public static readonly String DBpath =
            Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\sampledb.accdb"
                )
            );
        private static readonly String connectionString = @"provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBpath + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
