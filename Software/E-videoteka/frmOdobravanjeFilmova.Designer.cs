
namespace E_videoteka
{
    partial class frmOdobravanjeFilmova
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
            this.dgvPopisFilmovaNaListiČekanja = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisFilmovaNaListiČekanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisFilmovaNaListiČekanja
            // 
            this.dgvPopisFilmovaNaListiČekanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisFilmovaNaListiČekanja.Location = new System.Drawing.Point(22, 45);
            this.dgvPopisFilmovaNaListiČekanja.Name = "dgvPopisFilmovaNaListiČekanja";
            this.dgvPopisFilmovaNaListiČekanja.Size = new System.Drawing.Size(749, 329);
            this.dgvPopisFilmovaNaListiČekanja.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(476, 391);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 32);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.Location = new System.Drawing.Point(587, 391);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(85, 32);
            this.btnOdobri.TabIndex = 2;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(686, 391);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(85, 32);
            this.btnUkloni.TabIndex = 3;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Popis filmova na listi čekanja:";
            // 
            // frmOdobravanjeFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dgvPopisFilmovaNaListiČekanja);
            this.Name = "frmOdobravanjeFilmova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdobravanjeFilmova";
            this.Load += new System.EventHandler(this.frmOdobravanjeFilmova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOdobravanjeFilmova_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOdobravanjeFilmova_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisFilmovaNaListiČekanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisFilmovaNaListiČekanja;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Label label1;
    }
}