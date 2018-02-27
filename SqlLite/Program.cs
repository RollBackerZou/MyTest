using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SqlLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = D:\testDB\test.db;Password = 2017"))
           {
               using (SQLiteCommand cmd = new SQLiteCommand(conn) { CommandText = "select * from [main].[Info]"})
                {
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                   foreach(DataRow dr in dt.Rows)
                   {
                       foreach(DataColumn dc in dt.Columns)
                       {
                           Console.WriteLine(dr[dc]);
                       }
                   }
                }
           }

            Console.ReadKey();
        }
    }
}
