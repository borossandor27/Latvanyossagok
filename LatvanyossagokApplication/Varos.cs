using System;
using System.Collections.Generic;
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

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; }
        public int Lakossag { get => lakossag;}

        public Varos(int id, string nev, int lakossag)
        {
            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;
        }
        public override string ToString()
        {
            return $"{nev} - Lakosság: {lakossag} fő";
        }
    }
}
