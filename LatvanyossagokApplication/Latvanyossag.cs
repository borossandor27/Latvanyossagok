using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Latvanyossag
    {
        int id;
        string nev;
        string leiras;
        int ar;
        int varos_id;

        public Latvanyossag(int id, string nev, string leiras, int ar, int varos_id)
        {
            this.Id = id;
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            this.varos_id = varos_id;
        }

        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"{nev} - {ar} Ft";
        }
    }
}
