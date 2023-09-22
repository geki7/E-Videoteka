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
    public partial class frmReportSvihFilmova : Form
    {
        public frmReportSvihFilmova()
        {
            InitializeComponent();
        }

        private void frmReportSvihFilmova_Load(object sender, EventArgs e)
        {
            List<Film> listaFilmova = new List<Film>();
            using(var context = new PI2247_DBEntities1())
            {
                var query = from f in context.Films
                            select f;
                listaFilmova = query.ToList();
                FilmBindingSource.DataSource = listaFilmova;
            }
            this.reportViewer.RefreshReport();
        }
    }
}
