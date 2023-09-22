
namespace E_videoteka
{
    partial class frmKorisnikPocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKorisnikPocetnaForma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnVideoteka = new System.Windows.Forms.Button();
            this.btnMojProfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 271);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(434, 233);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(128, 65);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnVideoteka
            // 
            this.btnVideoteka.Location = new System.Drawing.Point(434, 129);
            this.btnVideoteka.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoteka.Name = "btnVideoteka";
            this.btnVideoteka.Size = new System.Drawing.Size(128, 65);
            this.btnVideoteka.TabIndex = 5;
            this.btnVideoteka.Text = "Videoteka";
            this.btnVideoteka.UseVisualStyleBackColor = true;
            this.btnVideoteka.Click += new System.EventHandler(this.btnVideoteka_Click);
            // 
            // btnMojProfil
            // 
            this.btnMojProfil.Location = new System.Drawing.Point(434, 41);
            this.btnMojProfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnMojProfil.Name = "btnMojProfil";
            this.btnMojProfil.Size = new System.Drawing.Size(128, 65);
            this.btnMojProfil.TabIndex = 4;
            this.btnMojProfil.Text = "Moj profil";
            this.btnMojProfil.UseVisualStyleBackColor = true;
            this.btnMojProfil.Click += new System.EventHandler(this.btnMojProfil_Click);
            // 
            // frmKorisnikPocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnVideoteka);
            this.Controls.Add(this.btnMojProfil);
            this.Name = "frmKorisnikPocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKorisnikPocetnaForma";
            this.Load += new System.EventHandler(this.frmKorisnikPocetnaForma_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKorisnikPocetnaForma_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnVideoteka;
        private System.Windows.Forms.Button btnMojProfil;
    }
}