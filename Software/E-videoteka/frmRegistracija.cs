using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmRegistracija : Form
    {
        public Autentifikator autentifikator = new Autentifikator();
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistriajSe_Click(object sender, EventArgs e)
        {
            RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();
            string adresa = DohvatiAdresuKorisnika();
            Korisnik gost = repozitorij.DohvatiKorisnikaPoAdresi(adresa);
            if(gost.Username == null)
            {
                string ime = txtbIme.Text;
                string prezime = txtbPrezime.Text;
                string email = txtbEmail.Text;
                string username = txtbUsername.Text;
                string password = txtbLozinka.Text;
                string passwordrep = txtbPonovnaLozinka.Text;

                autentifikator.Registracija(ime, prezime, email, username, password, passwordrep);
                PokretacServisa.kreirajServis();
                Close();
            }
             if(gost.Username == "Gost")
            {
                string ime = txtbIme.Text;
                string prezime = txtbPrezime.Text;
                string email = txtbEmail.Text;
                string username = txtbUsername.Text;
                string password = txtbLozinka.Text;
                string passwordrep = txtbPonovnaLozinka.Text;

                using(var context = new PI2247_DBEntities1())
                {
                    context.Korisniks.Attach(gost);
                    gost.Ime = ime;
                    gost.Prezime = prezime;
                    gost.Username = username;
                    gost.Password = password;
                    gost.Email = email;
                    gost.Uloga = "Korisnik";
                    context.SaveChanges();
                }
                PokretacServisa.kreirajServis();
                Close();
            } 
        }

        private string DohvatiAdresuKorisnika()
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmRegistracija_KeyDown);
        }

        private void frmRegistracija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "RegistrirajSeForma.htm");
            }
        }
    }
}
