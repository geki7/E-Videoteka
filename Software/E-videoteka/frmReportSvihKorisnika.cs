using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmReportSvihKorisnika : Form
    {
        public frmReportSvihKorisnika()
        {
            InitializeComponent();
        }

        private void frmReportSvihKorisnika_Load(object sender, EventArgs e)
        {
            DohvatiPodatke();
            DohvatiPodatkeZaGraf();
            this.reportViewer.RefreshReport();
        }

        private void DohvatiPodatkeZaGraf()
        {
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using (var context = new PI2247_DBEntities1())
            {
                var query = from c in context.Korisniks
                            select c;
                listaKorisnika = query.ToList();
            }
            int brAdmin = 0;
            int brKorisnik = 0;
            int brGost = 0;
            int brRecenzent = 0;
            foreach (var item in listaKorisnika)
            {
                if (item.Uloga == "Admin")
                {
                    brAdmin += 1;
                }
                if (item.Uloga == "Recenzent")
                {
                    brRecenzent += 1;
                }
                if (item.Uloga == "Gost")
                {
                    brGost += 1;
                }
                if (item.Uloga == "Korisnik")
                {
                    brKorisnik += 1;
                }
            }
            List<UlogeKorisnika> listaUloga = new List<UlogeKorisnika>();
            if (brAdmin != 0) {
                listaUloga.Add(new UlogeKorisnika(brAdmin, "Admin"));
            }
            if(brGost != 0)
            {
                listaUloga.Add(new UlogeKorisnika(brGost, "Gost"));
            }
            if (brKorisnik != 0)
            {
                listaUloga.Add(new UlogeKorisnika(brKorisnik, "Korisnik"));
            }
            if (brRecenzent != 0)
            {
                listaUloga.Add(new UlogeKorisnika(brRecenzent, "Recenzent"));

            }
            ulogeKorisnikaBindingSource.DataSource = listaUloga;
        }

        private void DohvatiPodatke()
        {
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using(var context = new PI2247_DBEntities1())
            {
                var query = from c in context.Korisniks
                            select c;
                listaKorisnika = query.ToList();
                KorisnikBindingSource.DataSource = listaKorisnika;
            }
           
        }
    }
}
