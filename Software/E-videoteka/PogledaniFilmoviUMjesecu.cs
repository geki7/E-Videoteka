using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_videoteka
{
    public class PogledaniFilmoviUMjesecu
    {
        public string Mjesec { get; set; }

        public int BrojGledanih { get; set; }

        public PogledaniFilmoviUMjesecu(string mjesec, int brojGledanih)
        {
            BrojGledanih = brojGledanih;
            Mjesec = mjesec;
        }
    }
}
