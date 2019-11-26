using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    static class Program
    {
        public static MySqlConnection conn = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "latvanyossagokdb";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                string CreateVarosok = "CREATE TABLE IF NOT EXISTS `varosok` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT,  " +
                    "`nev` varchar(100) NOT NULL,  " +
                    "`lakossag` int(11) NOT NULL,  " +
                    "PRIMARY KEY(`id`),  " +
                    "UNIQUE KEY `nev` (`nev`)) ENGINE = InnoDB DEFAULT CHARSET = utf8; ";
                string CreateLatvanyossagok = "CREATE TABLE IF NOT EXISTS `latvanyossagok` ( " +
                    "`id` int(11) NOT NULL AUTO_INCREMENT, " +
                    "`nev` varchar(100) NOT NULL, " +
                    "`leiras` varchar(255) NOT NULL, " +
                    "`ar` int(11) NOT NULL DEFAULT '0', " +
                    "`varos_id` int(11) NOT NULL, " +
                    "PRIMARY KEY (`id`), " +
                    "FOREIGN KEY (`varos_id`) REFERENCES `varosok` (`id`) " +
                    ") ENGINE=InnoDB DEFAULT CHARSET=utf8";
                MySqlCommand sql = conn.CreateCommand();
                sql.CommandText = CreateVarosok;
                sql.ExecuteNonQuery();
                sql.CommandText = CreateLatvanyossagok;
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Latvanyossagok());
            conn.Close();
        }
    }
}
