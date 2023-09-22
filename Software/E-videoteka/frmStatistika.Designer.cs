
namespace E_videoteka
{
    partial class frmStatistika
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvPopisSvihFilmova = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportKorisnika = new System.Windows.Forms.Button();
            this.btnIzvjestajFilmova = new System.Windows.Forms.Button();
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnPrikaziSveFilmove = new System.Windows.Forms.Button();
            this.cmbZanr = new System.Windows.Forms.Label();
            this.cmbZanrovi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPretraziPoNazivu = new System.Windows.Forms.TextBox();
            this.btnIzvještajSvih = new System.Windows.Forms.Button();
            this.rbGledanost = new System.Windows.Forms.RadioButton();
            this.rbStarost = new System.Windows.Forms.RadioButton();
            this.btnPrikaziOdabrano = new System.Windows.Forms.Button();
            this.rbPoKategorijama = new System.Windows.Forms.RadioButton();
            this.btnPogledaniFIlmovi = new System.Windows.Forms.Button();
            this.btnFiltriranaLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihFilmova)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(515, 494);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(137, 40);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvPopisSvihFilmova
            // 
            this.dgvPopisSvihFilmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSvihFilmova.Location = new System.Drawing.Point(12, 176);
            this.dgvPopisSvihFilmova.Name = "dgvPopisSvihFilmova";
            this.dgvPopisSvihFilmova.Size = new System.Drawing.Size(483, 358);
            this.dgvPopisSvihFilmova.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Popis filmova:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReportKorisnika
            // 
            this.btnReportKorisnika.Location = new System.Drawing.Point(515, 25);
            this.btnReportKorisnika.Name = "btnReportKorisnika";
            this.btnReportKorisnika.Size = new System.Drawing.Size(137, 39);
            this.btnReportKorisnika.TabIndex = 6;
            this.btnReportKorisnika.Text = "Izvještaj svih korisnika";
            this.btnReportKorisnika.UseVisualStyleBackColor = true;
            this.btnReportKorisnika.Click += new System.EventHandler(this.btnReportKorisnika_Click);
            // 
            // btnIzvjestajFilmova
            // 
            this.btnIzvjestajFilmova.Location = new System.Drawing.Point(515, 134);
            this.btnIzvjestajFilmova.Name = "btnIzvjestajFilmova";
            this.btnIzvjestajFilmova.Size = new System.Drawing.Size(137, 39);
            this.btnIzvjestajFilmova.TabIndex = 7;
            this.btnIzvjestajFilmova.Text = "Izvještaj filmova za odabranog korisnika";
            this.btnIzvjestajFilmova.UseVisualStyleBackColor = true;
            this.btnIzvjestajFilmova.Click += new System.EventHandler(this.btnIzvjestajFilmova_Click);
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(358, 35);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(137, 21);
            this.cmbKorisnici.TabIndex = 8;
            this.cmbKorisnici.SelectedIndexChanged += new System.EventHandler(this.cmbKorisnici_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Korisnici:";
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(17, 77);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(58, 34);
            this.btnSortiraj.TabIndex = 10;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnPrikaziSveFilmove
            // 
            this.btnPrikaziSveFilmove.Location = new System.Drawing.Point(426, 110);
            this.btnPrikaziSveFilmove.Name = "btnPrikaziSveFilmove";
            this.btnPrikaziSveFilmove.Size = new System.Drawing.Size(69, 34);
            this.btnPrikaziSveFilmove.TabIndex = 11;
            this.btnPrikaziSveFilmove.Text = "Prikaži sve";
            this.btnPrikaziSveFilmove.UseVisualStyleBackColor = true;
            this.btnPrikaziSveFilmove.Click += new System.EventHandler(this.btnPrikaziSveFilmove_Click);
            // 
            // cmbZanr
            // 
            this.cmbZanr.AutoSize = true;
            this.cmbZanr.Location = new System.Drawing.Point(359, 59);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(32, 13);
            this.cmbZanr.TabIndex = 12;
            this.cmbZanr.Text = "Žanr:";
            // 
            // cmbZanrovi
            // 
            this.cmbZanrovi.FormattingEnabled = true;
            this.cmbZanrovi.Location = new System.Drawing.Point(358, 77);
            this.cmbZanrovi.Name = "cmbZanrovi";
            this.cmbZanrovi.Size = new System.Drawing.Size(137, 21);
            this.cmbZanrovi.TabIndex = 13;
            this.cmbZanrovi.SelectedIndexChanged += new System.EventHandler(this.cmbZanrovi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Traži po naslovu:";
            // 
            // txtbPretraziPoNazivu
            // 
            this.txtbPretraziPoNazivu.Location = new System.Drawing.Point(108, 118);
            this.txtbPretraziPoNazivu.Name = "txtbPretraziPoNazivu";
            this.txtbPretraziPoNazivu.Size = new System.Drawing.Size(129, 20);
            this.txtbPretraziPoNazivu.TabIndex = 15;
            this.txtbPretraziPoNazivu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnIzvještajSvih
            // 
            this.btnIzvještajSvih.Location = new System.Drawing.Point(515, 77);
            this.btnIzvještajSvih.Name = "btnIzvještajSvih";
            this.btnIzvještajSvih.Size = new System.Drawing.Size(137, 40);
            this.btnIzvještajSvih.TabIndex = 17;
            this.btnIzvještajSvih.Text = "Izvještaj svih filmova";
            this.btnIzvještajSvih.UseVisualStyleBackColor = true;
            this.btnIzvještajSvih.Click += new System.EventHandler(this.btnIzvještajSvih_Click);
            // 
            // rbGledanost
            // 
            this.rbGledanost.AutoSize = true;
            this.rbGledanost.Location = new System.Drawing.Point(12, 31);
            this.rbGledanost.Name = "rbGledanost";
            this.rbGledanost.Size = new System.Drawing.Size(135, 17);
            this.rbGledanost.TabIndex = 18;
            this.rbGledanost.TabStop = true;
            this.rbGledanost.Text = "Gledanost (od najveće)";
            this.rbGledanost.UseVisualStyleBackColor = true;
            // 
            // rbStarost
            // 
            this.rbStarost.AutoSize = true;
            this.rbStarost.Location = new System.Drawing.Point(12, 54);
            this.rbStarost.Name = "rbStarost";
            this.rbStarost.Size = new System.Drawing.Size(115, 17);
            this.rbStarost.TabIndex = 19;
            this.rbStarost.TabStop = true;
            this.rbStarost.Text = "Stariji od 10 godina";
            this.rbStarost.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziOdabrano
            // 
            this.btnPrikaziOdabrano.Location = new System.Drawing.Point(358, 110);
            this.btnPrikaziOdabrano.Name = "btnPrikaziOdabrano";
            this.btnPrikaziOdabrano.Size = new System.Drawing.Size(62, 34);
            this.btnPrikaziOdabrano.TabIndex = 20;
            this.btnPrikaziOdabrano.Text = "Prikaži odabrano";
            this.btnPrikaziOdabrano.UseVisualStyleBackColor = true;
            this.btnPrikaziOdabrano.Click += new System.EventHandler(this.btnPrikaziOdabrano_Click);
            // 
            // rbPoKategorijama
            // 
            this.rbPoKategorijama.AutoSize = true;
            this.rbPoKategorijama.Location = new System.Drawing.Point(12, 8);
            this.rbPoKategorijama.Name = "rbPoKategorijama";
            this.rbPoKategorijama.Size = new System.Drawing.Size(101, 17);
            this.rbPoKategorijama.TabIndex = 21;
            this.rbPoKategorijama.TabStop = true;
            this.rbPoKategorijama.Text = "Po kategorijama";
            this.rbPoKategorijama.UseVisualStyleBackColor = true;
            // 
            // btnPogledaniFIlmovi
            // 
            this.btnPogledaniFIlmovi.Location = new System.Drawing.Point(515, 188);
            this.btnPogledaniFIlmovi.Name = "btnPogledaniFIlmovi";
            this.btnPogledaniFIlmovi.Size = new System.Drawing.Size(137, 52);
            this.btnPogledaniFIlmovi.TabIndex = 22;
            this.btnPogledaniFIlmovi.Text = "Izvještaj pogledanih filmova za odabranog korisnika";
            this.btnPogledaniFIlmovi.UseVisualStyleBackColor = true;
            this.btnPogledaniFIlmovi.Click += new System.EventHandler(this.btnPogledaniFIlmovi_Click);
            // 
            // btnFiltriranaLista
            // 
            this.btnFiltriranaLista.Location = new System.Drawing.Point(515, 418);
            this.btnFiltriranaLista.Name = "btnFiltriranaLista";
            this.btnFiltriranaLista.Size = new System.Drawing.Size(137, 52);
            this.btnFiltriranaLista.TabIndex = 23;
            this.btnFiltriranaLista.Text = "Izvještaj filtrirane liste";
            this.btnFiltriranaLista.UseVisualStyleBackColor = true;
            this.btnFiltriranaLista.Click += new System.EventHandler(this.btnFiltriranaLista_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 546);
            this.Controls.Add(this.btnFiltriranaLista);
            this.Controls.Add(this.btnPogledaniFIlmovi);
            this.Controls.Add(this.rbPoKategorijama);
            this.Controls.Add(this.btnPrikaziOdabrano);
            this.Controls.Add(this.rbStarost);
            this.Controls.Add(this.rbGledanost);
            this.Controls.Add(this.btnIzvještajSvih);
            this.Controls.Add(this.txtbPretraziPoNazivu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbZanrovi);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.btnPrikaziSveFilmove);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKorisnici);
            this.Controls.Add(this.btnIzvjestajFilmova);
            this.Controls.Add(this.btnReportKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPopisSvihFilmova);
            this.Controls.Add(this.btnOdustani);
            this.Name = "frmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStatistika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSvihFilmova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvPopisSvihFilmova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportKorisnika;
        private System.Windows.Forms.Button btnIzvjestajFilmova;
        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnPrikaziSveFilmove;
        private System.Windows.Forms.Label cmbZanr;
        private System.Windows.Forms.ComboBox cmbZanrovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPretraziPoNazivu;
        private System.Windows.Forms.Button btnIzvještajSvih;
        private System.Windows.Forms.RadioButton rbGledanost;
        private System.Windows.Forms.RadioButton rbStarost;
        private System.Windows.Forms.Button btnPrikaziOdabrano;
        private System.Windows.Forms.RadioButton rbPoKategorijama;
        private System.Windows.Forms.Button btnPogledaniFIlmovi;
        private System.Windows.Forms.Button btnFiltriranaLista;
    }
}