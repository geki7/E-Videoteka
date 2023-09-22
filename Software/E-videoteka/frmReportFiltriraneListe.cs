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
    public partial class frmReportFiltriraneListe : Form
    {
        public List<Film> proslijedenaLista;
        public frmReportFiltriraneListe(List<Film> lista)
        {
            proslijedenaLista = lista;
            InitializeComponent();
        }

        private void frmReportFiltriraneListe_Load(object sender, EventArgs e)
        {
            FilmBindingSource.DataSource = proslijedenaLista;
            this.reportViewer1.RefreshReport();
        }
    }
}
