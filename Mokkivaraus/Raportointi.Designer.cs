namespace Mokkivaraus
{
    partial class Raportointi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raportointi));
            this.lblMajoittuminenRaportointi = new System.Windows.Forms.Label();
            this.lblLisapalveluidenRaportointi = new System.Windows.Forms.Label();
            this.dateMajoittuminenMista = new System.Windows.Forms.DateTimePicker();
            this.dateMajoittuminenMihin = new System.Windows.Forms.DateTimePicker();
            this.dateLisapalvelutMista = new System.Windows.Forms.DateTimePicker();
            this.dateLisapalvelutMihin = new System.Windows.Forms.DateTimePicker();
            this.lblRaportointi = new System.Windows.Forms.Label();
            this.btnMajoittumisraportti = new System.Windows.Forms.Button();
            this.btnLisapalveluraportti = new System.Windows.Forms.Button();
            this.lblMista1 = new System.Windows.Forms.Label();
            this.lblMista2 = new System.Windows.Forms.Label();
            this.lblMihin2 = new System.Windows.Forms.Label();
            this.lblMihin1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMajoittuminenRaportointi
            // 
            this.lblMajoittuminenRaportointi.AutoSize = true;
            this.lblMajoittuminenRaportointi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajoittuminenRaportointi.Location = new System.Drawing.Point(27, 89);
            this.lblMajoittuminenRaportointi.Name = "lblMajoittuminenRaportointi";
            this.lblMajoittuminenRaportointi.Size = new System.Drawing.Size(212, 24);
            this.lblMajoittuminenRaportointi.TabIndex = 18;
            this.lblMajoittuminenRaportointi.Text = "Majoittumisen raportointi";
            // 
            // lblLisapalveluidenRaportointi
            // 
            this.lblLisapalveluidenRaportointi.AutoSize = true;
            this.lblLisapalveluidenRaportointi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLisapalveluidenRaportointi.Location = new System.Drawing.Point(27, 313);
            this.lblLisapalveluidenRaportointi.Name = "lblLisapalveluidenRaportointi";
            this.lblLisapalveluidenRaportointi.Size = new System.Drawing.Size(234, 24);
            this.lblLisapalveluidenRaportointi.TabIndex = 19;
            this.lblLisapalveluidenRaportointi.Text = "Lisäpalveluiden Raportointi";
            // 
            // dateMajoittuminenMista
            // 
            this.dateMajoittuminenMista.CustomFormat = "yyyy-MM-dd";
            this.dateMajoittuminenMista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMajoittuminenMista.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMajoittuminenMista.Location = new System.Drawing.Point(32, 142);
            this.dateMajoittuminenMista.Name = "dateMajoittuminenMista";
            this.dateMajoittuminenMista.Size = new System.Drawing.Size(267, 26);
            this.dateMajoittuminenMista.TabIndex = 1;
            this.dateMajoittuminenMista.ValueChanged += new System.EventHandler(this.dateMajoittuminenMista_ValueChanged);
            // 
            // dateMajoittuminenMihin
            // 
            this.dateMajoittuminenMihin.CustomFormat = "yyyy-MM-dd";
            this.dateMajoittuminenMihin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMajoittuminenMihin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMajoittuminenMihin.Location = new System.Drawing.Point(32, 187);
            this.dateMajoittuminenMihin.Name = "dateMajoittuminenMihin";
            this.dateMajoittuminenMihin.Size = new System.Drawing.Size(267, 26);
            this.dateMajoittuminenMihin.TabIndex = 2;
            // 
            // dateLisapalvelutMista
            // 
            this.dateLisapalvelutMista.CustomFormat = "yyyy-MM-dd";
            this.dateLisapalvelutMista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLisapalvelutMista.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLisapalvelutMista.Location = new System.Drawing.Point(32, 360);
            this.dateLisapalvelutMista.Name = "dateLisapalvelutMista";
            this.dateLisapalvelutMista.Size = new System.Drawing.Size(267, 26);
            this.dateLisapalvelutMista.TabIndex = 4;
            this.dateLisapalvelutMista.ValueChanged += new System.EventHandler(this.dateLisapalvelutMista_ValueChanged);
            // 
            // dateLisapalvelutMihin
            // 
            this.dateLisapalvelutMihin.CustomFormat = "yyyy-MM-dd";
            this.dateLisapalvelutMihin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLisapalvelutMihin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLisapalvelutMihin.Location = new System.Drawing.Point(32, 405);
            this.dateLisapalvelutMihin.Name = "dateLisapalvelutMihin";
            this.dateLisapalvelutMihin.Size = new System.Drawing.Size(267, 26);
            this.dateLisapalvelutMihin.TabIndex = 5;
            // 
            // lblRaportointi
            // 
            this.lblRaportointi.AutoSize = true;
            this.lblRaportointi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaportointi.Location = new System.Drawing.Point(27, 29);
            this.lblRaportointi.Name = "lblRaportointi";
            this.lblRaportointi.Size = new System.Drawing.Size(130, 29);
            this.lblRaportointi.TabIndex = 25;
            this.lblRaportointi.Text = "Raportointi";
            // 
            // btnMajoittumisraportti
            // 
            this.btnMajoittumisraportti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMajoittumisraportti.Location = new System.Drawing.Point(32, 232);
            this.btnMajoittumisraportti.Name = "btnMajoittumisraportti";
            this.btnMajoittumisraportti.Size = new System.Drawing.Size(267, 51);
            this.btnMajoittumisraportti.TabIndex = 3;
            this.btnMajoittumisraportti.Text = "Näytä majoittumisraportti";
            this.btnMajoittumisraportti.UseVisualStyleBackColor = true;
            this.btnMajoittumisraportti.Click += new System.EventHandler(this.btnMajoittumisraportti_Click);
            // 
            // btnLisapalveluraportti
            // 
            this.btnLisapalveluraportti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisapalveluraportti.Location = new System.Drawing.Point(32, 452);
            this.btnLisapalveluraportti.Name = "btnLisapalveluraportti";
            this.btnLisapalveluraportti.Size = new System.Drawing.Size(267, 51);
            this.btnLisapalveluraportti.TabIndex = 6;
            this.btnLisapalveluraportti.Text = "Näytä lisäpalveluraportti";
            this.btnLisapalveluraportti.UseVisualStyleBackColor = true;
            this.btnLisapalveluraportti.Click += new System.EventHandler(this.btnLisapalveluraportti_Click);
            // 
            // lblMista1
            // 
            this.lblMista1.AutoSize = true;
            this.lblMista1.Location = new System.Drawing.Point(29, 126);
            this.lblMista1.Name = "lblMista1";
            this.lblMista1.Size = new System.Drawing.Size(35, 13);
            this.lblMista1.TabIndex = 31;
            this.lblMista1.Text = "Mistä:";
            // 
            // lblMista2
            // 
            this.lblMista2.AutoSize = true;
            this.lblMista2.Location = new System.Drawing.Point(29, 344);
            this.lblMista2.Name = "lblMista2";
            this.lblMista2.Size = new System.Drawing.Size(35, 13);
            this.lblMista2.TabIndex = 32;
            this.lblMista2.Text = "Mistä:";
            // 
            // lblMihin2
            // 
            this.lblMihin2.AutoSize = true;
            this.lblMihin2.Location = new System.Drawing.Point(29, 389);
            this.lblMihin2.Name = "lblMihin2";
            this.lblMihin2.Size = new System.Drawing.Size(35, 13);
            this.lblMihin2.TabIndex = 34;
            this.lblMihin2.Text = "Mistä:";
            // 
            // lblMihin1
            // 
            this.lblMihin1.AutoSize = true;
            this.lblMihin1.Location = new System.Drawing.Point(29, 171);
            this.lblMihin1.Name = "lblMihin1";
            this.lblMihin1.Size = new System.Drawing.Size(35, 13);
            this.lblMihin1.TabIndex = 33;
            this.lblMihin1.Text = "Mistä:";
            // 
            // Raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(348, 526);
            this.Controls.Add(this.lblMihin2);
            this.Controls.Add(this.lblMihin1);
            this.Controls.Add(this.lblMista2);
            this.Controls.Add(this.lblMista1);
            this.Controls.Add(this.btnLisapalveluraportti);
            this.Controls.Add(this.btnMajoittumisraportti);
            this.Controls.Add(this.lblRaportointi);
            this.Controls.Add(this.dateLisapalvelutMihin);
            this.Controls.Add(this.dateLisapalvelutMista);
            this.Controls.Add(this.dateMajoittuminenMihin);
            this.Controls.Add(this.dateMajoittuminenMista);
            this.Controls.Add(this.lblLisapalveluidenRaportointi);
            this.Controls.Add(this.lblMajoittuminenRaportointi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raportointi";
            this.Text = "Raportointi";
            this.Load += new System.EventHandler(this.Raportointi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMajoittuminenRaportointi;
        private System.Windows.Forms.Label lblLisapalveluidenRaportointi;
        private System.Windows.Forms.DateTimePicker dateMajoittuminenMista;
        private System.Windows.Forms.DateTimePicker dateMajoittuminenMihin;
        private System.Windows.Forms.DateTimePicker dateLisapalvelutMista;
        private System.Windows.Forms.DateTimePicker dateLisapalvelutMihin;
        private System.Windows.Forms.Label lblRaportointi;
        private System.Windows.Forms.Button btnMajoittumisraportti;
        private System.Windows.Forms.Button btnLisapalveluraportti;
        private System.Windows.Forms.Label lblMista1;
        private System.Windows.Forms.Label lblMista2;
        private System.Windows.Forms.Label lblMihin2;
        private System.Windows.Forms.Label lblMihin1;
    }
}