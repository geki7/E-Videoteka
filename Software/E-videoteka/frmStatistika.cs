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
    public partial class frmStatistika : Form
    {
        public List<Film> listaFilmova = new List<Film>(); 
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            PrikaziSveFilmove();
            PopuniCombo();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmStatistika_KeyDown);
        }

        private void PopuniCombo()
        {
           
           List<string> listaKorisnickihImena = new List<string>();
           using(var context = new PI2247_DBEntities1())
            {
                var query = from c in context.Korisniks
                            select c.Username;
                listaKorisnickihImena = query.ToList();
            }         
            cmbKorisnici.DataSource = listaKorisnickihImena;
            cmbKorisnici.Text = "";
        }

        private void PrikaziSveFilmove()
        {     
            using(var context = new PI2247_DBEntities1())
            {
                var query = from f in context.Films
                            select f;
                listaFilmova = query.ToList();
                dgvPopisSvihFilmova.DataSource = listaFilmova;
                UrediTablicu();   
            }
        }

        private void UrediTablicu()
        {
            dgvPopisSvihFilmova.Columns["Korisnik"].Visible = false;
            dgvPopisSvihFilmova.Columns["ID_Film"].Visible = false;
            dgvPopisSvihFilmova.Columns["Odobren"].Visible = false;
            dgvPopisSvihFilmova.Columns["LokacijaFilma"].Visible = false;
            dgvPopisSvihFilmova.Columns["ID_Korsinik"].Visible = false;
            dgvPopisSvihFilmova.Columns["AktivnostKorisnikas"].Visible = false;
        }

        private void frmStatistika_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "StatistikaForma.htm");
            }
        }

        

        private void btnReportKorisnika_Click(object sender, EventArgs e)
        {
            frmReportSvihKorisnika forma = new frmReportSvihKorisnika();
            forma.ShowDialog();
        }

        private void btnIzvjestajFilmova_Click(object sender, EventArgs e)
        {
            Korisnik odabrani = DohvatiKorisnika();
            frmReportFilmovaKorisnika forma = new frmReportFilmovaKorisnika(odabrani.ID_Korisnik);
            forma.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrikaziSveFilmove_Click(object sender, EventArgs e)
        {
            cmbKorisnici.Text = "";
            cmbZanrovi.Text = "";
            rbStarost.Checked = false;
            rbGledanost.Checked = false;
            rbPoKategorijama.Checked = false;
            PrikaziSveFilmove();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {

            if(rbGledanost.Checked == true)
            {
                List<Film> filtrirana = listaFilmova.OrderByDescending(x => x.Gledan).ToList();
                dgvPopisSvihFilmova.DataSource = filtrirana;
                UrediTablicu();
            }
            if (rbPoKategorijama.Checked == true)
            {
                List<Film> filtrirana = listaFilmova.OrderBy(x => x.Kategorija).ToList();
                dgvPopisSvihFilmova.DataSource = filtrirana;
                UrediTablicu();
            }
            if (rbStarost.Checked == true)
            {
                List<Film> filtriranaLista = new List<Film>();
                foreach (var item in listaFilmova)
                {
                    int razlika = (2022 - int.Parse(item.GodinaIzdanja));
                    if (razlika > 10)
                    {
                        filtriranaLista.Add(item);
                    }
                }
                dgvPopisSvihFilmova.DataSource = filtriranaLista;
                UrediTablicu();
            }

        }

        private void btnPrikaziOdabrano_Click(object sender, EventArgs e)
        {
            Korisnik odabrani = DohvatiKorisnika();
            List<Film> filtriranaLista = new List<Film>();
            string zanr = cmbZanrovi.Text.ToString();
            foreach (var item in listaFilmova)
            {
                if (item.ID_Korsinik == odabrani.ID_Korisnik && item.Kategorija == zanr)
                {
                    filtriranaLista.Add(item);
                }
            }
            dgvPopisSvihFilmova.DataSource = filtriranaLista;
            UrediTablicu();
        }

        private Korisnik DohvatiKorisnika()
        {
            Korisnik Dohvaceni = new Korisnik();
            List<Korisnik> listaKorisnika = new List<Korisnik>();      
            using (var context = new PI2247_DBEntities1())
            {
                var query = from c in context.Korisniks
                            select c;
                listaKorisnika = query.ToList();
            }
            string odabraniucombo = (string)cmbKorisnici.SelectedItem;
            foreach (var item in listaKorisnika)
            {
                if(item.Username == odabraniucombo)
                {
                    Dohvaceni = item;
                }
            }
            return Dohvaceni;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string pretraganaziv = txtbPretraziPoNazivu.Text.ToString();
            List<Film> filtriraniFilmov = new List<Film>();
            foreach (var item in listaFilmova)
            {
                if (item.Naziv.Contains(pretraganaziv))
                {
                    filtriraniFilmov.Add(item);
                }
            }
            dgvPopisSvihFilmova.DataSource = filtriraniFilmov;
            UrediTablicu();
        }

        private void cmbKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            Korisnik odabrani = DohvatiKorisnika();
            List<string> listaZanrova = new List<string>();
            using (var context = new PI2247_DBEntities1())
            {
                context.Korisniks.Attach(odabrani);
                var query = from c in odabrani.Films
                            select c.Kategorija;
                listaZanrova = query.Distinct().ToList();
            }
            if(listaZanrova.Count == 0)
            {
                cmbZanrovi.Text = "";
            }
            cmbZanrovi.DataSource = listaZanrova;

            List<Film> filtriranaLista = new List<Film>();
            foreach (var item in listaFilmova)
            {
                if (item.ID_Korsinik == odabrani.ID_Korisnik)
                {
                    filtriranaLista.Add(item);
                }
            }
            dgvPopisSvihFilmova.DataSource = filtriranaLista;
            UrediTablicu();

        }

        private void btnIzvještajSvih_Click(object sender, EventArgs e)
        {
            frmReportSvihFilmova forma = new frmReportSvihFilmova();
            forma.ShowDialog();
        }

        private void cmbZanrovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFiltriranaLista_Click(object sender, EventArgs e)
        {
            List<Film> filtriranaLista = dgvPopisSvihFilmova.DataSource as List<Film>;
            frmReportFiltriraneListe forma = new frmReportFiltriraneListe(filtriranaLista);
            forma.ShowDialog();
        }

        private void btnPogledaniFIlmovi_Click(object sender, EventArgs e)
        {
            Korisnik odabrani = DohvatiKorisnika();
            frmReportPogledanihFilmova forma = new frmReportPogledanihFilmova(odabrani.ID_Korisnik);
            forma.ShowDialog();
        }
    }
}
