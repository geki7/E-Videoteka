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
    public partial class frmGlavnaRecenzent : Form
    {
        public frmGlavnaRecenzent()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava.ulogirani = null;
            Close();
        }

        private void btnVideoteka_Click(object sender, EventArgs e)
        {
            frmVideoteka videoteka = new frmVideoteka();
            videoteka.ShowDialog();
        }

        private void btnOdobravanjeFilmova_Click(object sender, EventArgs e)
        {
            frmOdobravanjeFilmova forma = new frmOdobravanjeFilmova();
            forma.ShowDialog();
        }

        private void frmGlavnaRecenzent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "PocetnaFormaRecenzent.htm");
            }
        }

        private void frmGlavnaRecenzent_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmGlavnaRecenzent_KeyDown);
        }
    }
}
