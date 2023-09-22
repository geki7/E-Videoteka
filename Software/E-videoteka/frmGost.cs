using System;
using System.Windows.Forms;

namespace E_videoteka
{
    public partial class frmGost : Form
    {
        public frmGost()
        {
            InitializeComponent();
        }

        private void frmGost_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmGost_KeyDown);
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKerirajRacun_Click(object sender, EventArgs e)
        {
            frmRegistracija forma = new frmRegistracija();
            forma.ShowDialog();
        }

        private void btnVideoteka_Click(object sender, EventArgs e)
        {
            frmVideoteka videoteka = new frmVideoteka();
            videoteka.ShowDialog();
        }

        private void frmGost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                string cijeli = "File://" + path + "\\UserManual\\UserManual.chm";
                Help.ShowHelp(this, cijeli, HelpNavigator.Topic, "PocetnaFormaGost.htm");
            }
        }
    }
}
