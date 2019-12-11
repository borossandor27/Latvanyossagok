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
using System.IO;

namespace LatvanyossagokApplication
{
    public partial class Form_varosok : Form
    {
        byte[] cimer = null;
        MySqlCommand sql = Program.conn.CreateCommand();

        public Form_varosok()
        {
            InitializeComponent();
        }

        private void Form_varosok_Load(object sender, EventArgs e)
        {
            VaroslistaUpdate();
        }
        void VaroslistaUpdate()
        {
            textBox_Varosnev.Text = "";
            numeric_Lakossag.Value = numeric_Lakossag.Minimum;
            button_Varos_Insert.Enabled = false;
            button_Varos_Update.Enabled = false;
            button_Varos_Delete.Enabled = false;
            listBox_Varosok.Items.Clear();
            try
            {
                sql.CommandText = "SELECT `id`, `nev`, `lakossag`, `cimer`  FROM `varosok` ORDER BY `nev`;";
                Program.conn.Open();
                MySqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    if (DBNull.Value == reader["cimer"])
                    {
                        listBox_Varosok.Items.Add(new Varos(reader.GetInt32("id"), reader.GetString("nev"), reader.GetInt32("lakossag")));
                    }
                    else
                    {
                        listBox_Varosok.Items.Add(new Varos(reader.GetInt32("id"), reader.GetString("nev"), reader.GetInt32("lakossag"), (byte[])reader["cimer"]));
                    }
                }
                reader.Close();
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VarosadatokKitoltve()
        {
            if (textBox_Varosnev.Text.Trim().Length > 1 && numeric_Lakossag.Value > 0)
            {
                button_Varos_Insert.Enabled = true;
                button_Varos_Update.Enabled = true;
            }
            else
            {
                button_Varos_Insert.Enabled = false;
                button_Varos_Update.Enabled = false;
            }
        }
        private void listBox_Varosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Varosok.SelectedIndex >= 0)
            {
                Program.KivalasztottVaros = (Varos)listBox_Varosok.SelectedItem;
                textBox_Varosnev.Text = Program.KivalasztottVaros.Nev;
                numeric_Lakossag.Value = Program.KivalasztottVaros.Lakossag;
                button_Varos_Delete.Enabled = true;
                button_Varos_Update.Enabled = true;
                button_Latvanyossagok_form_view.Enabled = true;
                button_Cimer_feltoltese.Enabled = true;
                button_Latvanyossagok_form_view.Enabled = true;
                pictureBox_Cimer.Image = Program.KivalasztottVaros.ByteArrayToImage();

            }
            else
            {
                Program.KivalasztottVaros = null;
                textBox_Varosnev.Text = "";
                numeric_Lakossag.Value = numeric_Lakossag.Minimum;
                button_Varos_Delete.Enabled = false;
                button_Varos_Update.Enabled = false;
                button_Latvanyossagok_form_view.Enabled = false;
                pictureBox_Cimer.Image = Program.KivalasztottVaros.ByteArrayToImage();
                button_Cimer_feltoltese.Enabled = false;
                button_Latvanyossagok_form_view.Enabled = false;

            }
        }
        private void button_Cimer_feltoltese_Click(object sender, EventArgs e)
        {
            if (Program.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(Program.openFileDialog1.FileName);
                if (ext.Equals("png"))
                {
                    //SVGParser.MaximumSize = new System.Drawing.Size(4000, 4000);
                    //svgDocument = SVGParser.GetSvgDocument(mPath);
                    //var bitmap = svgDocument.Draw();
                    //image = bitmap;
                }
                pictureBox_Cimer.Image = Image.FromFile(Program.openFileDialog1.FileName);
                pictureBox_Cimer.SizeMode = PictureBoxSizeMode.Zoom;
                Program.KivalasztottVaros.ImageToByteArray(Program.openFileDialog1.FileName);
            }
        }
        private void button_Varos_Delete_Click(object sender, EventArgs e)
        {
            if (Program.KivalasztottVaros== null || listBox_Varosok.SelectedIndex == -1)
            {
                MessageBox.Show("Kérem válassza ki a törölni kívánt várost!");
                return;
            }
            if (MessageBox.Show($"Valóban törölni akarja?\n\nHelység: {Program.KivalasztottVaros.Nev}\nLakossága: {Program.KivalasztottVaros.Lakossag}\n", "Adat törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            //-- rögzítés az adatbázisban ------------------------------------
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
                sql.CommandText = "DELETE FROM `varosok` WHERE `varosok`.`id` = @id;";
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@id", Program.KivalasztottVaros.Id);
                if (sql.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("A törlés sikertelen!");
                }
                Program.conn.Close();
                textBox_Varosnev.Text = "";
                numeric_Lakossag.Value = numeric_Lakossag.Minimum;
                VaroslistaUpdate();
                Program.KivalasztottVaros= null;
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
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
        private void button_Varos_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Valóban módosítja {Program.KivalasztottVaros.Nev} adatait?", "Adatmódosítás", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            sql.CommandText = "UPDATE `varosok` SET `nev`=@nev,`lakossag`=@lakossag,`cimer`=@cimer WHERE `id`=@id;";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@id", Program.KivalasztottVaros.Id);
            sql.Parameters.AddWithValue("@nev", Program.FirstCharToUpper(textBox_Varosnev.Text.Trim()));
            sql.Parameters.AddWithValue("@lakossag", (int)numeric_Lakossag.Value);
            sql.Parameters.AddWithValue("@cimer", cimer);
            Program.conn.Open();
            sql.ExecuteNonQuery();
            Program.conn.Close();
            VaroslistaUpdate();
        }
        private void button_Varos_Insert_Click(object sender, EventArgs e)
        {
            //-- városnév ellenőrzés ------------------------------------------
            string VarosNeve = textBox_Varosnev.Text.Trim();
            if (VarosNeve.Length < 1)
            {
                MessageBox.Show("Kérem adjon meg városnevet!", "Hiányos adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Varosnev.Focus();
                textBox_Varosnev.Select(textBox_Varosnev.Text.Length, 0);
                return;
            }
            else
            {
                VarosNeve = Program.FirstCharToUpper(VarosNeve);
            }

            //-- lakosság ellenőrzés ------------------------------------------
            int lakossag = Convert.ToInt32(numeric_Lakossag.Value);
            if (lakossag < 1)
            {
                MessageBox.Show("Kérem adja meg a lakosok számát!", "Hiányos adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numeric_Lakossag.Focus();
                return;
            }
            if (MessageBox.Show($"Rögzíti az új adatokat?\n\nHelység: {VarosNeve}\nLakossága: {lakossag}\n") != DialogResult.OK)
            {
                return;
            }
            //-- rögzítés az adatbázisban ------------------------------------
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
                sql.CommandText = "INSERT INTO `varosok` (`id`, `nev`, `lakossag`, `cimer` ) VALUES (NULL, @varos, @lakossag, @cimer);";
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@varos", VarosNeve);
                sql.Parameters.AddWithValue("@lakossag", lakossag);
                sql.Parameters.AddWithValue("@cimer", cimer);
                if (sql.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("A város adatbázisba írása sikertelen!");
                }
                Program.conn.Close();
                textBox_Varosnev.Text = "";
                numeric_Lakossag.Value = numeric_Lakossag.Minimum;
                VaroslistaUpdate();
            }
            catch (MySqlException myex)
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
        private void button_Latvanyossagok_form_view_Click(object sender, EventArgs e)
        {
            if (listBox_Varosok.SelectedIndex >= 0 && Program.KivalasztottVaros != null)
            {
                this.Hide();
                Program.form_latvanyossag.Show();
            }
        }
        private void textBox_Varosnev_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Varosnev.Text.Length > 0)
            {
                textBox_Varosnev.Text = Program.FirstCharToUpper(string.Concat(textBox_Varosnev.Text.Where(c => char.IsLetter(c))));
                textBox_Varosnev.Select(textBox_Varosnev.Text.Length, 0);
                VarosadatokKitoltve();
            }
        }

        private void button_Latvanyossagok_form_view_MouseEnter(object sender, EventArgs e)
        {
            button_Latvanyossagok_form_view.BackColor = Color.LightPink;
            button_Latvanyossagok_form_view.FlatStyle = FlatStyle.Flat;
            button_Latvanyossagok_form_view.FlatAppearance.BorderColor = Color.Red;
            button_Latvanyossagok_form_view.FlatAppearance.BorderSize = 1;
        }

        private void button_Latvanyossagok_form_view_MouseLeave(object sender, EventArgs e)
        {
            button_Latvanyossagok_form_view.BackColor = Color.LightGreen;
            button_Latvanyossagok_form_view.FlatStyle = FlatStyle.Flat;
            button_Latvanyossagok_form_view.FlatAppearance.BorderColor = Color.Green;
            button_Latvanyossagok_form_view.FlatAppearance.BorderSize = 1;

        }
    }
}
