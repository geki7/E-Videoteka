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
    public partial class frmReportFilmovaKorisnika : Form
    {
        public int idProslijedenogKorisnika;
        public frmReportFilmovaKorisnika(int korisnik)
        {
           
            InitializeComponent();
            idProslijedenogKorisnika = korisnik;
        }



        private void frmReportFilmovaKorisnika_Load(object sender, EventArgs e)
        {
            using (var context = new PI2247_DBEntities1())
            {
                var query = from c in context.Korisniks
                            where c.ID_Korisnik == idProslijedenogKorisnika
                            select c;
                Korisnik odabrani = query.Single();
                KorisnikBindingSource.DataSource = odabrani;

                var upit = from f in context.Films
                           where f.ID_Korsinik == idProslijedenogKorisnika
                           select f;
                List<Film> listaFilmova = upit.ToList();
                FilmBindingSource.DataSource = listaFilmova;  
            }
               
            DohvatiFilmoveKorisnika();
            this.reportViewer.RefreshReport();
        }
          
          
        

        private void DohvatiFilmoveKorisnika()
        {
            List<Film> listaFilmova = new List<Film>();
            using (var context = new PI2247_DBEntities1())
            {
                var upit = from f in context.Films
                           where f.ID_Korsinik == idProslijedenogKorisnika
                           select f;
                listaFilmova = upit.ToList();  
            }
         List<DodaniFilmoviKorisnika> listaDodanih = new List<DodaniFilmoviKorisnika>();
            int brAkcijski = 0;
            int brDokumentarac = 0;
            int brSF = 0;
            int brRomanticni = 0;
            int brKomedija = 0;

            foreach (Film item in listaFilmova)
            {
                if(item.Kategorija.ToString() == "Romanticni")
                {
                    brRomanticni++;
                }
                if (item.Kategorija.ToString() == "SF")
                {
                    brSF++;
                }
                if (item.Kategorija.ToString() == "Akcijski")
                {
                    brAkcijski++;
                }
                if (item.Kategorija.ToString() == "Dokumentarac")
                {
                    brDokumentarac++;
                }
                if (item.Kategorija.ToString() == "Komedija")
                {
                    brKomedija++;
                }
            }
            if(brDokumentarac > 0)
            {
                listaDodanih.Add(new DodaniFilmoviKorisnika("Dokumentarac", brDokumentarac));
            }
            if (brAkcijski > 0)
            {
                listaDodanih.Add(new DodaniFilmoviKorisnika("Akcijski", brAkcijski));
            }
            if (brSF > 0)
            {
                listaDodanih.Add(new DodaniFilmoviKorisnika("SF", brSF));
            }
            if (brRomanticni > 0)
            {
                listaDodanih.Add(new DodaniFilmoviKorisnika("Romanticni", brRomanticni));
            }
            if (brKomedija > 0)
            {
                listaDodanih.Add(new DodaniFilmoviKorisnika("Komedija", brKomedija));
            }

            dodaniFilmoviKorisnikaBindingSource.DataSource = listaDodanih;
            

        }
            private void reportViewer_Load(object sender, EventArgs e)
            {

            }
    }
}
