﻿using System;
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
            this.Nev = nev;
            this.Leiras = leiras;
            this.Ar = ar;
            this.varos_id = varos_id;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            if (ar != 0)
            {
                return $"{Nev} - {Ar} Ft";
            }
            else
            {
                return $"{Nev} - Ingyenes";
            }
        }
    }
}
