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
            this.lblError = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVarustelu = new System.Windows.Forms.TextBox();
            this.txtHloMaara = new System.Windows.Forms.TextBox();
            this.txtKuvaus = new System.Windows.Forms.TextBox();
            this.txtKatuosoite = new System.Windows.Forms.TextBox();
            this.txtMokinnimi = new System.Windows.Forms.TextBox();
            this.txtPostinro = new System.Windows.Forms.TextBox();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblHloMaara = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblPostinro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToimialueennimi = new System.Windows.Forms.Label();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.btnNayta = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lblToimipisteet = new System.Windows.Forms.Label();
            this.dgToimipisteet = new System.Windows.Forms.DataGridView();
            this.tabAsiakashallinta = new System.Windows.Forms.TabPage();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPuhelinAsiakas = new System.Windows.Forms.TextBox();
            this.lblPuhelinAsiakas = new System.Windows.Forms.Label();
            this.txtEmailAsiakas = new System.Windows.Forms.TextBox();
            this.lblEmailAsiakas = new System.Windows.Forms.Label();
            this.txtOsoiteAsiakas = new System.Windows.Forms.TextBox();
            this.lblOsoiteAsiakas = new System.Windows.Forms.Label();
            this.txtSukunimiAsiakas = new System.Windows.Forms.TextBox();
            this.lblSukunimiAsiakas = new System.Windows.Forms.Label();
            this.txtEtunimiAsiakas = new System.Windows.Forms.TextBox();
            this.lblEtunimiAsiakas = new System.Windows.Forms.Label();
            this.txtPostinroAsiakas = new System.Windows.Forms.TextBox();
            this.lblPostinroAsiakas = new System.Windows.Forms.Label();
            this.txtAsiakasId = new System.Windows.Forms.TextBox();
            this.lblAsiakasId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNaytaAsiakkaat = new System.Windows.Forms.Button();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.lblAsiakkaat = new System.Windows.Forms.Label();
            this.dgAsiakkaat = new System.Windows.Forms.DataGridView();
            this.tabVaraushallinta = new System.Windows.Forms.TabPage();
            this.tabLaskutus = new System.Windows.Forms.TabPage();
            this.dgLaskutus = new System.Windows.Forms.DataGridView();
            this.btnJoonas = new System.Windows.Forms.Button();
            this.lblToimialueNimi = new System.Windows.Forms.Label();
            this.dgMokit = new System.Windows.Forms.DataGridView();
            this.txtToimialueennimi = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabAloitussivu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.tabToimintaalue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).BeginInit();
            this.tabAsiakashallinta.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakkaat)).BeginInit();
            this.tabLaskutus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLaskutus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokit)).BeginInit();
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
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 610);
            this.tabControl.TabIndex = 0;
            this.tabControl.Enter += new System.EventHandler(this.tabControl_Enter);
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
            this.tabAloitussivu.Location = new System.Drawing.Point(4, 22);
            this.tabAloitussivu.Name = "tabAloitussivu";
            this.tabAloitussivu.Padding = new System.Windows.Forms.Padding(3);
            this.tabAloitussivu.Size = new System.Drawing.Size(852, 584);
            this.tabAloitussivu.TabIndex = 0;
            this.tabAloitussivu.Text = "Aloitussivu";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pboxLogo.Image = global::Mokkivaraus.Properties.Resources.logo;
            this.pboxLogo.Location = new System.Drawing.Point(374, 142);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(135, 128);
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
            this.btnLaskutus.Location = new System.Drawing.Point(291, 429);
            this.btnLaskutus.Name = "btnLaskutus";
            this.btnLaskutus.Size = new System.Drawing.Size(286, 45);
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
            this.btnAsiakkaat.Location = new System.Drawing.Point(291, 327);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(286, 45);
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
            this.btnVaraukset.Location = new System.Drawing.Point(291, 378);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Size = new System.Drawing.Size(286, 45);
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
            this.btnToimintaalue.Location = new System.Drawing.Point(291, 276);
            this.btnToimintaalue.Name = "btnToimintaalue";
            this.btnToimintaalue.Size = new System.Drawing.Size(286, 45);
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
            this.lblTitle.Location = new System.Drawing.Point(308, 45);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 94);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Village People Oy \r\nMökkivarausjärjestelmä";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabToimintaalue
            // 
            this.tabToimintaalue.BackColor = System.Drawing.Color.Linen;
            this.tabToimintaalue.Controls.Add(this.lblError);
            this.tabToimintaalue.Controls.Add(this.btnPoista);
            this.tabToimintaalue.Controls.Add(this.panel2);
            this.tabToimintaalue.Controls.Add(this.panel1);
            this.tabToimintaalue.Controls.Add(this.btnTakaisin);
            this.tabToimintaalue.Controls.Add(this.btnNayta);
            this.tabToimintaalue.Controls.Add(this.btnLisaa);
            this.tabToimintaalue.Controls.Add(this.lblToimipisteet);
            this.tabToimintaalue.Controls.Add(this.dgToimipisteet);
            this.tabToimintaalue.Location = new System.Drawing.Point(4, 22);
            this.tabToimintaalue.Name = "tabToimintaalue";
            this.tabToimintaalue.Padding = new System.Windows.Forms.Padding(3);
            this.tabToimintaalue.Size = new System.Drawing.Size(852, 584);
            this.tabToimintaalue.TabIndex = 1;
            this.tabToimintaalue.Text = "Toiminta-alueiden hallinta";
            this.tabToimintaalue.Enter += new System.EventHandler(this.tabToimintaalue_Enter);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(391, 44);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 22);
            this.lblError.TabIndex = 25;
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoista.Location = new System.Drawing.Point(12, 514);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(122, 54);
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
            this.panel2.Controls.Add(this.lblVarustelu);
            this.panel2.Controls.Add(this.lblHloMaara);
            this.panel2.Controls.Add(this.lblKuvaus);
            this.panel2.Controls.Add(this.lblKatuosoite);
            this.panel2.Controls.Add(this.lblMokkinimi);
            this.panel2.Controls.Add(this.lblPostinro);
            this.panel2.Location = new System.Drawing.Point(285, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 291);
            this.panel2.TabIndex = 23;
            // 
            // txtVarustelu
            // 
            this.txtVarustelu.Location = new System.Drawing.Point(6, 239);
            this.txtVarustelu.Name = "txtVarustelu";
            this.txtVarustelu.Size = new System.Drawing.Size(100, 20);
            this.txtVarustelu.TabIndex = 15;
            // 
            // txtHloMaara
            // 
            this.txtHloMaara.Location = new System.Drawing.Point(6, 199);
            this.txtHloMaara.Name = "txtHloMaara";
            this.txtHloMaara.Size = new System.Drawing.Size(100, 20);
            this.txtHloMaara.TabIndex = 14;
            // 
            // txtKuvaus
            // 
            this.txtKuvaus.Location = new System.Drawing.Point(6, 160);
            this.txtKuvaus.Name = "txtKuvaus";
            this.txtKuvaus.Size = new System.Drawing.Size(100, 20);
            this.txtKuvaus.TabIndex = 13;
            // 
            // txtKatuosoite
            // 
            this.txtKatuosoite.Location = new System.Drawing.Point(6, 121);
            this.txtKatuosoite.Name = "txtKatuosoite";
            this.txtKatuosoite.Size = new System.Drawing.Size(100, 20);
            this.txtKatuosoite.TabIndex = 12;
            // 
            // txtMokinnimi
            // 
            this.txtMokinnimi.Location = new System.Drawing.Point(6, 82);
            this.txtMokinnimi.Name = "txtMokinnimi";
            this.txtMokinnimi.Size = new System.Drawing.Size(100, 20);
            this.txtMokinnimi.TabIndex = 11;
            // 
            // txtPostinro
            // 
            this.txtPostinro.Location = new System.Drawing.Point(6, 43);
            this.txtPostinro.Name = "txtPostinro";
            this.txtPostinro.Size = new System.Drawing.Size(100, 20);
            this.txtPostinro.TabIndex = 10;
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(3, 222);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(51, 13);
            this.lblVarustelu.TabIndex = 7;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblHloMaara
            // 
            this.lblHloMaara.AutoSize = true;
            this.lblHloMaara.Location = new System.Drawing.Point(3, 183);
            this.lblHloMaara.Name = "lblHloMaara";
            this.lblHloMaara.Size = new System.Drawing.Size(72, 13);
            this.lblHloMaara.TabIndex = 6;
            this.lblHloMaara.Text = "Henkilömäärä";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(3, 144);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lblKuvaus.TabIndex = 5;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(3, 105);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(57, 13);
            this.lblKatuosoite.TabIndex = 4;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(3, 66);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(57, 13);
            this.lblMokkinimi.TabIndex = 3;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // lblPostinro
            // 
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Location = new System.Drawing.Point(3, 27);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(65, 13);
            this.lblPostinro.TabIndex = 2;
            this.lblPostinro.Text = "Postinumero";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtToimialueennimi);
            this.panel1.Controls.Add(this.lblToimialueennimi);
            this.panel1.Location = new System.Drawing.Point(19, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 291);
            this.panel1.TabIndex = 21;
            // 
            // lblToimialueennimi
            // 
            this.lblToimialueennimi.AutoSize = true;
            this.lblToimialueennimi.Location = new System.Drawing.Point(6, 4);
            this.lblToimialueennimi.Name = "lblToimialueennimi";
            this.lblToimialueennimi.Size = new System.Drawing.Size(85, 13);
            this.lblToimialueennimi.TabIndex = 4;
            this.lblToimialueennimi.Text = "Toimialueen nimi";
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(142, 85);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(122, 38);
            this.btnTakaisin.TabIndex = 20;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // btnNayta
            // 
            this.btnNayta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNayta.Location = new System.Drawing.Point(141, 457);
            this.btnNayta.Name = "btnNayta";
            this.btnNayta.Size = new System.Drawing.Size(123, 51);
            this.btnNayta.TabIndex = 19;
            this.btnNayta.Text = "Näytä kohteet";
            this.btnNayta.UseVisualStyleBackColor = true;
            this.btnNayta.Click += new System.EventHandler(this.btnNayta_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaa.Location = new System.Drawing.Point(12, 457);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(123, 51);
            this.btnLisaa.TabIndex = 18;
            this.btnLisaa.Text = "Lisää/Päivitä";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lblToimipisteet
            // 
            this.lblToimipisteet.AutoSize = true;
            this.lblToimipisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToimipisteet.Location = new System.Drawing.Point(13, 126);
            this.lblToimipisteet.Name = "lblToimipisteet";
            this.lblToimipisteet.Size = new System.Drawing.Size(201, 31);
            this.lblToimipisteet.TabIndex = 17;
            this.lblToimipisteet.Text = "Toiminta-alueet";
            // 
            // dgToimipisteet
            // 
            this.dgToimipisteet.AllowUserToAddRows = false;
            this.dgToimipisteet.AllowUserToDeleteRows = false;
            this.dgToimipisteet.AllowUserToResizeColumns = false;
            this.dgToimipisteet.AllowUserToResizeRows = false;
            this.dgToimipisteet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgToimipisteet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgToimipisteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToimipisteet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgToimipisteet.Location = new System.Drawing.Point(270, 85);
            this.dgToimipisteet.MultiSelect = false;
            this.dgToimipisteet.Name = "dgToimipisteet";
            this.dgToimipisteet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgToimipisteet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgToimipisteet.Size = new System.Drawing.Size(560, 480);
            this.dgToimipisteet.TabIndex = 16;
            // 
            // tabAsiakashallinta
            // 
            this.tabAsiakashallinta.BackColor = System.Drawing.Color.Linen;
            this.tabAsiakashallinta.Controls.Add(this.btnPoistaAsiakas);
            this.tabAsiakashallinta.Controls.Add(this.panel3);
            this.tabAsiakashallinta.Controls.Add(this.button2);
            this.tabAsiakashallinta.Controls.Add(this.btnNaytaAsiakkaat);
            this.tabAsiakashallinta.Controls.Add(this.btnLisaaAsiakas);
            this.tabAsiakashallinta.Controls.Add(this.lblAsiakkaat);
            this.tabAsiakashallinta.Controls.Add(this.dgAsiakkaat);
            this.tabAsiakashallinta.Location = new System.Drawing.Point(4, 22);
            this.tabAsiakashallinta.Name = "tabAsiakashallinta";
            this.tabAsiakashallinta.Size = new System.Drawing.Size(852, 584);
            this.tabAsiakashallinta.TabIndex = 2;
            this.tabAsiakashallinta.Text = "Asiakashallinta";
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(10, 514);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(122, 54);
            this.btnPoistaAsiakas.TabIndex = 30;
            this.btnPoistaAsiakas.Text = "Poista";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.txtPuhelinAsiakas);
            this.panel3.Controls.Add(this.lblPuhelinAsiakas);
            this.panel3.Controls.Add(this.txtEmailAsiakas);
            this.panel3.Controls.Add(this.lblEmailAsiakas);
            this.panel3.Controls.Add(this.txtOsoiteAsiakas);
            this.panel3.Controls.Add(this.lblOsoiteAsiakas);
            this.panel3.Controls.Add(this.txtSukunimiAsiakas);
            this.panel3.Controls.Add(this.lblSukunimiAsiakas);
            this.panel3.Controls.Add(this.txtEtunimiAsiakas);
            this.panel3.Controls.Add(this.lblEtunimiAsiakas);
            this.panel3.Controls.Add(this.txtPostinroAsiakas);
            this.panel3.Controls.Add(this.lblPostinroAsiakas);
            this.panel3.Controls.Add(this.txtAsiakasId);
            this.panel3.Controls.Add(this.lblAsiakasId);
            this.panel3.Location = new System.Drawing.Point(17, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 291);
            this.panel3.TabIndex = 29;
            // 
            // txtPuhelinAsiakas
            // 
            this.txtPuhelinAsiakas.Location = new System.Drawing.Point(6, 252);
            this.txtPuhelinAsiakas.Name = "txtPuhelinAsiakas";
            this.txtPuhelinAsiakas.Size = new System.Drawing.Size(189, 20);
            this.txtPuhelinAsiakas.TabIndex = 3;
            this.txtPuhelinAsiakas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsiakasId_KeyPress);
            // 
            // lblPuhelinAsiakas
            // 
            this.lblPuhelinAsiakas.AutoSize = true;
            this.lblPuhelinAsiakas.Location = new System.Drawing.Point(3, 235);
            this.lblPuhelinAsiakas.Name = "lblPuhelinAsiakas";
            this.lblPuhelinAsiakas.Size = new System.Drawing.Size(77, 13);
            this.lblPuhelinAsiakas.TabIndex = 2;
            this.lblPuhelinAsiakas.Text = "Puhelinnumero";
            // 
            // txtEmailAsiakas
            // 
            this.txtEmailAsiakas.Location = new System.Drawing.Point(6, 213);
            this.txtEmailAsiakas.Name = "txtEmailAsiakas";
            this.txtEmailAsiakas.Size = new System.Drawing.Size(189, 20);
            this.txtEmailAsiakas.TabIndex = 3;
            // 
            // lblEmailAsiakas
            // 
            this.lblEmailAsiakas.AutoSize = true;
            this.lblEmailAsiakas.Location = new System.Drawing.Point(3, 196);
            this.lblEmailAsiakas.Name = "lblEmailAsiakas";
            this.lblEmailAsiakas.Size = new System.Drawing.Size(60, 13);
            this.lblEmailAsiakas.TabIndex = 2;
            this.lblEmailAsiakas.Text = "Sähköposti";
            // 
            // txtOsoiteAsiakas
            // 
            this.txtOsoiteAsiakas.Location = new System.Drawing.Point(6, 173);
            this.txtOsoiteAsiakas.Name = "txtOsoiteAsiakas";
            this.txtOsoiteAsiakas.Size = new System.Drawing.Size(189, 20);
            this.txtOsoiteAsiakas.TabIndex = 3;
            // 
            // lblOsoiteAsiakas
            // 
            this.lblOsoiteAsiakas.AutoSize = true;
            this.lblOsoiteAsiakas.Location = new System.Drawing.Point(3, 156);
            this.lblOsoiteAsiakas.Name = "lblOsoiteAsiakas";
            this.lblOsoiteAsiakas.Size = new System.Drawing.Size(55, 13);
            this.lblOsoiteAsiakas.TabIndex = 2;
            this.lblOsoiteAsiakas.Text = "Lähiosoite";
            // 
            // txtSukunimiAsiakas
            // 
            this.txtSukunimiAsiakas.Location = new System.Drawing.Point(6, 135);
            this.txtSukunimiAsiakas.Name = "txtSukunimiAsiakas";
            this.txtSukunimiAsiakas.Size = new System.Drawing.Size(189, 20);
            this.txtSukunimiAsiakas.TabIndex = 3;
            // 
            // lblSukunimiAsiakas
            // 
            this.lblSukunimiAsiakas.AutoSize = true;
            this.lblSukunimiAsiakas.Location = new System.Drawing.Point(3, 118);
            this.lblSukunimiAsiakas.Name = "lblSukunimiAsiakas";
            this.lblSukunimiAsiakas.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimiAsiakas.TabIndex = 2;
            this.lblSukunimiAsiakas.Text = "Sukunimi";
            // 
            // txtEtunimiAsiakas
            // 
            this.txtEtunimiAsiakas.Location = new System.Drawing.Point(6, 97);
            this.txtEtunimiAsiakas.Name = "txtEtunimiAsiakas";
            this.txtEtunimiAsiakas.Size = new System.Drawing.Size(189, 20);
            this.txtEtunimiAsiakas.TabIndex = 3;
            // 
            // lblEtunimiAsiakas
            // 
            this.lblEtunimiAsiakas.AutoSize = true;
            this.lblEtunimiAsiakas.Location = new System.Drawing.Point(3, 80);
            this.lblEtunimiAsiakas.Name = "lblEtunimiAsiakas";
            this.lblEtunimiAsiakas.Size = new System.Drawing.Size(41, 13);
            this.lblEtunimiAsiakas.TabIndex = 2;
            this.lblEtunimiAsiakas.Text = "Etunimi";
            // 
            // txtPostinroAsiakas
            // 
            this.txtPostinroAsiakas.Location = new System.Drawing.Point(6, 57);
            this.txtPostinroAsiakas.Name = "txtPostinroAsiakas";
            this.txtPostinroAsiakas.Size = new System.Drawing.Size(189, 20);
            this.txtPostinroAsiakas.TabIndex = 3;
            this.txtPostinroAsiakas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsiakasId_KeyPress);
            // 
            // lblPostinroAsiakas
            // 
            this.lblPostinroAsiakas.AutoSize = true;
            this.lblPostinroAsiakas.Location = new System.Drawing.Point(3, 40);
            this.lblPostinroAsiakas.Name = "lblPostinroAsiakas";
            this.lblPostinroAsiakas.Size = new System.Drawing.Size(65, 13);
            this.lblPostinroAsiakas.TabIndex = 2;
            this.lblPostinroAsiakas.Text = "Postinumero";
            // 
            // txtAsiakasId
            // 
            this.txtAsiakasId.Location = new System.Drawing.Point(6, 17);
            this.txtAsiakasId.Name = "txtAsiakasId";
            this.txtAsiakasId.Size = new System.Drawing.Size(189, 20);
            this.txtAsiakasId.TabIndex = 3;
            this.txtAsiakasId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsiakasId_KeyPress);
            // 
            // lblAsiakasId
            // 
            this.lblAsiakasId.AutoSize = true;
            this.lblAsiakasId.Location = new System.Drawing.Point(3, 0);
            this.lblAsiakasId.Name = "lblAsiakasId";
            this.lblAsiakasId.Size = new System.Drawing.Size(58, 13);
            this.lblAsiakasId.TabIndex = 2;
            this.lblAsiakasId.Text = "Asiakas ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 38);
            this.button2.TabIndex = 28;
            this.button2.Text = "Takaisin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // btnNaytaAsiakkaat
            // 
            this.btnNaytaAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNaytaAsiakkaat.Location = new System.Drawing.Point(139, 457);
            this.btnNaytaAsiakkaat.Name = "btnNaytaAsiakkaat";
            this.btnNaytaAsiakkaat.Size = new System.Drawing.Size(123, 51);
            this.btnNaytaAsiakkaat.TabIndex = 27;
            this.btnNaytaAsiakkaat.Text = "Näytä laskutukset";
            this.btnNaytaAsiakkaat.UseVisualStyleBackColor = true;
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(10, 457);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(123, 51);
            this.btnLisaaAsiakas.TabIndex = 26;
            this.btnLisaaAsiakas.Text = "Lisää/Päivitä";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = true;
            // 
            // lblAsiakkaat
            // 
            this.lblAsiakkaat.AutoSize = true;
            this.lblAsiakkaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakkaat.Location = new System.Drawing.Point(11, 126);
            this.lblAsiakkaat.Name = "lblAsiakkaat";
            this.lblAsiakkaat.Size = new System.Drawing.Size(133, 31);
            this.lblAsiakkaat.TabIndex = 25;
            this.lblAsiakkaat.Text = "Asiakkaat";
            // 
            // dgAsiakkaat
            // 
            this.dgAsiakkaat.AllowUserToAddRows = false;
            this.dgAsiakkaat.AllowUserToDeleteRows = false;
            this.dgAsiakkaat.AllowUserToResizeColumns = false;
            this.dgAsiakkaat.AllowUserToResizeRows = false;
            this.dgAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsiakkaat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAsiakkaat.Location = new System.Drawing.Point(270, 85);
            this.dgAsiakkaat.MultiSelect = false;
            this.dgAsiakkaat.Name = "dgAsiakkaat";
            this.dgAsiakkaat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgAsiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsiakkaat.Size = new System.Drawing.Size(560, 480);
            this.dgAsiakkaat.TabIndex = 17;
            // 
            // tabVaraushallinta
            // 
            this.tabVaraushallinta.BackColor = System.Drawing.Color.Linen;
            this.tabVaraushallinta.Location = new System.Drawing.Point(4, 22);
            this.tabVaraushallinta.Name = "tabVaraushallinta";
            this.tabVaraushallinta.Size = new System.Drawing.Size(852, 584);
            this.tabVaraushallinta.TabIndex = 3;
            this.tabVaraushallinta.Text = "Varaushallinta";
            // 
            // tabLaskutus
            // 
            this.tabLaskutus.BackColor = System.Drawing.Color.Linen;
            this.tabLaskutus.Controls.Add(this.dgLaskutus);
            this.tabLaskutus.Controls.Add(this.btnJoonas);
            this.tabLaskutus.Location = new System.Drawing.Point(4, 22);
            this.tabLaskutus.Name = "tabLaskutus";
            this.tabLaskutus.Size = new System.Drawing.Size(852, 584);
            this.tabLaskutus.TabIndex = 4;
            this.tabLaskutus.Text = "Laskutus";
            this.tabLaskutus.Enter += new System.EventHandler(this.tabLaskutus_Enter);
            // 
            // dgLaskutus
            // 
            this.dgLaskutus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLaskutus.Location = new System.Drawing.Point(398, 45);
            this.dgLaskutus.Name = "dgLaskutus";
            this.dgLaskutus.Size = new System.Drawing.Size(240, 150);
            this.dgLaskutus.TabIndex = 1;
            // 
            // btnJoonas
            // 
            this.btnJoonas.Location = new System.Drawing.Point(3, 3);
            this.btnJoonas.Name = "btnJoonas";
            this.btnJoonas.Size = new System.Drawing.Size(331, 193);
            this.btnJoonas.TabIndex = 0;
            this.btnJoonas.Text = "Joonaksen nappi";
            this.btnJoonas.UseVisualStyleBackColor = true;
            this.btnJoonas.Click += new System.EventHandler(this.btnJoonas_Click);
            // 
            // lblToimialueNimi
            // 
            this.lblToimialueNimi.Location = new System.Drawing.Point(0, 0);
            this.lblToimialueNimi.Name = "lblToimialueNimi";
            this.lblToimialueNimi.Size = new System.Drawing.Size(100, 23);
            this.lblToimialueNimi.TabIndex = 0;
            // 
            // dgMokit
            // 
            this.dgMokit.AllowUserToAddRows = false;
            this.dgMokit.AllowUserToDeleteRows = false;
            this.dgMokit.AllowUserToResizeColumns = false;
            this.dgMokit.AllowUserToResizeRows = false;
            this.dgMokit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMokit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMokit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMokit.Location = new System.Drawing.Point(270, 85);
            this.dgMokit.MultiSelect = false;
            this.dgMokit.Name = "dgMokit";
            this.dgMokit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgMokit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMokit.Size = new System.Drawing.Size(560, 480);
            this.dgMokit.TabIndex = 16;
            // 
            // txtToimialueennimi
            // 
            this.txtToimialueennimi.Location = new System.Drawing.Point(9, 21);
            this.txtToimialueennimi.Name = "txtToimialueennimi";
            this.txtToimialueennimi.Size = new System.Drawing.Size(139, 20);
            this.txtToimialueennimi.TabIndex = 5;
            // 
            // Aloitussivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(860, 610);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(650, 548);
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
            this.tabAsiakashallinta.ResumeLayout(false);
            this.tabAsiakashallinta.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakkaat)).EndInit();
            this.tabLaskutus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLaskutus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokit)).EndInit();
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
        private Label lblToimialueNimi;
        private Button btnTakaisin;
        private Button btnNayta;
        private Button btnLisaa;
        private Label lblToimipisteet;
        private DataGridView dgToimipisteet;
        private TextBox txtVarustelu;
        private TextBox txtHloMaara;
        private TextBox txtKuvaus;
        private TextBox txtKatuosoite;
        private TextBox txtMokinnimi;
        private TextBox txtPostinro;
        private Label lblVarustelu;
        private Label lblHloMaara;
        private Label lblKuvaus;
        private Label lblKatuosoite;
        private Label lblMokkinimi;
        private Label lblPostinro;
        private Button btnPoista;
        private Label lblError;
        private DataGridView dgAsiakkaat;
        private Button btnPoistaAsiakas;
        private Panel panel3;
        private TextBox txtAsiakasId;
        private Label lblAsiakasId;
        private Button button2;
        private Button btnNaytaAsiakkaat;
        private Button btnLisaaAsiakas;
        private Label lblAsiakkaat;
        private TextBox txtPuhelinAsiakas;
        private Label lblPuhelinAsiakas;
        private TextBox txtEmailAsiakas;
        private Label lblEmailAsiakas;
        private TextBox txtOsoiteAsiakas;
        private Label lblOsoiteAsiakas;
        private TextBox txtSukunimiAsiakas;
        private Label lblSukunimiAsiakas;
        private TextBox txtEtunimiAsiakas;
        private Label lblEtunimiAsiakas;
        private TextBox txtPostinroAsiakas;
        private Label lblPostinroAsiakas;
        private Label lblToimialueennimi;
        private Button btnJoonas;
        private DataGridView dgLaskutus;
        private TextBox txtToimialueennimi;
    }
}

