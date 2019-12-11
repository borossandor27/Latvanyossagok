using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    
    public partial class Form_Latvanyossagok : Form
    {
        MySqlCommand sql = Program.conn.CreateCommand();
        Latvanyossag KivalasztottLatvanyossag = null;

        public Form_Latvanyossagok()
        {
            InitializeComponent();
        }


        private void Form_Latvanyossagok_Load(object sender, EventArgs e)
        {
            LatnivaloUpdate();
        }

        private void LatnivaloUpdate()
        {
            //--  AutoSize property to False, TextAlign property to MiddleCenter and Dock property to Fill
            label_Varosnev.Text = Program.KivalasztottVaros.Nev;
            label_Varosnev.Top = (panel_Varosnev.Height - label_Varosnev.Height) / 2;
            label_Varosnev.Left = (panel_Varosnev.Width - label_Varosnev.Width) / 2;
            listBox_Latvanyossagok.Items.Clear();
            textBox_nevezetesseg.Text = "";
            textBox_Nevezetesseg_leiras.Text = "";
            sql.CommandText = "SELECT `id`,`nev`,`leiras`,`ar`,`varos_id` FROM `latvanyossagok` WHERE `varos_id` = @id ;";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@id", Program.KivalasztottVaros.Id);
            Program.conn.Open();
            using (MySqlDataReader reader = sql.ExecuteReader())
            {
                while (reader.Read())
                {
                    listBox_Latvanyossagok.Items.Add(new Latvanyossag(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4)));
                }
            }
            Program.conn.Close();
            Gombok();
        }

        private void Gombok()
        {
            if (listBox_Latvanyossagok.SelectedIndex >= 0)
            {
                button_Latvanyossag_Delete.Enabled = true;
                button_Latvanyossag_Update.Enabled = true;
                button_Latvanyossag_Insert.Enabled = true;
            }
            else
            {
                button_Latvanyossag_Delete.Enabled = false;
                button_Latvanyossag_Update.Enabled = false;
                button_Latvanyossag_Insert.Enabled = false;
            }
        }
        private void listBox_Latvanyossagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Latvanyossagok.SelectedIndex >= 0)
            {
                KivalasztottLatvanyossag = (Latvanyossag)listBox_Latvanyossagok.SelectedItem;
                textBox_nevezetesseg.Text = KivalasztottLatvanyossag.Nev;
                textBox_Nevezetesseg_leiras.Text = KivalasztottLatvanyossag.Leiras;
            }
            else
            {
                KivalasztottLatvanyossag = null;
                textBox_nevezetesseg.Text = "";
                textBox_Nevezetesseg_leiras.Text = "";
            }
            Gombok();
        }

        private void button_Latvanyossag_Insert_Click(object sender, EventArgs e)
        {
            if (textBox_nevezetesseg.Text.Trim().Length<3)
            {
                MessageBox.Show("Kérem töltse ki a nevezetesség mezőt!");
                textBox_nevezetesseg.Focus();
                textBox_nevezetesseg.Select(textBox_nevezetesseg.Text.Length, 0);
                return;
            }
            if (textBox_Nevezetesseg_leiras.Text.Trim().Length<3)
            {
                MessageBox.Show("Kérem adja meg a nevezetesség leírását is!");
                textBox_Nevezetesseg_leiras.Focus();
                textBox_Nevezetesseg_leiras.Select(textBox_Nevezetesseg_leiras.Text.Length, 0);
                return;
            }
            sql.CommandText = "INSERT INTO `latvanyossagok` (`id`, `nev`, `leiras`, `ar`, `varos_id`) VALUES (NULL, @nev, @leiras, @ar, @varosid);";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@nev", textBox_nevezetesseg.Text.Trim());
            sql.Parameters.AddWithValue("@leiras", textBox_Nevezetesseg_leiras.Text.Trim());
            sql.Parameters.AddWithValue("@ar", Convert.ToInt32(numeric_Latvanyossag_ar.Value));
            sql.Parameters.AddWithValue("@varosid", Program.KivalasztottVaros.Id);
            try
            {
                Program.conn.Open();
                sql.ExecuteNonQuery();
                Program.conn.Close();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
            }
            LatnivaloUpdate();
        }

        private void button_tesztadatok_Click(object sender, EventArgs e)
        {
            try
            {
                string file = @"..\..\..\latvanyossagokdb(8).sql";
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    Program.conn.Open();
                    MySqlScript script = new MySqlScript(Program.conn, sr.ReadToEnd());
                    script.Execute();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch  (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
            }
            finally
            {
                Program.conn.Close();
            }
            //VaroslistaUpdate();
        }

        private void button_Varosok_form_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_varosok.Show();
        }

        private void Form_Latvanyossagok_Activated(object sender, EventArgs e)
        {
            LatnivaloUpdate();
        }

        private void Form_Latvanyossagok_FormClosed(object sender, FormClosedEventArgs e)
        {
            button_Varosok_form_view_Click(sender, new EventArgs());
        }

        private void button_Varosok_form_view_MouseEnter(object sender, EventArgs e)
        {
            button_Varosok_form_view.BackColor = Color.LightPink;
            button_Varosok_form_view.FlatStyle = FlatStyle.Flat;
            button_Varosok_form_view.FlatAppearance.BorderColor = Color.Red;
            button_Varosok_form_view.FlatAppearance.BorderSize = 1;
        }

        private void button_Varosok_form_view_MouseLeave(object sender, EventArgs e)
        {
            //button_Varosok_form_view.BackColor = default(Color);
            button_Varosok_form_view.BackColor = Color.LightGreen;
            button_Varosok_form_view.FlatStyle = FlatStyle.Flat;
            button_Varosok_form_view.FlatAppearance.BorderColor = Color.Green;
            button_Varosok_form_view.FlatAppearance.BorderSize = 1;
            button_Varosok_form_view.Image = LatvanyossagokApplication.Properties.Resources.back_icon;
            button_Varosok_form_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

        }

        private void button_Latvanyossag_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Latvanyossagok.SelectedIndex == -1)
            {
                return;
            }
        }
    }
}
