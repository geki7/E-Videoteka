using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_videoteka
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija form = new frmRegistracija();
            form.ShowDialog();

        }

        private void btnGost_Click(object sender, EventArgs e)
        {
            frmGost form = new frmGost();
            form.ShowDialog();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmGlavna_KeyDown);
        }

        private void frmGlavna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "PocetnaForma.htm");
            }
        }
    }
}
