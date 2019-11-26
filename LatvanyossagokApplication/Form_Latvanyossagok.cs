using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    
    public partial class Form_Latvanyossagok : Form
    {
        public Form_Latvanyossagok()
        {
            InitializeComponent();
        }

        private void button_Varos_Insert_Click(object sender, EventArgs e)
        {
            //-- adatellenőrzés ---------------------------------------------
            string VarosNeve = textBox_Varosnev.Text.Trim();
            if (VarosNeve.Length < 1)
            {
                MessageBox.Show("Kérem adjon meg városnevet!", "Hiányos adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int lakossag = Convert.ToInt32(numeric_Lakossag.Value);
            if (lakossag < 1)
            {
                MessageBox.Show("Kérem adja meg a lakosok számát!", "Hiányos adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Program.conn.Open();
                MySqlCommand sql = Program.conn.CreateCommand();
                sql.CommandText = "SELECT COUNT(*) FROM varosok WHERE varosok.nev = '@varosnev' LIMIT 10 ";
                sql.Parameters.AddWithValue("@varosnev", VarosNeve);
                if (sql.ExecuteScalar() != DBNull.Value)
                {
                    MessageBox.Show(VarosNeve + " már szerepel az adatbázisban!", "Hiányos adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //-- Beszúrás ----------------------------------------------------
                sql.CommandText = "INSERT INTO `varosok` (`id`, `nev`, `lakossag`) VALUES (NULL, '@varos', '@lakossag');";
                sql.Parameters.AddWithValue("@varos", VarosNeve);
                sql.Parameters.AddWithValue("@lakossag", lakossag);
                if (sql.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("A város adatbázisba írása sikertelen!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Program.conn.State == ConnectionState.Open)
                {
                    Program.conn.Close();
                }
            }

        }

        private void Form_Latvanyossagok_Load(object sender, EventArgs e)
        {
            VaroslistaUpdate();
        }

        void VaroslistaUpdate()
        {
            listBox_Varosok.Items.Clear();
            try
            {
                MySqlCommand sql = Program.conn.CreateCommand();
                sql.CommandText = "SELECT `id`, `nev`, `lakossag` FROM `varosok` ORDER BY `nev`;";
                MySqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string varos = reader.GetString(1);
                    int lakossag = reader.GetInt32(2);
                    listBox_Varosok.Items.Add(new Varos(id, varos, lakossag));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
