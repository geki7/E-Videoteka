using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace E_videoteka
{
    public partial class frmGledajFilm : Form
    {
        private string videoFile;
        private LibVLC libvlc = new LibVLC();
        private VideoView vv = new VideoView();

        public frmGledajFilm(string videoFile)
        {
            this.videoFile = videoFile;
            vv.MediaPlayer = new MediaPlayer(libvlc);
            InitializeComponent();
        }

        private void frmGledajFilm_Load(object sender, EventArgs e)
        {
            vv.Dock = DockStyle.Fill;
            Controls.Add(vv);

            var uri = new Uri($@"http://192.168.1.7:3000/{videoFile}");
            var media = new Media(libvlc, uri, ":input-repeat=65535");
            vv.MediaPlayer.Play(media);
        }
    }
}
