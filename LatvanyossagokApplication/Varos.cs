using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Varos
    {
        int id;
        string nev;
        int lakossag;
        byte[] cimer;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; }
        public int Lakossag { get => lakossag;}
        public byte[] Cimer { get => cimer; set => cimer = value; }

        public Varos(int id, string nev, int lakossag)
        {
            this.Id = id;
            this.nev = nev;
            this.lakossag = lakossag;
            this.cimer = null;
        }
        public Varos(int id, string nev, int lakossag, byte[] cimer) : this(id, nev, lakossag)
        {
            this.Cimer = cimer;
        }

        public Bitmap ByteToImage()
        {
            if (cimer == null) return null;
            MemoryStream mStream = new MemoryStream();
            byte[] pData = cimer;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public void ImageToByteArray(string ImageFile)
        {
            FileStream stream = new FileStream(
                  ImageFile, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            // Convert image to byte array.
            cimer = reader.ReadBytes((int)stream.Length);
        }
        public override string ToString()
        {
            return $"{nev} - Lakosság: {lakossag} fő";
        }
    }
}
