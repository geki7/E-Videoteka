namespace E_videoteka
{
    partial class frmIzmjeniKorisnikaAdmin
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
            this.txtbLozinka = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbLozinka
            // 
            this.txtbLozinka.Location = new System.Drawing.Point(184, 228);
            this.txtbLozinka.Name = "txtbLozinka";
            this.txtbLozinka.Size = new System.Drawing.Size(191, 20);
            this.txtbLozinka.TabIndex = 20;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(184, 180);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.ReadOnly = true;
            this.txtbEmail.Size = new System.Drawing.Size(191, 20);
            this.txtbEmail.TabIndex = 19;
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(184, 129);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(191, 20);
            this.txtbUsername.TabIndex = 18;
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Location = new System.Drawing.Point(184, 72);
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.ReadOnly = true;
            this.txtbPrezime.Size = new System.Drawing.Size(191, 20);
            this.txtbPrezime.TabIndex = 17;
            // 
            // txtbIme
            // 
            this.txtbIme.Location = new System.Drawing.Point(184, 23);
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.ReadOnly = true;
            this.txtbIme.Size = new System.Drawing.Size(191, 20);
            this.txtbIme.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Loznika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime:";
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Items.AddRange(new object[] {
            "Korisnik",
            "Recenzent"});
            this.cmbUloga.Location = new System.Drawing.Point(184, 290);
            this.cmbUloga.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(191, 21);
            this.cmbUloga.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Uloga :";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(48, 344);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(122, 41);
            this.btnSpremi.TabIndex = 23;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(252, 344);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(122, 41);
            this.btnOdustani.TabIndex = 24;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmIzmjeniKorisnikaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 410);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.txtbLozinka);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.txtbPrezime);
            this.Controls.Add(this.txtbIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmIzmjeniKorisnikaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIzmjeniKorisnikaAdmin";
            this.Load += new System.EventHandler(this.frmIzmjeniKorisnikaAdmin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIzmjeniKorisnikaAdmin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbLozinka;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}