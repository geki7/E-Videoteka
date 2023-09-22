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
    public partial class frmMojProfil : Form
    {
        Korisnik proslijedeniKorisnik;
        public frmMojProfil(Korisnik proslijedeni)
        {
            proslijedeniKorisnik = proslijedeni;
            InitializeComponent();
        }

        private void frmMojProfil_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmMojProfil_KeyDown);

            txtbIme.Text = proslijedeniKorisnik.Ime.ToString();
            txtbPrezime.Text = proslijedeniKorisnik.Prezime.ToString();
            txtbEmail.Text = proslijedeniKorisnik.Email.ToString();
            txtbLozinka.Text = proslijedeniKorisnik.Password.ToString();
            txtbUsername.Text = proslijedeniKorisnik.Username.ToString();


        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            using (var context = new PI2247_DBEntities1())
            {
                string ime = txtbIme.Text;
                string prezime = txtbPrezime.Text;
                string email = txtbEmail.Text;
                string username = txtbUsername.Text;
                string lozinka = txtbLozinka.Text;

                context.Korisniks.Attach(proslijedeniKorisnik);
                proslijedeniKorisnik.Ime = ime;
                proslijedeniKorisnik.Prezime = prezime;
                proslijedeniKorisnik.Email = email;
                proslijedeniKorisnik.Username = username;
                proslijedeniKorisnik.Password = lozinka;;
                context.SaveChanges();
            }
            Close();
        }

        private void frmMojProfil_KeyDown(object sender, KeyEventArgs e)
        {
                 if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "MojProfilForma.htm");
            }
        }
    }
}
