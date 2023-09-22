using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmDodajFilm : Form
    {
        public OpenFileDialog ofd;
        public RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();
        public frmDodajFilm()
        {
            ofd = new OpenFileDialog();
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            ValidacijaUnosaFilma();
            DodajFilmNaPopisZaOdobrenje();
            Close();
        }

        private void ValidacijaUnosaFilma()
        {
            if(txtbLokacija.Text == "" ||txtGodina.Text == "" || txtNazivFilma.Text == "" || txtTrajanje.Text == "")
            {
                throw new EmptyInputException("Unos ne može biti prazno polje!");
            }
            if(cmbKategorija.SelectedItem == null)
            {
                throw new EmptyInputException("Odaberite kategoriju!");
            }
            List<Film> listaSvihFilmova = new List<Film>();
            using (var context = new PI2247_DBEntities1())
            {
                foreach (Korisnik korisnik in context.Korisniks)
                {
                    foreach (Film f in korisnik.Films)
                    {
                        listaSvihFilmova.Add(f);
                    }
                }
            }
            foreach (Film item in listaSvihFilmova)
            {
                if(item.Naziv.ToLower() == txtNazivFilma.Text.ToLower())
                {
                    throw new InvalidInputException("Film koji ste unijeli već postoji u bazi podataka!");
                }
            }
        }

        private void DodajFilmNaPopisZaOdobrenje()
        {

            Film novifilm = new Film();
            novifilm.GodinaIzdanja = txtGodina.Text.ToString();
            novifilm.LokacijaFilma = txtbLokacija.Text;
            novifilm.Kategorija = (string)cmbKategorija.SelectedItem;
            novifilm.Trajanje = txtTrajanje.Text.ToString();
            novifilm.Naziv = txtNazivFilma.Text.ToString();
            Korisnik test = frmPrijava.ulogirani;
            if (test.Username == null)
            {
                string adresa = DohvatiAdresu();
               
                Korisnik gost = repozitorij.DohvatiKorisnikaPoAdresi(adresa);
           
                if (gost.Username == null)
                {



                 
                    string ime = "Gost";
                    string prezime = "Gost";
                    string password = "Gost";
                    string email = "Gost@foi.hr";
                    string uloga = "Gost";
                    string username = "Gost";


                    repozitorij.DodajKorisnika(ime, prezime, email, username, password, adresa, uloga);
                    Korisnik noviKorisnik = repozitorij.DohvatiKorisnikaPoAdresi(adresa);
                    novifilm.ID_Korsinik = noviKorisnik.ID_Korisnik;
                    novifilm.Odobren = "Ne";
                    using (var context = new PI2247_DBEntities1())
                    {
                        context.Korisniks.Attach(noviKorisnik);
                        noviKorisnik.Films.Add(novifilm);
                        context.SaveChanges();
                    }
                }
                
                if (gost.Username == "Gost")
                {
                    novifilm.ID_Korsinik = gost.ID_Korisnik;
                    novifilm.Odobren = "Ne";
                    using (var context = new PI2247_DBEntities1())
                    {
                        context.Korisniks.Attach(gost);
                        gost.Films.Add(novifilm);
                        context.SaveChanges();
                    }
                }

            }
            if (test.Username != null)
            {
                novifilm.ID_Korsinik = frmPrijava.ulogirani.ID_Korisnik;
                novifilm.Odobren = "Ne";
                using (var context = new PI2247_DBEntities1())
                {
                    context.Korisniks.Attach(frmPrijava.ulogirani);
                    frmPrijava.ulogirani.Films.Add(novifilm);
                    context.SaveChanges();
                }
            }
        }

        private string DohvatiAdresu()
        {
           
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string lokacija = ofd.FileName;
            txtbLokacija.Text = lokacija;
        }

        private void frmDodajFilm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmDodajFilm_KeyDown);
        }

        private void frmDodajFilm_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "DodajFilmForma.htm");
            }
        }
    }
}
