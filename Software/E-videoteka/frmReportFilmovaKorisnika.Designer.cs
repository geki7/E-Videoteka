
namespace E_videoteka
{
    partial class frmReportFilmovaKorisnika
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
            this.FilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dodaniFilmoviKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniFilmoviKorisnikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmBindingSource
            // 
            this.FilmBindingSource.DataSource = typeof(E_videoteka.Film);
            // 
            // KorisnikBindingSource
            // 
            this.KorisnikBindingSource.DataSource = typeof(E_videoteka.Korisnik);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsPrikazFIilma";
            reportDataSource1.Value = this.FilmBindingSource;
            reportDataSource2.Name = "DsKorisnikFilma";
            reportDataSource2.Value = this.KorisnikBindingSource;
            reportDataSource3.Name = "dsDodaniFIlmovi";
            reportDataSource3.Value = this.dodaniFilmoviKorisnikaBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "E_videoteka.rptReportFilma.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(800, 450);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // dodaniFilmoviKorisnikaBindingSource
            // 
            this.dodaniFilmoviKorisnikaBindingSource.DataSource = typeof(E_videoteka.DodaniFilmoviKorisnika);
            // 
            // frmReportFilmovaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmReportFilmovaKorisnika";
            this.Text = "frmReportFilmovaKorisnika";
            this.Load += new System.EventHandler(this.frmReportFilmovaKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniFilmoviKorisnikaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource FilmBindingSource;
        private System.Windows.Forms.BindingSource KorisnikBindingSource;
        private System.Windows.Forms.BindingSource dodaniFilmoviKorisnikaBindingSource;
    }
}