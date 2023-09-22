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
    public partial class frmIzmjeniKorisnikaAdmin : Form
    {
        public Korisnik selektirani;
        public frmIzmjeniKorisnikaAdmin(Korisnik selektiraniKorisnik)
        {
            InitializeComponent();
            selektirani = selektiraniKorisnik;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var contex = new PI2247_DBEntities1())
            {
                string ime = txtbIme.Text.ToString();
                string prezime = txtbPrezime.Text.ToString();
                string email = txtbEmail.Text.ToString();
                string username = txtbUsername.Text.ToString();
                string lozinka = txtbLozinka.Text.ToString();
                string uloga = cmbUloga.SelectedItem as string;

                contex.Korisniks.Attach(selektirani);
                selektirani.Ime = ime;
                selektirani.Prezime = prezime;
                selektirani.Email = email;
                selektirani.Username = username;
                selektirani.Password = lozinka;
                selektirani.Uloga = uloga;
                contex.SaveChanges();
            }
            Close();
        }

        private void frmIzmjeniKorisnikaAdmin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmIzmjeniKorisnikaAdmin_KeyDown);

            if (selektirani.Uloga == "Admin")
            {
                txtbIme.ReadOnly = true;
                txtbPrezime.ReadOnly =true;
                txtbEmail.ReadOnly= true;
                txtbUsername.ReadOnly=true;
                txtbLozinka.ReadOnly = true;
                cmbUloga.SelectedText = "Admin";
                cmbUloga.Enabled =false;
                btnSpremi.Enabled = false;
                
            }
            txtbIme.Text = selektirani.Ime;
            txtbPrezime.Text = selektirani.Prezime;
            txtbEmail.Text = selektirani.Email;
            txtbUsername.Text = selektirani.Username;
            txtbLozinka.Text = selektirani.Password;
            cmbUloga.SelectedItem = selektirani.Uloga;


        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIzmjeniKorisnikaAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "IzmjeniKorisnikaForma.htm");
            }
        }
    }
}
