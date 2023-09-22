
namespace E_videoteka
{
    partial class frmReportPogledanihFilmova
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AktivnostKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogledaniFilmoviUMjesecuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AktivnostKorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledaniFilmoviUMjesecuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AktivnostKorisnikaBindingSource
            // 
            this.AktivnostKorisnikaBindingSource.DataSource = typeof(E_videoteka.AktivnostKorisnika);
            // 
            // FilmBindingSource
            // 
            this.FilmBindingSource.DataSource = typeof(E_videoteka.Film);
            // 
            // KorisnikBindingSource
            // 
            this.KorisnikBindingSource.DataSource = typeof(E_videoteka.Korisnik);
            // 
            // pogledaniFilmoviUMjesecuBindingSource
            // 
            this.pogledaniFilmoviUMjesecuBindingSource.DataSource = typeof(E_videoteka.PogledaniFilmoviUMjesecu);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPogledaniFilmovi";
            reportDataSource1.Value = this.AktivnostKorisnikaBindingSource;
            reportDataSource2.Name = "pogledanFilm";
            reportDataSource2.Value = this.FilmBindingSource;
            reportDataSource3.Name = "dsKorisnikKojiJeGledao";
            reportDataSource3.Value = this.KorisnikBindingSource;
            reportDataSource4.Name = "dsGledaniUMjesecu";
            reportDataSource4.Value = this.pogledaniFilmoviUMjesecuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E_videoteka.rptPogledaniFilmovi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReportPogledanihFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportPogledanihFilmova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportPogledanihFilmova";
            this.Load += new System.EventHandler(this.frmReportPogledanihFilmova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AktivnostKorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledaniFilmoviUMjesecuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AktivnostKorisnikaBindingSource;
        private System.Windows.Forms.BindingSource FilmBindingSource;
        private System.Windows.Forms.BindingSource KorisnikBindingSource;
        private System.Windows.Forms.BindingSource pogledaniFilmoviUMjesecuBindingSource;
    }
}