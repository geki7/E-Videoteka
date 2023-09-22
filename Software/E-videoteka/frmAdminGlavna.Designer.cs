namespace E_videoteka
{
    partial class frmAdminGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminGlavna));
            this.btnUpravljanjeKorisnicima = new System.Windows.Forms.Button();
            this.btnVideoteka = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatistika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpravljanjeKorisnicima
            // 
            this.btnUpravljanjeKorisnicima.Location = new System.Drawing.Point(425, 34);
            this.btnUpravljanjeKorisnicima.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpravljanjeKorisnicima.Name = "btnUpravljanjeKorisnicima";
            this.btnUpravljanjeKorisnicima.Size = new System.Drawing.Size(128, 58);
            this.btnUpravljanjeKorisnicima.TabIndex = 0;
            this.btnUpravljanjeKorisnicima.Text = "Upravljanje korisnicima";
            this.btnUpravljanjeKorisnicima.UseVisualStyleBackColor = true;
            this.btnUpravljanjeKorisnicima.Click += new System.EventHandler(this.btnUpravljanjeKorisnicima_Click);
            // 
            // btnVideoteka
            // 
            this.btnVideoteka.Location = new System.Drawing.Point(425, 126);
            this.btnVideoteka.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoteka.Name = "btnVideoteka";
            this.btnVideoteka.Size = new System.Drawing.Size(128, 54);
            this.btnVideoteka.TabIndex = 1;
            this.btnVideoteka.Text = "Videoteka";
            this.btnVideoteka.UseVisualStyleBackColor = true;
            this.btnVideoteka.Click += new System.EventHandler(this.btnVideoteka_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(425, 281);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(128, 54);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 271);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(425, 202);
            this.btnStatistika.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(128, 54);
            this.btnStatistika.TabIndex = 4;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // frmAdminGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnVideoteka);
            this.Controls.Add(this.btnUpravljanjeKorisnicima);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.frmAdminGlavna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdminGlavna_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpravljanjeKorisnicima;
        private System.Windows.Forms.Button btnVideoteka;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStatistika;
    }
}