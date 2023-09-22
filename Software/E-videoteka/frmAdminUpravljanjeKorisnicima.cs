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
    public partial class frmAdminUpravljanjeKorisnicima : Form
    {
        public frmAdminUpravljanjeKorisnicima()
        {
            InitializeComponent();
        }

        private void frmAdminUpravljanjeKorisnicima_Load(object sender, EventArgs e)
        {
            DohvatiKorisnike();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmAdminUpravljanjeKorisnicima_KeyDown);

        }

        private void DohvatiKorisnike()
        {
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            select p;
                dgvUpravljanjeKorsincima.DataSource = query.ToList();
                dgvUpravljanjeKorsincima.Columns["AktivnostKorisnikas"].Visible = false;
                dgvUpravljanjeKorsincima.Columns["Films"].Visible = false;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2247_DBEntities1())
            {
                Korisnik selektirani = dgvUpravljanjeKorsincima.CurrentRow.DataBoundItem as Korisnik;
                if (selektirani.Uloga != "Admin")
                {
                    context.Korisniks.Attach(selektirani);
                    context.Korisniks.Remove(selektirani);
                    context.SaveChanges();
                }
                if (selektirani.Uloga == "Admin")
                {
                    MessageBox.Show("Ne moze se obrisati admin!");
                }
            }
            DohvatiKorisnike();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            
            Korisnik selektirani = dgvUpravljanjeKorsincima.CurrentRow.DataBoundItem as Korisnik;
            frmIzmjeniKorisnikaAdmin frmIzmjeni = new frmIzmjeniKorisnikaAdmin(selektirani);
            frmIzmjeni.ShowDialog();

            DohvatiKorisnike();
        }

        private void frmAdminUpravljanjeKorisnicima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "UpravljanjeKorisnicimaForma.htm");
            }
        }
    }
}
