using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_videoteka
{
    public class DodaniFilmoviKorisnika
    {

        public int BrojFilmova { get; set; }
        public string Zanr { get; set; }
        public DodaniFilmoviKorisnika(string proslijedeni, int broj)
        {
            Zanr = proslijedeni;
            BrojFilmova = broj;
        }
    }
}
