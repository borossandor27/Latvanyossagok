using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    class DatabaseTool
    {
        string host;
        string user;
        string pass;
        string database = "latvanyossagokdb";
        int port = 3306;
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        
        readonly string CreateVarosok = "CREATE TABLE IF NOT EXISTS `varosok` (" +
            "`id` int(11) NOT NULL AUTO_INCREMENT,  " +
            "`nev` varchar(100) NOT NULL,  " +
            "`lakossag` int(11) NOT NULL,  " +
            "`cimer` mediumblob," +
            "PRIMARY KEY(`id`),  " +
            "UNIQUE KEY `nev` (`nev`)) ENGINE = InnoDB DEFAULT CHARSET = utf8; ";
        
        readonly string CreateLatvanyossagok = "CREATE TABLE IF NOT EXISTS `latvanyossagok` ( " +
                    "`id` int(11) NOT NULL AUTO_INCREMENT, " +
                    "`nev` varchar(100) NOT NULL, " +
                    "`leiras` varchar(1000) NOT NULL, " +
                    "`ar` int(11) NOT NULL DEFAULT '0', " +
                    "`varos_id` int(11) NOT NULL, " +
                    "`kep` mediumblob," +
                    "PRIMARY KEY(`id`),  " +
                    "UNIQUE KEY `unique_index` (`id`,`nev`) " +
                    ") ENGINE=InnoDB DEFAULT CHARSET=utf8";
        //MySqlTransaction transaction = null;
        MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();

        public DatabaseTool(MySqlConnectionStringBuilder sb) : this(sb.Server, sb.UserID, sb.Password, sb.Database , (int) sb.Port)
        {
            this.sb = sb;
        }

        public DatabaseTool(string host, string user, string pass, string database = "latvanyossagokdb", int port = 3306)
        {
            this.host = host;
            this.user = user;
            this.pass = pass;
            this.database = database;
            this.port = port;
            sb.Server = host;
            sb.UserID = user;
            sb.Password = pass;
            sb.Database = database;
            sb.Port = Convert.ToUInt32(port);
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            sql = conn.CreateCommand();
            Kapcsolatot_Nyit();
            sql.CommandText = CreateVarosok;
            sql.ExecuteNonQuery();
            sql.CommandText = CreateLatvanyossagok;
            sql.ExecuteNonQuery();
        }

        void Kapcsolatot_Nyit()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Az adatbázis szerver nem elérhető!");
                        Environment.Exit(0);
                        break;
                    case 0:
                        if (ex.InnerException != null)
                        {
                            MySqlException kezelheto = (MySqlException)ex.InnerException;
                            switch (kezelheto.Number)
                            {
                                case 1049:
                                    //-- Nincs ilyen adatbázis! ----------------------------
                                    sb.Remove("Database");
                                    conn = new MySqlConnection(sb.ToString());
                                    conn.Open();
                                    sql = conn.CreateCommand();
                                    sql.CommandText = $"CREATE DATABASE IF NOT EXISTS `{database}` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";
                                    sql.ExecuteNonQuery();
                                    sql.CommandText = $"USE `{database}`;";
                                    sql.ExecuteNonQuery();
                                    sql.CommandText = CreateVarosok;
                                    sql.ExecuteNonQuery();
                                    sql.CommandText = CreateLatvanyossagok;
                                    sql.ExecuteNonQuery();
                                    sb.Database = database;
                                    conn = new MySqlConnection(sb.ToString());
                                    conn.Open();
                                    break;
                                case 1044:
                                    //--- Access denied -------------------------------------
                                    MessageBox.Show("Nincs jogosultsága az adatbázis használatára!");
                                    Environment.Exit(0);
                                    break;
                                case 1045:
                                    //--- Access denied -------------------------------------
                                    MessageBox.Show("Érvénytelen jelszó!");
                                    Environment.Exit(0);
                                    break;
                                default:
                                    MessageBox.Show(ex.Message);
                                    break;
                            }
                        }
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        void Kapcsolatot_Zar()
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public bool Update(string sql)
        {
            return true;
        }
        public bool Delete(string sql)
        {
            return true;
        }
        public bool Insert(string sql)
        {
            return true;
        }
    }
}
