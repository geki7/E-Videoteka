
namespace E_videoteka
{
    partial class frmVideoteka
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
            this.dgvDostupniFilmovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnUkljuci = new System.Windows.Forms.RadioButton();
            this.rbtnIskljuci = new System.Windows.Forms.RadioButton();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnGledajFilm = new System.Windows.Forms.Button();
            this.btnMojiFilmovi = new System.Windows.Forms.Button();
            this.btnSviFilmovi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDostupniFilmovi
            // 
            this.dgvDostupniFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostupniFilmovi.Location = new System.Drawing.Point(9, 37);
            this.dgvDostupniFilmovi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDostupniFilmovi.Name = "dgvDostupniFilmovi";
            this.dgvDostupniFilmovi.RowHeadersWidth = 51;
            this.dgvDostupniFilmovi.RowTemplate.Height = 24;
            this.dgvDostupniFilmovi.Size = new System.Drawing.Size(770, 242);
            this.dgvDostupniFilmovi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutno dostupni filmovi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Windows servisi :";
            // 
            // rbtnUkljuci
            // 
            this.rbtnUkljuci.AutoSize = true;
            this.rbtnUkljuci.Location = new System.Drawing.Point(47, 333);
            this.rbtnUkljuci.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnUkljuci.Name = "rbtnUkljuci";
            this.rbtnUkljuci.Size = new System.Drawing.Size(57, 17);
            this.rbtnUkljuci.TabIndex = 3;
            this.rbtnUkljuci.TabStop = true;
            this.rbtnUkljuci.Text = "Uključi";
            this.rbtnUkljuci.UseVisualStyleBackColor = true;
            this.rbtnUkljuci.CheckedChanged += new System.EventHandler(this.rbtnUkljuci_CheckedChanged);
            //this.rbtnUkljuci.Click += new System.EventHandler(this.rbtnUkljuci_Click);
            // 
            // rbtnIskljuci
            // 
            this.rbtnIskljuci.AutoSize = true;
            this.rbtnIskljuci.Location = new System.Drawing.Point(112, 333);
            this.rbtnIskljuci.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnIskljuci.Name = "rbtnIskljuci";
            this.rbtnIskljuci.Size = new System.Drawing.Size(57, 17);
            this.rbtnIskljuci.TabIndex = 4;
            this.rbtnIskljuci.TabStop = true;
            this.rbtnIskljuci.Text = "Isključi";
            this.rbtnIskljuci.UseVisualStyleBackColor = true;
            this.rbtnIskljuci.CheckedChanged += new System.EventHandler(this.rbtnIskljuci_CheckedChanged);
            //this.rbtnIskljuci.Click += new System.EventHandler(this.rbtnIskljuci_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(412, 310);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(106, 50);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Location = new System.Drawing.Point(545, 310);
            this.btnDodajFilm.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(106, 50);
            this.btnDodajFilm.TabIndex = 6;
            this.btnDodajFilm.Text = "Dodaj film";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            this.btnDodajFilm.Click += new System.EventHandler(this.btnDodajFilm_Click);
            // 
            // btnGledajFilm
            // 
            this.btnGledajFilm.Location = new System.Drawing.Point(674, 310);
            this.btnGledajFilm.Margin = new System.Windows.Forms.Padding(2);
            this.btnGledajFilm.Name = "btnGledajFilm";
            this.btnGledajFilm.Size = new System.Drawing.Size(106, 50);
            this.btnGledajFilm.TabIndex = 7;
            this.btnGledajFilm.Text = "Gledaj film";
            this.btnGledajFilm.UseVisualStyleBackColor = true;
            this.btnGledajFilm.Click += new System.EventHandler(this.btnGledajFilm_Click);
            // 
            // btnMojiFilmovi
            // 
            this.btnMojiFilmovi.Location = new System.Drawing.Point(497, 7);
            this.btnMojiFilmovi.Name = "btnMojiFilmovi";
            this.btnMojiFilmovi.Size = new System.Drawing.Size(126, 23);
            this.btnMojiFilmovi.TabIndex = 9;
            this.btnMojiFilmovi.Text = "Prikaži moje filmove";
            this.btnMojiFilmovi.UseVisualStyleBackColor = true;
            this.btnMojiFilmovi.Click += new System.EventHandler(this.btnMojiFilmovi_Click);
            // 
            // btnSviFilmovi
            // 
            this.btnSviFilmovi.Location = new System.Drawing.Point(641, 7);
            this.btnSviFilmovi.Name = "btnSviFilmovi";
            this.btnSviFilmovi.Size = new System.Drawing.Size(124, 23);
            this.btnSviFilmovi.TabIndex = 10;
            this.btnSviFilmovi.Text = "Prikaži sve filmove";
            this.btnSviFilmovi.UseVisualStyleBackColor = true;
            this.btnSviFilmovi.Click += new System.EventHandler(this.btnSviFilmovi_Click);
            // 
            // frmVideoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 386);
            this.Controls.Add(this.btnSviFilmovi);
            this.Controls.Add(this.btnMojiFilmovi);
            this.Controls.Add(this.btnGledajFilm);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.rbtnIskljuci);
            this.Controls.Add(this.rbtnUkljuci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDostupniFilmovi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVideoteka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVideoteka";
            this.Load += new System.EventHandler(this.frmVideoteka_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVideoteka_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDostupniFilmovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnUkljuci;
        private System.Windows.Forms.RadioButton rbtnIskljuci;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Button btnGledajFilm;
        private System.Windows.Forms.Button btnMojiFilmovi;
        private System.Windows.Forms.Button btnSviFilmovi;
    }
}