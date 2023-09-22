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
    public partial class frmOdobravanjeFilmova : Form
    {
       public List<Film> listaFilmova = new List<Film>();
        public frmOdobravanjeFilmova()
        {
            InitializeComponent();
        }

        private void frmOdobravanjeFilmova_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmOdobravanjeFilmova_KeyDown);
            OsvjeziPopisFilmova();
            
        }

        private void OsvjeziPopisFilmova()
        {
            
            using(var context = new PI2247_DBEntities1())
            {
                var query = from f in context.Films
                            where f.Odobren == "Ne"
                            select f;
                listaFilmova = query.ToList();
            }
            dgvPopisFilmovaNaListiČekanja.DataSource = null;
          dgvPopisFilmovaNaListiČekanja.DataSource = listaFilmova;
            dgvPopisFilmovaNaListiČekanja.Columns["Korisnik"].Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            DodajFilmUBazu();
           
        }

        private void DodajFilmUBazu()
        {
            Film odabraniFilm = dgvPopisFilmovaNaListiČekanja.CurrentRow.DataBoundItem as Film;
            using(var context = new PI2247_DBEntities1())
            {
                context.Films.Attach(odabraniFilm);
                odabraniFilm.Odobren = "Da";
                context.SaveChanges();
            }

            OsvjeziPopisFilmova();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dgvPopisFilmovaNaListiČekanja.CurrentRow.DataBoundItem as Film;
            using (var contex = new PI2247_DBEntities1())
            {
                contex.Films.Attach(odabraniFilm);
                contex.Films.Remove(odabraniFilm);
                contex.SaveChanges();
            }   
           OsvjeziPopisFilmova();

        }

        private void frmOdobravanjeFilmova_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmOdobravanjeFilmova_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "OdobravanjeFilmovaForma.htm");
            }
        }
    }
}
