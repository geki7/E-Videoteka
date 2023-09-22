
namespace E_videoteka
{
    partial class frmReportSvihKorisnika
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
            this.KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ulogeKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeKorisnikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KorisnikBindingSource
            // 
            this.KorisnikBindingSource.DataSource = typeof(E_videoteka.Korisnik);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsKorisnici";
            reportDataSource1.Value = this.KorisnikBindingSource;
            reportDataSource2.Name = "dsUlogeKorisnica";
            reportDataSource2.Value = this.ulogeKorisnikaBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "E_videoteka.rptSviKorisnici.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(640, 355);
            this.reportViewer.TabIndex = 0;
            // 
            // ulogeKorisnikaBindingSource
            // 
            this.ulogeKorisnikaBindingSource.DataSource = typeof(E_videoteka.UlogeKorisnika);
            // 
            // frmReportSvihKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 355);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmReportSvihKorisnika";
            this.Text = "Izvještaj svih korisnika";
            this.Load += new System.EventHandler(this.frmReportSvihKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeKorisnikaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource KorisnikBindingSource;
        private System.Windows.Forms.BindingSource ulogeKorisnikaBindingSource;
    }
}