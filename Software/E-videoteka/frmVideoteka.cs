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
    public partial class frmVideoteka : Form
    {
        public frmVideoteka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDodajFilm forma = new frmDodajFilm();
            forma.ShowDialog();
            this.Show();
        }

        private void frmVideoteka_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmVideoteka_KeyDown);
            DohvatiDostupneFilmove();
            rbtnUkljuci.Checked = true;

        }

        private void DohvatiDostupneFilmove()
        {
            if (rbtnUkljuci.Enabled)
            {
                using (var context = new PI2247_DBEntities1())
                {
                    var query = from p in context.Films
                                where p.Odobren.ToString() == "Da"
                                select p;
                    dgvDostupniFilmovi.DataSource = query.ToList();
                    dgvDostupniFilmovi.Columns["Korisnik"].Visible = false;
                    dgvDostupniFilmovi.Columns["Odobren"].Visible = false;
                    dgvDostupniFilmovi.Columns["ID_Korsinik"].Visible = false;
                }
            }
        }

        private void btnSviFilmovi_Click(object sender, EventArgs e)
        {
            DohvatiDostupneFilmove();
        }

        private void btnMojiFilmovi_Click(object sender, EventArgs e)
        {
            if(frmPrijava.ulogirani != null)
            {
                using (var context = new PI2247_DBEntities1())
                {
                    context.Korisniks.Attach(frmPrijava.ulogirani);
                    var query = from f in frmPrijava.ulogirani.Films
                                select f;
                    dgvDostupniFilmovi.DataSource = query.ToList();
                }
            }
            
        }

        private void rbtnUkljuci_CheckedChanged(object sender, EventArgs e)
        {
           // PokretacServisa.pokreniServis();
        }

        private void rbtnIskljuci_CheckedChanged(object sender, EventArgs e)
        {
          //  PokretacServisa.zaustaviServis();
        }

        private void frmVideoteka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "FormaVideoteka.htm");
            }
        }

        private void btnGledajFilm_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dgvDostupniFilmovi.CurrentRow.DataBoundItem as Film;
            frmGledajFilm gledajFilm = new frmGledajFilm("test.mp4");
            gledajFilm.ShowDialog();
        }
    }
}
