using System.Windows.Forms;

namespace Mokkivaraus
{
    partial class Aloitussivu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aloitussivu));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAloitussivu = new System.Windows.Forms.TabPage();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.btnLaskutus = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnToimintaalue = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabToimintaalue = new System.Windows.Forms.TabPage();
            this.btnPoista = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVarustelu = new System.Windows.Forms.TextBox();
            this.txtHloMaara = new System.Windows.Forms.TextBox();
            this.txtKuvaus = new System.Windows.Forms.TextBox();
            this.txtKatuosoite = new System.Windows.Forms.TextBox();
            this.txtMokinnimi = new System.Windows.Forms.TextBox();
            this.txtPostinro = new System.Windows.Forms.TextBox();
            this.txtToimiID = new System.Windows.Forms.TextBox();
            this.txtMokkiID = new System.Windows.Forms.TextBox();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblHloMaara = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblPostinro = new System.Windows.Forms.Label();
            this.lblToimiaID = new System.Windows.Forms.Label();
            this.lblMokkiID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtToimialueennimi = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.btnNayta = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lblToimipisteet = new System.Windows.Forms.Label();
            this.dgToimipisteet = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabAsiakashallinta = new System.Windows.Forms.TabPage();
            this.tabVaraushallinta = new System.Windows.Forms.TabPage();
            this.tabLaskutus = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabAloitussivu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.tabToimintaalue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAloitussivu);
            this.tabControl.Controls.Add(this.tabToimintaalue);
            this.tabControl.Controls.Add(this.tabAsiakashallinta);
            this.tabControl.Controls.Add(this.tabVaraushallinta);
            this.tabControl.Controls.Add(this.tabLaskutus);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1147, 751);
            this.tabControl.TabIndex = 0;
            // 
            // tabAloitussivu
            // 
            this.tabAloitussivu.BackColor = System.Drawing.Color.Linen;
            this.tabAloitussivu.Controls.Add(this.pboxLogo);
            this.tabAloitussivu.Controls.Add(this.btnLaskutus);
            this.tabAloitussivu.Controls.Add(this.btnAsiakkaat);
            this.tabAloitussivu.Controls.Add(this.btnVaraukset);
            this.tabAloitussivu.Controls.Add(this.btnToimintaalue);
            this.tabAloitussivu.Controls.Add(this.lblTitle);
            this.tabAloitussivu.Location = new System.Drawing.Point(4, 25);
            this.tabAloitussivu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAloitussivu.Name = "tabAloitussivu";
            this.tabAloitussivu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAloitussivu.Size = new System.Drawing.Size(1139, 722);
            this.tabAloitussivu.TabIndex = 0;
            this.tabAloitussivu.Text = "Aloitussivu";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pboxLogo.Image = global::Mokkivaraus.Properties.Resources.logo;
            this.pboxLogo.Location = new System.Drawing.Point(498, 175);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(180, 158);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 8;
            this.pboxLogo.TabStop = false;
            // 
            // btnLaskutus
            // 
            this.btnLaskutus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLaskutus.BackColor = System.Drawing.Color.Firebrick;
            this.btnLaskutus.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnLaskutus.FlatAppearance.BorderSize = 3;
            this.btnLaskutus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLaskutus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaskutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaskutus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaskutus.ForeColor = System.Drawing.Color.White;
            this.btnLaskutus.Location = new System.Drawing.Point(388, 528);
            this.btnLaskutus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaskutus.Name = "btnLaskutus";
            this.btnLaskutus.Size = new System.Drawing.Size(381, 55);
            this.btnLaskutus.TabIndex = 4;
            this.btnLaskutus.Text = "Laskutus";
            this.btnLaskutus.UseVisualStyleBackColor = false;
            this.btnLaskutus.Click += new System.EventHandler(this.btnLaskutus_Click);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsiakkaat.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsiakkaat.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAsiakkaat.FlatAppearance.BorderSize = 3;
            this.btnAsiakkaat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAsiakkaat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsiakkaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiakkaat.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakkaat.ForeColor = System.Drawing.Color.White;
            this.btnAsiakkaat.Location = new System.Drawing.Point(388, 402);
            this.btnAsiakkaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(381, 55);
            this.btnAsiakkaat.TabIndex = 5;
            this.btnAsiakkaat.Text = "Asiakashallinta";
            this.btnAsiakkaat.UseVisualStyleBackColor = false;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAsiakkaat_Click);
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVaraukset.BackColor = System.Drawing.Color.Firebrick;
            this.btnVaraukset.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnVaraukset.FlatAppearance.BorderSize = 3;
            this.btnVaraukset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVaraukset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaraukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaraukset.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaraukset.ForeColor = System.Drawing.Color.White;
            this.btnVaraukset.Location = new System.Drawing.Point(388, 465);
            this.btnVaraukset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Size = new System.Drawing.Size(381, 55);
            this.btnVaraukset.TabIndex = 6;
            this.btnVaraukset.Text = "Varaushallinta";
            this.btnVaraukset.UseVisualStyleBackColor = false;
            this.btnVaraukset.Click += new System.EventHandler(this.btnVaraukset_Click);
            // 
            // btnToimintaalue
            // 
            this.btnToimintaalue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToimintaalue.BackColor = System.Drawing.Color.Firebrick;
            this.btnToimintaalue.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnToimintaalue.FlatAppearance.BorderSize = 3;
            this.btnToimintaalue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnToimintaalue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToimintaalue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToimintaalue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToimintaalue.ForeColor = System.Drawing.Color.White;
            this.btnToimintaalue.Location = new System.Drawing.Point(388, 340);
            this.btnToimintaalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToimintaalue.Name = "btnToimintaalue";
            this.btnToimintaalue.Size = new System.Drawing.Size(381, 55);
            this.btnToimintaalue.TabIndex = 7;
            this.btnToimintaalue.Text = "Toiminta-alueiden hallinta";
            this.btnToimintaalue.UseVisualStyleBackColor = false;
            this.btnToimintaalue.Click += new System.EventHandler(this.btnToimintaalue_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Freestyle Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(410, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 118);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Village People Oy \r\nMökkivarausjärjestelmä";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabToimintaalue
            // 
            this.tabToimintaalue.BackColor = System.Drawing.Color.Linen;
            this.tabToimintaalue.Controls.Add(this.btnPoista);
            this.tabToimintaalue.Controls.Add(this.panel2);
            this.tabToimintaalue.Controls.Add(this.panel1);
            this.tabToimintaalue.Controls.Add(this.btnTakaisin);
            this.tabToimintaalue.Controls.Add(this.btnNayta);
            this.tabToimintaalue.Controls.Add(this.btnLisaa);
            this.tabToimintaalue.Controls.Add(this.lblToimipisteet);
            this.tabToimintaalue.Controls.Add(this.dgToimipisteet);
            this.tabToimintaalue.Controls.Add(this.menuStrip1);
            this.tabToimintaalue.Location = new System.Drawing.Point(4, 25);
            this.tabToimintaalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabToimintaalue.Name = "tabToimintaalue";
            this.tabToimintaalue.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabToimintaalue.Size = new System.Drawing.Size(1149, 725);
            this.tabToimintaalue.TabIndex = 1;
            this.tabToimintaalue.Text = "Toiminta-alueiden hallinta";
            this.tabToimintaalue.Enter += new System.EventHandler(this.tabToimintaalue_Enter);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(16, 633);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(163, 66);
            this.btnPoista.TabIndex = 24;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.txtVarustelu);
            this.panel2.Controls.Add(this.txtHloMaara);
            this.panel2.Controls.Add(this.txtKuvaus);
            this.panel2.Controls.Add(this.txtKatuosoite);
            this.panel2.Controls.Add(this.txtMokinnimi);
            this.panel2.Controls.Add(this.txtPostinro);
            this.panel2.Controls.Add(this.txtToimiID);
            this.panel2.Controls.Add(this.txtMokkiID);
            this.panel2.Controls.Add(this.lblVarustelu);
            this.panel2.Controls.Add(this.lblHloMaara);
            this.panel2.Controls.Add(this.lblKuvaus);
            this.panel2.Controls.Add(this.lblKatuosoite);
            this.panel2.Controls.Add(this.lblMokkinimi);
            this.panel2.Controls.Add(this.lblPostinro);
            this.panel2.Controls.Add(this.lblToimiaID);
            this.panel2.Controls.Add(this.lblMokkiID);
            this.panel2.Location = new System.Drawing.Point(380, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 358);
            this.panel2.TabIndex = 23;
            // 
            // txtVarustelu
            // 
            this.txtVarustelu.Location = new System.Drawing.Point(9, 367);
            this.txtVarustelu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVarustelu.Name = "txtVarustelu";
            this.txtVarustelu.Size = new System.Drawing.Size(132, 22);
            this.txtVarustelu.TabIndex = 15;
            // 
            // txtHloMaara
            // 
            this.txtHloMaara.Location = new System.Drawing.Point(9, 318);
            this.txtHloMaara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHloMaara.Name = "txtHloMaara";
            this.txtHloMaara.Size = new System.Drawing.Size(132, 22);
            this.txtHloMaara.TabIndex = 14;
            // 
            // txtKuvaus
            // 
            this.txtKuvaus.Location = new System.Drawing.Point(9, 270);
            this.txtKuvaus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKuvaus.Name = "txtKuvaus";
            this.txtKuvaus.Size = new System.Drawing.Size(132, 22);
            this.txtKuvaus.TabIndex = 13;
            // 
            // txtKatuosoite
            // 
            this.txtKatuosoite.Location = new System.Drawing.Point(9, 222);
            this.txtKatuosoite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKatuosoite.Name = "txtKatuosoite";
            this.txtKatuosoite.Size = new System.Drawing.Size(132, 22);
            this.txtKatuosoite.TabIndex = 12;
            // 
            // txtMokinnimi
            // 
            this.txtMokinnimi.Location = new System.Drawing.Point(9, 174);
            this.txtMokinnimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMokinnimi.Name = "txtMokinnimi";
            this.txtMokinnimi.Size = new System.Drawing.Size(132, 22);
            this.txtMokinnimi.TabIndex = 11;
            // 
            // txtPostinro
            // 
            this.txtPostinro.Location = new System.Drawing.Point(9, 126);
            this.txtPostinro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPostinro.Name = "txtPostinro";
            this.txtPostinro.Size = new System.Drawing.Size(132, 22);
            this.txtPostinro.TabIndex = 10;
            // 
            // txtToimiID
            // 
            this.txtToimiID.Location = new System.Drawing.Point(9, 78);
            this.txtToimiID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToimiID.Name = "txtToimiID";
            this.txtToimiID.Size = new System.Drawing.Size(132, 22);
            this.txtToimiID.TabIndex = 9;
            // 
            // txtMokkiID
            // 
            this.txtMokkiID.Location = new System.Drawing.Point(9, 26);
            this.txtMokkiID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMokkiID.Name = "txtMokkiID";
            this.txtMokkiID.Size = new System.Drawing.Size(132, 22);
            this.txtMokkiID.TabIndex = 8;
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(5, 346);
            this.lblVarustelu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(68, 17);
            this.lblVarustelu.TabIndex = 7;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblHloMaara
            // 
            this.lblHloMaara.AutoSize = true;
            this.lblHloMaara.Location = new System.Drawing.Point(5, 298);
            this.lblHloMaara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHloMaara.Name = "lblHloMaara";
            this.lblHloMaara.Size = new System.Drawing.Size(95, 17);
            this.lblHloMaara.TabIndex = 6;
            this.lblHloMaara.Text = "Henkilömäärä";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(5, 250);
            this.lblKuvaus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(55, 17);
            this.lblKuvaus.TabIndex = 5;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(5, 202);
            this.lblKatuosoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(75, 17);
            this.lblKatuosoite.TabIndex = 4;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(5, 154);
            this.lblMokkinimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(74, 17);
            this.lblMokkinimi.TabIndex = 3;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // lblPostinro
            // 
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Location = new System.Drawing.Point(5, 106);
            this.lblPostinro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(87, 17);
            this.lblPostinro.TabIndex = 2;
            this.lblPostinro.Text = "Postinumero";
            // 
            // lblToimiaID
            // 
            this.lblToimiaID.AutoSize = true;
            this.lblToimiaID.Location = new System.Drawing.Point(5, 54);
            this.lblToimiaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToimiaID.Name = "lblToimiaID";
            this.lblToimiaID.Size = new System.Drawing.Size(86, 17);
            this.lblToimiaID.TabIndex = 1;
            this.lblToimiaID.Text = "Toimialue ID";
            // 
            // lblMokkiID
            // 
            this.lblMokkiID.AutoSize = true;
            this.lblMokkiID.Location = new System.Drawing.Point(5, 9);
            this.lblMokkiID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMokkiID.Name = "lblMokkiID";
            this.lblMokkiID.Size = new System.Drawing.Size(61, 17);
            this.lblMokkiID.TabIndex = 0;
            this.lblMokkiID.Text = "Mökki ID";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtToimialueennimi);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(25, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 358);
            this.panel1.TabIndex = 21;
            // 
            // txtToimialueennimi
            // 
            this.txtToimialueennimi.Location = new System.Drawing.Point(8, 30);
            this.txtToimialueennimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToimialueennimi.Name = "txtToimialueennimi";
            this.txtToimialueennimi.Size = new System.Drawing.Size(251, 22);
            this.txtToimialueennimi.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 9);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 17);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Toiminta-alue ID";
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(189, 105);
            this.btnTakaisin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(163, 47);
            this.btnTakaisin.TabIndex = 20;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // btnNayta
            // 
            this.btnNayta.Location = new System.Drawing.Point(188, 562);
            this.btnNayta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNayta.Name = "btnNayta";
            this.btnNayta.Size = new System.Drawing.Size(164, 63);
            this.btnNayta.TabIndex = 19;
            this.btnNayta.Text = "Näytä kohteet";
            this.btnNayta.UseVisualStyleBackColor = true;
            this.btnNayta.Click += new System.EventHandler(this.btnNayta_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(16, 562);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(164, 63);
            this.btnLisaa.TabIndex = 18;
            this.btnLisaa.Text = "Lisää/Päivitä";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lblToimipisteet
            // 
            this.lblToimipisteet.AutoSize = true;
            this.lblToimipisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToimipisteet.Location = new System.Drawing.Point(17, 155);
            this.lblToimipisteet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToimipisteet.Name = "lblToimipisteet";
            this.lblToimipisteet.Size = new System.Drawing.Size(252, 39);
            this.lblToimipisteet.TabIndex = 17;
            this.lblToimipisteet.Text = "Toiminta-alueet";
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
            this.dgToimipisteet.Location = new System.Drawing.Point(360, 105);
            this.dgToimipisteet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgToimipisteet.MultiSelect = false;
            this.dgToimipisteet.Name = "dgToimipisteet";
            this.dgToimipisteet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgToimipisteet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgToimipisteet.Size = new System.Drawing.Size(691, 524);
            this.dgToimipisteet.TabIndex = 16;
            this.dgToimipisteet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgToimipisteet_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(4, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabAsiakashallinta
            // 
            this.tabAsiakashallinta.BackColor = System.Drawing.Color.Linen;
            this.tabAsiakashallinta.Location = new System.Drawing.Point(4, 25);
            this.tabAsiakashallinta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAsiakashallinta.Name = "tabAsiakashallinta";
            this.tabAsiakashallinta.Size = new System.Drawing.Size(1149, 725);
            this.tabAsiakashallinta.TabIndex = 2;
            this.tabAsiakashallinta.Text = "Asiakashallinta";
            // 
            // tabVaraushallinta
            // 
            this.tabVaraushallinta.BackColor = System.Drawing.Color.Linen;
            this.tabVaraushallinta.Location = new System.Drawing.Point(4, 25);
            this.tabVaraushallinta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabVaraushallinta.Name = "tabVaraushallinta";
            this.tabVaraushallinta.Size = new System.Drawing.Size(1149, 725);
            this.tabVaraushallinta.TabIndex = 3;
            this.tabVaraushallinta.Text = "Varaushallinta";
            // 
            // tabLaskutus
            // 
            this.tabLaskutus.BackColor = System.Drawing.Color.Linen;
            this.tabLaskutus.Location = new System.Drawing.Point(4, 25);
            this.tabLaskutus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLaskutus.Name = "tabLaskutus";
            this.tabLaskutus.Size = new System.Drawing.Size(1149, 725);
            this.tabLaskutus.TabIndex = 4;
            this.tabLaskutus.Text = "Laskutus";
            // 
            // Aloitussivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1147, 751);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(861, 666);
            this.Name = "Aloitussivu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village People Oy Mökkivarausjärjestelmä";
            this.tabControl.ResumeLayout(false);
            this.tabAloitussivu.ResumeLayout(false);
            this.tabAloitussivu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.tabToimintaalue.ResumeLayout(false);
            this.tabToimintaalue.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAloitussivu;
        private System.Windows.Forms.TabPage tabToimintaalue;
        private PictureBox pboxLogo;
        private Button btnAsiakkaat;
        private Button btnVaraukset;
        private Button btnToimintaalue;
        private Label lblTitle;
        private TabPage tabAsiakashallinta;
        private TabPage tabVaraushallinta;
        private TabPage tabLaskutus;
        private Button btnLaskutus;
        private Panel panel2;
        private Panel panel1;
        private Label lblID;
        private Button btnTakaisin;
        private Button btnNayta;
        private Button btnLisaa;
        private Label lblToimipisteet;
        private DataGridView dgToimipisteet;
        private MenuStrip menuStrip1;
        private TextBox txtToimialueennimi;
        private TextBox txtVarustelu;
        private TextBox txtHloMaara;
        private TextBox txtKuvaus;
        private TextBox txtKatuosoite;
        private TextBox txtMokinnimi;
        private TextBox txtPostinro;
        private TextBox txtToimiID;
        private TextBox txtMokkiID;
        private Label lblVarustelu;
        private Label lblHloMaara;
        private Label lblKuvaus;
        private Label lblKatuosoite;
        private Label lblMokkinimi;
        private Label lblPostinro;
        private Label lblToimiaID;
        private Label lblMokkiID;
        private Button btnPoista;
    }
}

