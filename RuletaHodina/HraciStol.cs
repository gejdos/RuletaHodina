﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaHodina
{
    class HraciStol
    {
        public HraciePole[] HraciePolicka = new HraciePole[37];

        public HraciStol()
        {
            Farba[] rozmiestnenieFarieb = new Farba[37] { Farba.zelena, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna,
                Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena,
                Farba.cierna, Farba.cervena, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna,
                Farba.cervena, Farba.cierna, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena };

            for (int i = 0; i < rozmiestnenieFarieb.Length; i++)
            {
                HraciePolicka[i].Farba = rozmiestnenieFarieb[i];



            }

        }
    }
}
