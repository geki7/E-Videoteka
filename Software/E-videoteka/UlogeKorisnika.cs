using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_videoteka
{
    public class UlogeKorisnika
    {
        public int Broj { get; set; }
        public string Uloga { get; set; }

        public UlogeKorisnika(int br, string ul)
        {
            Broj = br;
            Uloga = ul;
        }
    }
}
