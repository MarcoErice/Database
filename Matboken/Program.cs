using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matboken
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection cn = new SQLiteConnection(@"Data Source=C:\Users\marco\Downloads\sqlitestudio-3.1.1\SQLiteStudio\Matboken");
            cn.Open();
            var cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT name FROM Ingredienser";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
            cn.Close();
        }
    }
}
