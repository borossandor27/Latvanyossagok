using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    static class Program
    {
        public static MySqlConnection conn = null;
        public static Form form_latvanyossag = null;
        public static Form form_varosok = null;
        public static OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public static DatabaseTool db;
        public static Varos KivalasztottVaros = null;


        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "latvanyossagokdb";
            //sb.Port = 3307;
            sb.CharacterSet = "utf8";
            db = new DatabaseTool(sb);
            conn = new MySqlConnection(sb.ToString()); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_latvanyossag = new Form_Latvanyossagok();
            form_latvanyossag.Text = "LatvanyossagokApplication";
            form_varosok = new Form_varosok();
            form_varosok.Text = "LatvanyossagokApplication";
            openFileDialog1.Filter = "Képfájlok|*.jpg;*.png";
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.ApplicationData.ToString();
            Application.Run(form_varosok);
        }

        public static string FirstCharToUpper(string input)  
        {
            return char.ToUpper(input.First()) + input.Substring(1).ToLower();
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}

