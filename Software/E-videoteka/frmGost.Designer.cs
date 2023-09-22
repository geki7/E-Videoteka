namespace E_videoteka
{
    partial class frmGost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGost));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnKerirajRacun = new System.Windows.Forms.Button();
            this.btnVideoteka = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(12, 352);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(114, 47);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnKerirajRacun
            // 
            this.btnKerirajRacun.Location = new System.Drawing.Point(239, 352);
            this.btnKerirajRacun.Name = "btnKerirajRacun";
            this.btnKerirajRacun.Size = new System.Drawing.Size(114, 47);
            this.btnKerirajRacun.TabIndex = 2;
            this.btnKerirajRacun.Text = "Kreiraj račun";
            this.btnKerirajRacun.UseVisualStyleBackColor = true;
            this.btnKerirajRacun.Click += new System.EventHandler(this.btnKerirajRacun_Click);
            // 
            // btnVideoteka
            // 
            this.btnVideoteka.Location = new System.Drawing.Point(474, 352);
            this.btnVideoteka.Name = "btnVideoteka";
            this.btnVideoteka.Size = new System.Drawing.Size(114, 47);
            this.btnVideoteka.TabIndex = 3;
            this.btnVideoteka.Text = "Videoteka";
            this.btnVideoteka.UseVisualStyleBackColor = true;
            this.btnVideoteka.Click += new System.EventHandler(this.btnVideoteka_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 324);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVideoteka);
            this.Controls.Add(this.btnKerirajRacun);
            this.Controls.Add(this.btnPovratak);
            this.Name = "frmGost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gost ";
            this.Load += new System.EventHandler(this.frmGost_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGost_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnKerirajRacun;
        private System.Windows.Forms.Button btnVideoteka;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}