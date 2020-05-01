namespace Mokkivaraus
{
    partial class Toimintaalueet
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
            this.dgToimipisteet = new System.Windows.Forms.DataGridView();
            this.lblToimipisteet = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblToimipisteenNimi = new System.Windows.Forms.Label();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.lblPtpaikka = new System.Windows.Forms.Label();
            this.txtToimipID = new System.Windows.Forms.TextBox();
            this.txtToimipPosti = new System.Windows.Forms.TextBox();
            this.txtToimipOsoite = new System.Windows.Forms.TextBox();
            this.txtToimipNimi = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnNayta = new System.Windows.Forms.Button();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgToimipisteet
            // 
            this.dgToimipisteet.AllowUserToAddRows = false;
            this.dgToimipisteet.AllowUserToDeleteRows = false;
            this.dgToimipisteet.AllowUserToResizeColumns = false;
            this.dgToimipisteet.AllowUserToResizeRows = false;
            this.dgToimipisteet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgToimipisteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToimipisteet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgToimipisteet.Location = new System.Drawing.Point(270, 12);
            this.dgToimipisteet.MultiSelect = false;
            this.dgToimipisteet.Name = "dgToimipisteet";
            this.dgToimipisteet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgToimipisteet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgToimipisteet.Size = new System.Drawing.Size(518, 426);
            this.dgToimipisteet.TabIndex = 0;
            // 
            // lblToimipisteet
            // 
            this.lblToimipisteet.AutoSize = true;
            this.lblToimipisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToimipisteet.Location = new System.Drawing.Point(13, 69);
            this.lblToimipisteet.Name = "lblToimipisteet";
            this.lblToimipisteet.Size = new System.Drawing.Size(161, 31);
            this.lblToimipisteet.TabIndex = 1;
            this.lblToimipisteet.Text = "Toimipisteet";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 7);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Toimipiste ID";
            // 
            // lblToimipisteenNimi
            // 
            this.lblToimipisteenNimi.AutoSize = true;
            this.lblToimipisteenNimi.Location = new System.Drawing.Point(3, 46);
            this.lblToimipisteenNimi.Name = "lblToimipisteenNimi";
            this.lblToimipisteenNimi.Size = new System.Drawing.Size(87, 13);
            this.lblToimipisteenNimi.TabIndex = 3;
            this.lblToimipisteenNimi.Text = "Toimipisteen nimi";
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Location = new System.Drawing.Point(3, 85);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(55, 13);
            this.lblLahiosoite.TabIndex = 4;
            this.lblLahiosoite.Text = "Lähiosoite";
            // 
            // lblPtpaikka
            // 
            this.lblPtpaikka.AutoSize = true;
            this.lblPtpaikka.Location = new System.Drawing.Point(3, 124);
            this.lblPtpaikka.Name = "lblPtpaikka";
            this.lblPtpaikka.Size = new System.Drawing.Size(83, 13);
            this.lblPtpaikka.TabIndex = 5;
            this.lblPtpaikka.Text = "Postitoimipaikka";
            // 
            // txtToimipID
            // 
            this.txtToimipID.Location = new System.Drawing.Point(6, 23);
            this.txtToimipID.Name = "txtToimipID";
            this.txtToimipID.Size = new System.Drawing.Size(100, 20);
            this.txtToimipID.TabIndex = 6;
            // 
            // txtToimipPosti
            // 
            this.txtToimipPosti.Location = new System.Drawing.Point(6, 140);
            this.txtToimipPosti.Name = "txtToimipPosti";
            this.txtToimipPosti.Size = new System.Drawing.Size(100, 20);
            this.txtToimipPosti.TabIndex = 7;
            // 
            // txtToimipOsoite
            // 
            this.txtToimipOsoite.Location = new System.Drawing.Point(6, 101);
            this.txtToimipOsoite.Name = "txtToimipOsoite";
            this.txtToimipOsoite.Size = new System.Drawing.Size(100, 20);
            this.txtToimipOsoite.TabIndex = 8;
            // 
            // txtToimipNimi
            // 
            this.txtToimipNimi.Location = new System.Drawing.Point(6, 62);
            this.txtToimipNimi.Name = "txtToimipNimi";
            this.txtToimipNimi.Size = new System.Drawing.Size(100, 20);
            this.txtToimipNimi.TabIndex = 9;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(12, 289);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(123, 51);
            this.btnLisaa.TabIndex = 10;
            this.btnLisaa.Text = "Lisää/Päivitä";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnNayta
            // 
            this.btnNayta.Location = new System.Drawing.Point(141, 289);
            this.btnNayta.Name = "btnNayta";
            this.btnNayta.Size = new System.Drawing.Size(123, 51);
            this.btnNayta.TabIndex = 11;
            this.btnNayta.Text = "Näytä kohteet";
            this.btnNayta.UseVisualStyleBackColor = true;
            this.btnNayta.Click += new System.EventHandler(this.btnNayta_Click);
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(142, 12);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(122, 38);
            this.btnTakaisin.TabIndex = 12;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtToimipID);
            this.panel1.Controls.Add(this.lblToimipisteenNimi);
            this.panel1.Controls.Add(this.txtToimipNimi);
            this.panel1.Controls.Add(this.txtToimipPosti);
            this.panel1.Controls.Add(this.txtToimipOsoite);
            this.panel1.Controls.Add(this.lblPtpaikka);
            this.panel1.Controls.Add(this.lblLahiosoite);
            this.panel1.Location = new System.Drawing.Point(19, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 166);
            this.panel1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(289, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 166);
            this.panel2.TabIndex = 15;
            // 
            // Toimintaalueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.btnNayta);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.lblToimipisteet);
            this.Controls.Add(this.dgToimipisteet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Toimintaalueet";
            this.Text = "Toiminta-alue hallinta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Toimipisteet_FormClosed);
            this.Load += new System.EventHandler(this.Toimintaalueet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgToimipisteet;
        private System.Windows.Forms.Label lblToimipisteet;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblToimipisteenNimi;
        private System.Windows.Forms.Label lblLahiosoite;
        private System.Windows.Forms.Label lblPtpaikka;
        private System.Windows.Forms.TextBox txtToimipID;
        private System.Windows.Forms.TextBox txtToimipPosti;
        private System.Windows.Forms.TextBox txtToimipOsoite;
        private System.Windows.Forms.TextBox txtToimipNimi;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnNayta;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
    }
}