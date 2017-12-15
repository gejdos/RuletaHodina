using System;
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

                HraciePolicka[i].Cislo = i;
                HraciePolicka[i].Parnost = vratParnost(i);
                HraciePolicka[i].Rad = vratRad(i);
            }

        }

        private Parnost vratParnost(int cislo)
        {
            if (cislo == 0) return Parnost.ziadna;
            else if (cislo % 2 == 0) return Parnost.parna;
            else return Parnost.neparna;
        }

        private Rad vratRad(int cislo)
        {
            if (cislo == 0) return Rad.ziadny;
            if (cislo == 1 || cislo - 1 % 3 == 0) return Rad.prvy;
            if (cislo == 2 || cislo - 2 % 3 == 0) return Rad.druhy;
            else return Rad.treti;
            
        }





    }
}
