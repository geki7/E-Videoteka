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
    public partial class frmKorisnikPocetnaForma : Form
    {
        public Korisnik proslijedeniKorisnik;
        public frmKorisnikPocetnaForma(Korisnik proslijedeni)
        {
            proslijedeniKorisnik = proslijedeni;
            InitializeComponent();
        }

        private void frmKorisnikPocetnaForma_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmKorisnikPocetnaForma_KeyDown);
        }

        private void btnMojProfil_Click(object sender, EventArgs e)
        {
            frmMojProfil forma = new frmMojProfil(proslijedeniKorisnik);
            forma.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava.ulogirani.Username = null;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVideoteka_Click(object sender, EventArgs e)
        {
            frmVideoteka videoteka = new frmVideoteka();
            videoteka.ShowDialog();
        }

        private void frmKorisnikPocetnaForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "RegistriraniKorisnikPocetnaForma.htm");
            }
        }
    }
}
