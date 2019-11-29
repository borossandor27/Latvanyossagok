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
        Varos KivalasztottVaros = null;
        Latvanyossag KivalasztottLatvanyossag = null;
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
            MySqlCommand sql = Program.conn.CreateCommand();
            try
            {
                //-- Ha nem lenne a városnév UNIQ, akkor ...
                //Program.conn.Open();
                //sql.CommandText = "SELECT COUNT(*) FROM varosok WHERE varosok.nev = '@varosnev' LIMIT 10 ";
                //sql.Parameters.AddWithValue("@varosnev", VarosNeve);
                //int db = Convert.ToInt32(sql.ExecuteScalar());
                //if ( db > 0)
                //{
                //    MessageBox.Show(VarosNeve + " nevű település már szerepel az adatbázisban!", "Nem megfelelő bemeneti adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //Program.conn.Close();
                //-- Beszúrás ----------------------------------------------------
                Program.conn.Open();
                sql.CommandText = "INSERT INTO `varosok` (`id`, `nev`, `lakossag`) VALUES (NULL, @varos, @lakossag);";
                sql.Parameters.AddWithValue("@varos", VarosNeve);
                sql.Parameters.AddWithValue("@lakossag", lakossag);
                if (sql.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("A város adatbázisba írása sikertelen!");
                }
                Program.conn.Close();
                textBox_Varosnev.Text = "";
                numeric_Lakossag.Value = numeric_Lakossag.Minimum;
                VaroslistaUpdate();
            } 
            catch(MySqlException myex)
            {
                if (myex.Number == 1062)
                {
                    //-- duplicate entry -----------------------------------------------
                    MessageBox.Show(VarosNeve + " nevű település már szerepel az adatbázisban!", "Nem megfelelő bemeneti adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(myex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Program.conn.State != null && Program.conn.State != ConnectionState.Closed)
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
                Program.conn.Open();
                MySqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    listBox_Varosok.Items.Add(new Varos(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_Varosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            KivalasztottVaros = (Varos)listBox_Varosok.SelectedItem;
            textBox_Varosnev.Text = KivalasztottVaros.Nev;
            numeric_Lakossag.Value = KivalasztottVaros.Lakossag;
            LatnivalolistaUpdate();
            groupBox_Latnivalok.Text = KivalasztottVaros.Nev + " látnivalói";
            label_Varos_nevezetesseg.Text = KivalasztottVaros.Nev + " nevezetessége";
        }

        private void LatnivalolistaUpdate()
        {
            listBox_Latvanyossagok.Items.Clear();
            MySqlCommand sql = Program.conn.CreateCommand();
            sql.CommandText = "SELECT `id`,`nev`,`leiras`,`ar`,`varos_id` FROM `latvanyossagok` WHERE `varos_id` = @id ;";
            sql.Parameters.AddWithValue("@id", KivalasztottVaros.Id);
            Program.conn.Open();
            using (MySqlDataReader reader = sql.ExecuteReader())
            {
                while (reader.Read())
                {
                    Latvanyossag uj = new Latvanyossag(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                    listBox_Latvanyossagok.Items.Add(uj);
                }
            }
            Program.conn.Close();
        }

        private void listBox_Latvanyossagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            KivalasztottLatvanyossag = (Latvanyossag)listBox_Latvanyossagok.SelectedItem;
            textBox_nevezetesseg.Text = KivalasztottLatvanyossag.Nev;
            textBox_Nevezetesseg_leiras.Text = KivalasztottLatvanyossag.Leiras;
        }

        private void button_Latvanyossag_Insert_Click(object sender, EventArgs e)
        {
            if (listBox_Varosok.SelectedIndex == -1)
            {
                MessageBox.Show("Kérem válassza ki a várost!");
                return;
            }
            MySqlCommand sql = Program.conn.CreateCommand();
            sql.CommandText = "INSERT INTO `latvanyossagok` (`id`, `nev`, `leiras`, `ar`, `varos_id`) VALUES (NULL, '@nev', '@leiras', '@ar', '@varosid');";
            sql.Parameters.AddWithValue("@nev", textBox_nevezetesseg.Text.Trim());
            sql.Parameters.AddWithValue("@leiras", textBox_Nevezetesseg_leiras.Text.Trim());
            sql.Parameters.AddWithValue("@ar", Convert.ToInt32(numeric_Latvanyossag_ar.Value));
            sql.Parameters.AddWithValue("@varosid", KivalasztottVaros.Id);
            try
            {
                Program.conn.Open();
                sql.ExecuteNonQuery();
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
