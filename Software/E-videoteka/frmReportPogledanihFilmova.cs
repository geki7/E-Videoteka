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
    public partial class frmReportPogledanihFilmova : Form
    {
        public int IDproslijedeniKorisnik;
        public frmReportPogledanihFilmova(int id)
        {
            IDproslijedeniKorisnik = id;
            InitializeComponent();
        }

        private void frmReportPogledanihFilmova_Load(object sender, EventArgs e)
        {
            DohvatiPogledaneFilmove();
            
            this.reportViewer1.RefreshReport();
        }

        private void DohvatiPogledaneFilmove()
        {
           
            List<AktivnostKorisnika> listaAktivnosti = new List<AktivnostKorisnika>();
            using (var context = new PI2247_DBEntities1())
            {
                var query = from c in context.AktivnostKorisnikas
                            where c.ID_Korisnik == IDproslijedeniKorisnik
                            select c;
                listaAktivnosti = query.ToList();
            }

            int brSij = 0;
            int brVelj = 0;
            int brOzu = 0;
            int brTrav = 0;
            int brSvib = 0;
            int brLip = 0;
            int brSrp = 0;
            int brKol = 0;
            int brRuj = 0;
            int brList = 0;
            int brStu = 0;
            int brPros = 0;
            List<PogledaniFilmoviUMjesecu> listaPogledanihFilmova = new List<PogledaniFilmoviUMjesecu>();
            foreach (AktivnostKorisnika item in listaAktivnosti)
            {
                int  mjesec = item.Datum.Value.Month;
                if(mjesec == 1)
                {
                    brSij++;
                }
                if (mjesec == 2)
                {
                    brVelj++;
                }
                if (mjesec == 3)
                {
                    brOzu++;
                }
                if (mjesec == 4)
                {
                    brTrav++;
                }
                if (mjesec == 5)
                {
                    brSvib++;
                }
                if (mjesec == 6)
                {
                    brLip++;
                }
                if (mjesec == 7)
                {
                    brSrp++;
                }
                if (mjesec == 8)
                {
                    brKol++;
                }
                if (mjesec == 9)
                {
                    brRuj++;
                }
                if (mjesec == 10)
                {
                    brList++;
                }
                if (mjesec == 11)
                {
                    brStu++;
                }
                if (mjesec == 12)
                {
                    brPros++;
                }
            }
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Sijecanj", brSij));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Veljaca", brVelj));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Ozujak", brOzu));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Travanj", brTrav));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Svibanj", brSvib));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Lipanj", brLip));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Srpanj", brSrp));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Kolovoz", brKol));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Rujan", brRuj));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Listopad", brList));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Studeni", brStu));
            listaPogledanihFilmova.Add(new PogledaniFilmoviUMjesecu("Prosinac", brPros));

            pogledaniFilmoviUMjesecuBindingSource.DataSource = listaPogledanihFilmova;

        }
     
    }
}
