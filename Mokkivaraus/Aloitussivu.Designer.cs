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
            this.btnPoistaToimialue = new System.Windows.Forms.Button();
            this.btnLisaatoimiP = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.pnlMokit = new System.Windows.Forms.Panel();
            this.txtVarusteluTA = new System.Windows.Forms.TextBox();
            this.txtHloMaaraTA = new System.Windows.Forms.TextBox();
            this.txtKuvausTA = new System.Windows.Forms.TextBox();
            this.txtKatuosoiteTA = new System.Windows.Forms.TextBox();
            this.txtMokinnimiTA = new System.Windows.Forms.TextBox();
            this.txtPostinroTA = new System.Windows.Forms.TextBox();
            this.lblVarusteluTA = new System.Windows.Forms.Label();
            this.lblHloMaaraTA = new System.Windows.Forms.Label();
            this.lblKuvausTA = new System.Windows.Forms.Label();
            this.lblKatuosoiteTA = new System.Windows.Forms.Label();
            this.lblMokkinimiTA = new System.Windows.Forms.Label();
            this.lblPostinroTA = new System.Windows.Forms.Label();
            this.pnlTalueet = new System.Windows.Forms.Panel();
            this.txtToimialueennimi = new System.Windows.Forms.TextBox();
            this.lblToimialueennimi = new System.Windows.Forms.Label();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.btnNayta = new System.Windows.Forms.Button();
            this.btnLisaaMökki = new System.Windows.Forms.Button();
            this.lblToimipisteet = new System.Windows.Forms.Label();
            this.dgToimipisteet = new System.Windows.Forms.DataGridView();
            this.tabAsiakashallinta = new System.Windows.Forms.TabPage();
            this.btnNaytaVarauksetAs = new System.Windows.Forms.Button();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.pnlTextboxesAsiakas = new System.Windows.Forms.Panel();
            this.txtPuhelinAs = new System.Windows.Forms.TextBox();
            this.lblPuhelinAsiakas = new System.Windows.Forms.Label();
            this.txtEmailAs = new System.Windows.Forms.TextBox();
            this.lblEmailAsiakas = new System.Windows.Forms.Label();
            this.txtOsoiteAs = new System.Windows.Forms.TextBox();
            this.lblOsoiteAsiakas = new System.Windows.Forms.Label();
            this.txtSukunimiAs = new System.Windows.Forms.TextBox();
            this.lblSukunimiAsiakas = new System.Windows.Forms.Label();
            this.txtEtunimiAs = new System.Windows.Forms.TextBox();
            this.lblEtunimiAsiakas = new System.Windows.Forms.Label();
            this.txtPostinroAs = new System.Windows.Forms.TextBox();
            this.lblPostinroAsiakas = new System.Windows.Forms.Label();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.lblAsiakkaat = new System.Windows.Forms.Label();
            this.dgAsiakkaat = new System.Windows.Forms.DataGridView();
            this.txtHakuAsiakas = new System.Windows.Forms.TextBox();
            this.lblHakuAsiakas = new System.Windows.Forms.Label();
            this.tabVaraushallinta = new System.Windows.Forms.TabPage();
            this.btnPoistaVaraus = new System.Windows.Forms.Button();
            this.btnLisaaPalveluitaVaraus = new System.Windows.Forms.Button();
            this.btnVahvistaVaraus = new System.Windows.Forms.Button();
            this.btnLisaaVaraus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePaattyyVaraus = new System.Windows.Forms.DateTimePicker();
            this.lblPaattymisPvmVaraus = new System.Windows.Forms.Label();
            this.dateAlkaaVaraus = new System.Windows.Forms.DateTimePicker();
            this.lblAlkuPvmVaraus = new System.Windows.Forms.Label();
            this.dateVarattuVaraus = new System.Windows.Forms.DateTimePicker();
            this.lblVarattuPvVaraus = new System.Windows.Forms.Label();
            this.lblMokkiIdVaraus = new System.Windows.Forms.Label();
            this.cbMokkiIdVaraus = new System.Windows.Forms.ComboBox();
            this.lblAsiakasIdVaraus = new System.Windows.Forms.Label();
            this.cbAsiakasIdVaraus = new System.Windows.Forms.ComboBox();
            this.lblVaraukset = new System.Windows.Forms.Label();
            this.btnTakaisinVaraus = new System.Windows.Forms.Button();
            this.dgVaraukset = new System.Windows.Forms.DataGridView();
            this.tabLaskutus = new System.Windows.Forms.TabPage();
            this.dgLaskut = new System.Windows.Forms.DataGridView();
            this.btnLahetalasku = new System.Windows.Forms.Button();
            this.lblToimialueNimi = new System.Windows.Forms.Label();
            this.dgMokit = new System.Windows.Forms.DataGridView();
            this.btnTulostalasku = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabAloitussivu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.tabToimintaalue.SuspendLayout();
            this.pnlMokit.SuspendLayout();
            this.pnlTalueet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).BeginInit();
            this.tabAsiakashallinta.SuspendLayout();
            this.pnlTextboxesAsiakas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakkaat)).BeginInit();
            this.tabVaraushallinta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaraukset)).BeginInit();
            this.tabLaskutus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLaskut)).BeginInit();
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
            this.tabAloitussivu.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.lblTitle.Text = "Village Newbies Oy \r\nMökkivarausjärjestelmä";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabToimintaalue
            // 
            this.tabToimintaalue.BackColor = System.Drawing.Color.Linen;
            this.tabToimintaalue.Controls.Add(this.btnPoistaToimialue);
            this.tabToimintaalue.Controls.Add(this.btnLisaatoimiP);
            this.tabToimintaalue.Controls.Add(this.lblError);
            this.tabToimintaalue.Controls.Add(this.btnPoista);
            this.tabToimintaalue.Controls.Add(this.pnlMokit);
            this.tabToimintaalue.Controls.Add(this.pnlTalueet);
            this.tabToimintaalue.Controls.Add(this.btnTakaisin);
            this.tabToimintaalue.Controls.Add(this.btnNayta);
            this.tabToimintaalue.Controls.Add(this.btnLisaaMökki);
            this.tabToimintaalue.Controls.Add(this.lblToimipisteet);
            this.tabToimintaalue.Controls.Add(this.dgToimipisteet);
            this.tabToimintaalue.Location = new System.Drawing.Point(4, 22);
            this.tabToimintaalue.Name = "tabToimintaalue";
            this.tabToimintaalue.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabToimintaalue.Size = new System.Drawing.Size(852, 584);
            this.tabToimintaalue.TabIndex = 1;
            this.tabToimintaalue.Text = "Toiminta-alueiden hallinta";
            this.tabToimintaalue.Enter += new System.EventHandler(this.tabToimintaalue_Enter);
            // 
            // btnPoistaToimialue
            // 
            this.btnPoistaToimialue.Location = new System.Drawing.Point(285, 511);
            this.btnPoistaToimialue.Name = "btnPoistaToimialue";
            this.btnPoistaToimialue.Size = new System.Drawing.Size(121, 50);
            this.btnPoistaToimialue.TabIndex = 27;
            this.btnPoistaToimialue.Text = "Poista";
            this.btnPoistaToimialue.UseVisualStyleBackColor = true;
            this.btnPoistaToimialue.Click += new System.EventHandler(this.btnPoistaToimialue_Click);
            // 
            // btnLisaatoimiP
            // 
            this.btnLisaatoimiP.Location = new System.Drawing.Point(12, 458);
            this.btnLisaatoimiP.Name = "btnLisaatoimiP";
            this.btnLisaatoimiP.Size = new System.Drawing.Size(123, 50);
            this.btnLisaatoimiP.TabIndex = 26;
            this.btnLisaatoimiP.Text = "Lisää toiminta-alue";
            this.btnLisaatoimiP.UseVisualStyleBackColor = true;
            this.btnLisaatoimiP.Click += new System.EventHandler(this.btnLisaatoimiP_Click);
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
            this.btnPoista.Location = new System.Drawing.Point(13, 511);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(122, 50);
            this.btnPoista.TabIndex = 24;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // pnlMokit
            // 
            this.pnlMokit.AutoScroll = true;
            this.pnlMokit.Controls.Add(this.txtVarusteluTA);
            this.pnlMokit.Controls.Add(this.txtHloMaaraTA);
            this.pnlMokit.Controls.Add(this.txtKuvausTA);
            this.pnlMokit.Controls.Add(this.txtKatuosoiteTA);
            this.pnlMokit.Controls.Add(this.txtMokinnimiTA);
            this.pnlMokit.Controls.Add(this.txtPostinroTA);
            this.pnlMokit.Controls.Add(this.lblVarusteluTA);
            this.pnlMokit.Controls.Add(this.lblHloMaaraTA);
            this.pnlMokit.Controls.Add(this.lblKuvausTA);
            this.pnlMokit.Controls.Add(this.lblKatuosoiteTA);
            this.pnlMokit.Controls.Add(this.lblMokkinimiTA);
            this.pnlMokit.Controls.Add(this.lblPostinroTA);
            this.pnlMokit.Location = new System.Drawing.Point(285, 160);
            this.pnlMokit.Name = "pnlMokit";
            this.pnlMokit.Size = new System.Drawing.Size(231, 291);
            this.pnlMokit.TabIndex = 23;
            // 
            // txtVarusteluTA
            // 
            this.txtVarusteluTA.Location = new System.Drawing.Point(6, 239);
            this.txtVarusteluTA.Name = "txtVarusteluTA";
            this.txtVarusteluTA.Size = new System.Drawing.Size(140, 20);
            this.txtVarusteluTA.TabIndex = 15;
            // 
            // txtHloMaaraTA
            // 
            this.txtHloMaaraTA.Location = new System.Drawing.Point(6, 199);
            this.txtHloMaaraTA.Name = "txtHloMaaraTA";
            this.txtHloMaaraTA.Size = new System.Drawing.Size(140, 20);
            this.txtHloMaaraTA.TabIndex = 14;
            // 
            // txtKuvausTA
            // 
            this.txtKuvausTA.Location = new System.Drawing.Point(6, 160);
            this.txtKuvausTA.Name = "txtKuvausTA";
            this.txtKuvausTA.Size = new System.Drawing.Size(140, 20);
            this.txtKuvausTA.TabIndex = 13;
            // 
            // txtKatuosoiteTA
            // 
            this.txtKatuosoiteTA.Location = new System.Drawing.Point(6, 121);
            this.txtKatuosoiteTA.Name = "txtKatuosoiteTA";
            this.txtKatuosoiteTA.Size = new System.Drawing.Size(140, 20);
            this.txtKatuosoiteTA.TabIndex = 12;
            // 
            // txtMokinnimiTA
            // 
            this.txtMokinnimiTA.Location = new System.Drawing.Point(6, 82);
            this.txtMokinnimiTA.Name = "txtMokinnimiTA";
            this.txtMokinnimiTA.Size = new System.Drawing.Size(140, 20);
            this.txtMokinnimiTA.TabIndex = 11;
            // 
            // txtPostinroTA
            // 
            this.txtPostinroTA.Location = new System.Drawing.Point(6, 43);
            this.txtPostinroTA.Name = "txtPostinroTA";
            this.txtPostinroTA.Size = new System.Drawing.Size(140, 20);
            this.txtPostinroTA.TabIndex = 10;
            // 
            // lblVarusteluTA
            // 
            this.lblVarusteluTA.AutoSize = true;
            this.lblVarusteluTA.Location = new System.Drawing.Point(3, 222);
            this.lblVarusteluTA.Name = "lblVarusteluTA";
            this.lblVarusteluTA.Size = new System.Drawing.Size(51, 13);
            this.lblVarusteluTA.TabIndex = 7;
            this.lblVarusteluTA.Text = "Varustelu";
            // 
            // lblHloMaaraTA
            // 
            this.lblHloMaaraTA.AutoSize = true;
            this.lblHloMaaraTA.Location = new System.Drawing.Point(3, 183);
            this.lblHloMaaraTA.Name = "lblHloMaaraTA";
            this.lblHloMaaraTA.Size = new System.Drawing.Size(72, 13);
            this.lblHloMaaraTA.TabIndex = 6;
            this.lblHloMaaraTA.Text = "Henkilömäärä";
            // 
            // lblKuvausTA
            // 
            this.lblKuvausTA.AutoSize = true;
            this.lblKuvausTA.Location = new System.Drawing.Point(3, 144);
            this.lblKuvausTA.Name = "lblKuvausTA";
            this.lblKuvausTA.Size = new System.Drawing.Size(43, 13);
            this.lblKuvausTA.TabIndex = 5;
            this.lblKuvausTA.Text = "Kuvaus";
            // 
            // lblKatuosoiteTA
            // 
            this.lblKatuosoiteTA.AutoSize = true;
            this.lblKatuosoiteTA.Location = new System.Drawing.Point(3, 105);
            this.lblKatuosoiteTA.Name = "lblKatuosoiteTA";
            this.lblKatuosoiteTA.Size = new System.Drawing.Size(57, 13);
            this.lblKatuosoiteTA.TabIndex = 4;
            this.lblKatuosoiteTA.Text = "Katuosoite";
            // 
            // lblMokkinimiTA
            // 
            this.lblMokkinimiTA.AutoSize = true;
            this.lblMokkinimiTA.Location = new System.Drawing.Point(3, 66);
            this.lblMokkinimiTA.Name = "lblMokkinimiTA";
            this.lblMokkinimiTA.Size = new System.Drawing.Size(57, 13);
            this.lblMokkinimiTA.TabIndex = 3;
            this.lblMokkinimiTA.Text = "Mökin nimi";
            // 
            // lblPostinroTA
            // 
            this.lblPostinroTA.AutoSize = true;
            this.lblPostinroTA.Location = new System.Drawing.Point(3, 27);
            this.lblPostinroTA.Name = "lblPostinroTA";
            this.lblPostinroTA.Size = new System.Drawing.Size(65, 13);
            this.lblPostinroTA.TabIndex = 2;
            this.lblPostinroTA.Text = "Postinumero";
            // 
            // pnlTalueet
            // 
            this.pnlTalueet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTalueet.AutoScroll = true;
            this.pnlTalueet.Controls.Add(this.txtToimialueennimi);
            this.pnlTalueet.Controls.Add(this.lblToimialueennimi);
            this.pnlTalueet.Location = new System.Drawing.Point(19, 160);
            this.pnlTalueet.Name = "pnlTalueet";
            this.pnlTalueet.Size = new System.Drawing.Size(231, 291);
            this.pnlTalueet.TabIndex = 21;
            // 
            // txtToimialueennimi
            // 
            this.txtToimialueennimi.Location = new System.Drawing.Point(9, 21);
            this.txtToimialueennimi.Name = "txtToimialueennimi";
            this.txtToimialueennimi.Size = new System.Drawing.Size(139, 20);
            this.txtToimialueennimi.TabIndex = 5;
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
            // btnLisaaMökki
            // 
            this.btnLisaaMökki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaMökki.Location = new System.Drawing.Point(283, 454);
            this.btnLisaaMökki.Name = "btnLisaaMökki";
            this.btnLisaaMökki.Size = new System.Drawing.Size(123, 51);
            this.btnLisaaMökki.TabIndex = 18;
            this.btnLisaaMökki.Text = "Lisää mökki";
            this.btnLisaaMökki.UseVisualStyleBackColor = true;
            this.btnLisaaMökki.Click += new System.EventHandler(this.btnLisaa_Click);
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
            this.tabAsiakashallinta.Controls.Add(this.btnNaytaVarauksetAs);
            this.tabAsiakashallinta.Controls.Add(this.btnPoistaAsiakas);
            this.tabAsiakashallinta.Controls.Add(this.pnlTextboxesAsiakas);
            this.tabAsiakashallinta.Controls.Add(this.btnLisaaAsiakas);
            this.tabAsiakashallinta.Controls.Add(this.lblAsiakkaat);
            this.tabAsiakashallinta.Controls.Add(this.dgAsiakkaat);
            this.tabAsiakashallinta.Controls.Add(this.txtHakuAsiakas);
            this.tabAsiakashallinta.Controls.Add(this.lblHakuAsiakas);
            this.tabAsiakashallinta.Location = new System.Drawing.Point(4, 22);
            this.tabAsiakashallinta.Name = "tabAsiakashallinta";
            this.tabAsiakashallinta.Size = new System.Drawing.Size(852, 584);
            this.tabAsiakashallinta.TabIndex = 2;
            this.tabAsiakashallinta.Text = "Asiakashallinta";
            this.tabAsiakashallinta.Enter += new System.EventHandler(this.tabAsiakashallinta_Enter);
            // 
            // btnNaytaVarauksetAs
            // 
            this.btnNaytaVarauksetAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNaytaVarauksetAs.Location = new System.Drawing.Point(139, 457);
            this.btnNaytaVarauksetAs.Name = "btnNaytaVarauksetAs";
            this.btnNaytaVarauksetAs.Size = new System.Drawing.Size(123, 51);
            this.btnNaytaVarauksetAs.TabIndex = 30;
            this.btnNaytaVarauksetAs.Text = "Näytä varaukset";
            this.btnNaytaVarauksetAs.UseVisualStyleBackColor = true;
            this.btnNaytaVarauksetAs.Click += new System.EventHandler(this.btnNaytaVarauksetAs_Click);
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(10, 514);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(122, 51);
            this.btnPoistaAsiakas.TabIndex = 9;
            this.btnPoistaAsiakas.Text = "Poista";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = true;
            this.btnPoistaAsiakas.Click += new System.EventHandler(this.btnPoistaAsiakas_Click);
            // 
            // pnlTextboxesAsiakas
            // 
            this.pnlTextboxesAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTextboxesAsiakas.AutoScroll = true;
            this.pnlTextboxesAsiakas.Controls.Add(this.txtPuhelinAs);
            this.pnlTextboxesAsiakas.Controls.Add(this.lblPuhelinAsiakas);
            this.pnlTextboxesAsiakas.Controls.Add(this.txtEmailAs);
            this.pnlTextboxesAsiakas.Controls.Add(this.lblEmailAsiakas);
            this.pnlTextboxesAsiakas.Controls.Add(this.txtOsoiteAs);
            this.pnlTextboxesAsiakas.Controls.Add(this.lblOsoiteAsiakas);
            this.pnlTextboxesAsiakas.Controls.Add(this.txtSukunimiAs);
            this.pnlTextboxesAsiakas.Controls.Add(this.lblSukunimiAsiakas);
            this.pnlTextboxesAsiakas.Controls.Add(this.txtEtunimiAs);
            this.pnlTextboxesAsiakas.Controls.Add(this.lblEtunimiAsiakas);
            this.pnlTextboxesAsiakas.Controls.Add(this.txtPostinroAs);
            this.pnlTextboxesAsiakas.Controls.Add(this.lblPostinroAsiakas);
            this.pnlTextboxesAsiakas.Location = new System.Drawing.Point(17, 160);
            this.pnlTextboxesAsiakas.Name = "pnlTextboxesAsiakas";
            this.pnlTextboxesAsiakas.Size = new System.Drawing.Size(231, 291);
            this.pnlTextboxesAsiakas.TabIndex = 29;
            // 
            // txtPuhelinAs
            // 
            this.txtPuhelinAs.Location = new System.Drawing.Point(15, 231);
            this.txtPuhelinAs.Name = "txtPuhelinAs";
            this.txtPuhelinAs.Size = new System.Drawing.Size(189, 20);
            this.txtPuhelinAs.TabIndex = 6;
            this.txtPuhelinAs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsiakasId_KeyPress);
            // 
            // lblPuhelinAsiakas
            // 
            this.lblPuhelinAsiakas.AutoSize = true;
            this.lblPuhelinAsiakas.Location = new System.Drawing.Point(12, 214);
            this.lblPuhelinAsiakas.Name = "lblPuhelinAsiakas";
            this.lblPuhelinAsiakas.Size = new System.Drawing.Size(77, 13);
            this.lblPuhelinAsiakas.TabIndex = 2;
            this.lblPuhelinAsiakas.Text = "Puhelinnumero";
            // 
            // txtEmailAs
            // 
            this.txtEmailAs.Location = new System.Drawing.Point(15, 192);
            this.txtEmailAs.Name = "txtEmailAs";
            this.txtEmailAs.Size = new System.Drawing.Size(189, 20);
            this.txtEmailAs.TabIndex = 5;
            // 
            // lblEmailAsiakas
            // 
            this.lblEmailAsiakas.AutoSize = true;
            this.lblEmailAsiakas.Location = new System.Drawing.Point(12, 175);
            this.lblEmailAsiakas.Name = "lblEmailAsiakas";
            this.lblEmailAsiakas.Size = new System.Drawing.Size(60, 13);
            this.lblEmailAsiakas.TabIndex = 2;
            this.lblEmailAsiakas.Text = "Sähköposti";
            // 
            // txtOsoiteAs
            // 
            this.txtOsoiteAs.Location = new System.Drawing.Point(15, 152);
            this.txtOsoiteAs.Name = "txtOsoiteAs";
            this.txtOsoiteAs.Size = new System.Drawing.Size(189, 20);
            this.txtOsoiteAs.TabIndex = 4;
            // 
            // lblOsoiteAsiakas
            // 
            this.lblOsoiteAsiakas.AutoSize = true;
            this.lblOsoiteAsiakas.Location = new System.Drawing.Point(12, 135);
            this.lblOsoiteAsiakas.Name = "lblOsoiteAsiakas";
            this.lblOsoiteAsiakas.Size = new System.Drawing.Size(55, 13);
            this.lblOsoiteAsiakas.TabIndex = 2;
            this.lblOsoiteAsiakas.Text = "Lähiosoite";
            // 
            // txtSukunimiAs
            // 
            this.txtSukunimiAs.Location = new System.Drawing.Point(15, 114);
            this.txtSukunimiAs.Name = "txtSukunimiAs";
            this.txtSukunimiAs.Size = new System.Drawing.Size(189, 20);
            this.txtSukunimiAs.TabIndex = 3;
            // 
            // lblSukunimiAsiakas
            // 
            this.lblSukunimiAsiakas.AutoSize = true;
            this.lblSukunimiAsiakas.Location = new System.Drawing.Point(12, 97);
            this.lblSukunimiAsiakas.Name = "lblSukunimiAsiakas";
            this.lblSukunimiAsiakas.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimiAsiakas.TabIndex = 2;
            this.lblSukunimiAsiakas.Text = "Sukunimi";
            // 
            // txtEtunimiAs
            // 
            this.txtEtunimiAs.Location = new System.Drawing.Point(15, 76);
            this.txtEtunimiAs.Name = "txtEtunimiAs";
            this.txtEtunimiAs.Size = new System.Drawing.Size(189, 20);
            this.txtEtunimiAs.TabIndex = 2;
            // 
            // lblEtunimiAsiakas
            // 
            this.lblEtunimiAsiakas.AutoSize = true;
            this.lblEtunimiAsiakas.Location = new System.Drawing.Point(12, 59);
            this.lblEtunimiAsiakas.Name = "lblEtunimiAsiakas";
            this.lblEtunimiAsiakas.Size = new System.Drawing.Size(41, 13);
            this.lblEtunimiAsiakas.TabIndex = 2;
            this.lblEtunimiAsiakas.Text = "Etunimi";
            // 
            // txtPostinroAs
            // 
            this.txtPostinroAs.Location = new System.Drawing.Point(15, 36);
            this.txtPostinroAs.Name = "txtPostinroAs";
            this.txtPostinroAs.Size = new System.Drawing.Size(189, 20);
            this.txtPostinroAs.TabIndex = 1;
            this.txtPostinroAs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsiakasId_KeyPress);
            // 
            // lblPostinroAsiakas
            // 
            this.lblPostinroAsiakas.AutoSize = true;
            this.lblPostinroAsiakas.Location = new System.Drawing.Point(12, 19);
            this.lblPostinroAsiakas.Name = "lblPostinroAsiakas";
            this.lblPostinroAsiakas.Size = new System.Drawing.Size(65, 13);
            this.lblPostinroAsiakas.TabIndex = 2;
            this.lblPostinroAsiakas.Text = "Postinumero";
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(10, 457);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(123, 51);
            this.btnLisaaAsiakas.TabIndex = 7;
            this.btnLisaaAsiakas.Text = "Lisää";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaAsiakas.Click += new System.EventHandler(this.btnLisaaAsiakas_Click);
            // 
            // lblAsiakkaat
            // 
            this.lblAsiakkaat.AutoSize = true;
            this.lblAsiakkaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakkaat.Location = new System.Drawing.Point(64, 126);
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
            this.dgAsiakkaat.TabIndex = 11;
            // 
            // txtHakuAsiakas
            // 
            this.txtHakuAsiakas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHakuAsiakas.Location = new System.Drawing.Point(435, 59);
            this.txtHakuAsiakas.Name = "txtHakuAsiakas";
            this.txtHakuAsiakas.Size = new System.Drawing.Size(222, 20);
            this.txtHakuAsiakas.TabIndex = 10;
            this.txtHakuAsiakas.TextChanged += new System.EventHandler(this.txtHakuAs_TextChanged);
            // 
            // lblHakuAsiakas
            // 
            this.lblHakuAsiakas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHakuAsiakas.AutoSize = true;
            this.lblHakuAsiakas.Location = new System.Drawing.Point(442, 43);
            this.lblHakuAsiakas.Name = "lblHakuAsiakas";
            this.lblHakuAsiakas.Size = new System.Drawing.Size(30, 13);
            this.lblHakuAsiakas.TabIndex = 2;
            this.lblHakuAsiakas.Text = "Hae:";
            // 
            // tabVaraushallinta
            // 
            this.tabVaraushallinta.BackColor = System.Drawing.Color.Linen;
            this.tabVaraushallinta.Controls.Add(this.btnPoistaVaraus);
            this.tabVaraushallinta.Controls.Add(this.btnLisaaPalveluitaVaraus);
            this.tabVaraushallinta.Controls.Add(this.btnVahvistaVaraus);
            this.tabVaraushallinta.Controls.Add(this.btnLisaaVaraus);
            this.tabVaraushallinta.Controls.Add(this.panel1);
            this.tabVaraushallinta.Controls.Add(this.lblVaraukset);
            this.tabVaraushallinta.Controls.Add(this.btnTakaisinVaraus);
            this.tabVaraushallinta.Controls.Add(this.dgVaraukset);
            this.tabVaraushallinta.Location = new System.Drawing.Point(4, 22);
            this.tabVaraushallinta.Name = "tabVaraushallinta";
            this.tabVaraushallinta.Size = new System.Drawing.Size(852, 584);
            this.tabVaraushallinta.TabIndex = 3;
            this.tabVaraushallinta.Text = "Varaushallinta";
            this.tabVaraushallinta.Enter += new System.EventHandler(this.tabVaraushallinta_Enter);
            // 
            // btnPoistaVaraus
            // 
            this.btnPoistaVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaVaraus.Location = new System.Drawing.Point(140, 489);
            this.btnPoistaVaraus.Name = "btnPoistaVaraus";
            this.btnPoistaVaraus.Size = new System.Drawing.Size(123, 51);
            this.btnPoistaVaraus.TabIndex = 34;
            this.btnPoistaVaraus.Text = "Poista";
            this.btnPoistaVaraus.UseVisualStyleBackColor = true;
            this.btnPoistaVaraus.Click += new System.EventHandler(this.btnPoistaVaraus_Click);
            // 
            // btnLisaaPalveluitaVaraus
            // 
            this.btnLisaaPalveluitaVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaPalveluitaVaraus.Location = new System.Drawing.Point(11, 489);
            this.btnLisaaPalveluitaVaraus.Name = "btnLisaaPalveluitaVaraus";
            this.btnLisaaPalveluitaVaraus.Size = new System.Drawing.Size(123, 51);
            this.btnLisaaPalveluitaVaraus.TabIndex = 34;
            this.btnLisaaPalveluitaVaraus.Text = "Lisää varaukseen palveluita";
            this.btnLisaaPalveluitaVaraus.UseVisualStyleBackColor = true;
            // 
            // btnVahvistaVaraus
            // 
            this.btnVahvistaVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVahvistaVaraus.Location = new System.Drawing.Point(140, 432);
            this.btnVahvistaVaraus.Name = "btnVahvistaVaraus";
            this.btnVahvistaVaraus.Size = new System.Drawing.Size(123, 51);
            this.btnVahvistaVaraus.TabIndex = 34;
            this.btnVahvistaVaraus.Text = "Vahvista varaus";
            this.btnVahvistaVaraus.UseVisualStyleBackColor = true;
            // 
            // btnLisaaVaraus
            // 
            this.btnLisaaVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaVaraus.Location = new System.Drawing.Point(11, 432);
            this.btnLisaaVaraus.Name = "btnLisaaVaraus";
            this.btnLisaaVaraus.Size = new System.Drawing.Size(123, 51);
            this.btnLisaaVaraus.TabIndex = 34;
            this.btnLisaaVaraus.Text = "Lisää varaus";
            this.btnLisaaVaraus.UseVisualStyleBackColor = true;
            this.btnLisaaVaraus.Click += new System.EventHandler(this.btnLisaaVaraus_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.datePaattyyVaraus);
            this.panel1.Controls.Add(this.lblPaattymisPvmVaraus);
            this.panel1.Controls.Add(this.dateAlkaaVaraus);
            this.panel1.Controls.Add(this.lblAlkuPvmVaraus);
            this.panel1.Controls.Add(this.dateVarattuVaraus);
            this.panel1.Controls.Add(this.lblVarattuPvVaraus);
            this.panel1.Controls.Add(this.lblMokkiIdVaraus);
            this.panel1.Controls.Add(this.cbMokkiIdVaraus);
            this.panel1.Controls.Add(this.lblAsiakasIdVaraus);
            this.panel1.Controls.Add(this.cbAsiakasIdVaraus);
            this.panel1.Location = new System.Drawing.Point(11, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 254);
            this.panel1.TabIndex = 33;
            // 
            // datePaattyyVaraus
            // 
            this.datePaattyyVaraus.CustomFormat = "yyyy-MM-dd";
            this.datePaattyyVaraus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePaattyyVaraus.Location = new System.Drawing.Point(14, 189);
            this.datePaattyyVaraus.Name = "datePaattyyVaraus";
            this.datePaattyyVaraus.Size = new System.Drawing.Size(200, 20);
            this.datePaattyyVaraus.TabIndex = 5;
            // 
            // lblPaattymisPvmVaraus
            // 
            this.lblPaattymisPvmVaraus.AutoSize = true;
            this.lblPaattymisPvmVaraus.Location = new System.Drawing.Point(11, 173);
            this.lblPaattymisPvmVaraus.Name = "lblPaattymisPvmVaraus";
            this.lblPaattymisPvmVaraus.Size = new System.Drawing.Size(77, 13);
            this.lblPaattymisPvmVaraus.TabIndex = 4;
            this.lblPaattymisPvmVaraus.Text = "Varaus päättyy";
            // 
            // dateAlkaaVaraus
            // 
            this.dateAlkaaVaraus.CustomFormat = "yyyy-MM-dd";
            this.dateAlkaaVaraus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAlkaaVaraus.Location = new System.Drawing.Point(14, 150);
            this.dateAlkaaVaraus.Name = "dateAlkaaVaraus";
            this.dateAlkaaVaraus.Size = new System.Drawing.Size(200, 20);
            this.dateAlkaaVaraus.TabIndex = 5;
            this.dateAlkaaVaraus.ValueChanged += new System.EventHandler(this.dateAlkaaVaraus_ValueChanged);
            // 
            // lblAlkuPvmVaraus
            // 
            this.lblAlkuPvmVaraus.AutoSize = true;
            this.lblAlkuPvmVaraus.Location = new System.Drawing.Point(11, 134);
            this.lblAlkuPvmVaraus.Name = "lblAlkuPvmVaraus";
            this.lblAlkuPvmVaraus.Size = new System.Drawing.Size(69, 13);
            this.lblAlkuPvmVaraus.TabIndex = 4;
            this.lblAlkuPvmVaraus.Text = "Varaus alkaa";
            // 
            // dateVarattuVaraus
            // 
            this.dateVarattuVaraus.CustomFormat = "yyyy-MM-dd";
            this.dateVarattuVaraus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVarattuVaraus.Location = new System.Drawing.Point(14, 111);
            this.dateVarattuVaraus.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateVarattuVaraus.Name = "dateVarattuVaraus";
            this.dateVarattuVaraus.Size = new System.Drawing.Size(200, 20);
            this.dateVarattuVaraus.TabIndex = 5;
            // 
            // lblVarattuPvVaraus
            // 
            this.lblVarattuPvVaraus.AutoSize = true;
            this.lblVarattuPvVaraus.Location = new System.Drawing.Point(11, 94);
            this.lblVarattuPvVaraus.Name = "lblVarattuPvVaraus";
            this.lblVarattuPvVaraus.Size = new System.Drawing.Size(41, 13);
            this.lblVarattuPvVaraus.TabIndex = 4;
            this.lblVarattuPvVaraus.Text = "Varattu";
            // 
            // lblMokkiIdVaraus
            // 
            this.lblMokkiIdVaraus.AutoSize = true;
            this.lblMokkiIdVaraus.Location = new System.Drawing.Point(11, 54);
            this.lblMokkiIdVaraus.Name = "lblMokkiIdVaraus";
            this.lblMokkiIdVaraus.Size = new System.Drawing.Size(36, 13);
            this.lblMokkiIdVaraus.TabIndex = 4;
            this.lblMokkiIdVaraus.Text = "Mökki";
            // 
            // cbMokkiIdVaraus
            // 
            this.cbMokkiIdVaraus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMokkiIdVaraus.FormattingEnabled = true;
            this.cbMokkiIdVaraus.Location = new System.Drawing.Point(14, 70);
            this.cbMokkiIdVaraus.Name = "cbMokkiIdVaraus";
            this.cbMokkiIdVaraus.Size = new System.Drawing.Size(200, 21);
            this.cbMokkiIdVaraus.Sorted = true;
            this.cbMokkiIdVaraus.TabIndex = 1;
            // 
            // lblAsiakasIdVaraus
            // 
            this.lblAsiakasIdVaraus.AutoSize = true;
            this.lblAsiakasIdVaraus.Location = new System.Drawing.Point(11, 14);
            this.lblAsiakasIdVaraus.Name = "lblAsiakasIdVaraus";
            this.lblAsiakasIdVaraus.Size = new System.Drawing.Size(71, 13);
            this.lblAsiakasIdVaraus.TabIndex = 3;
            this.lblAsiakasIdVaraus.Text = "Asiakkaan ID";
            // 
            // cbAsiakasIdVaraus
            // 
            this.cbAsiakasIdVaraus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsiakasIdVaraus.FormattingEnabled = true;
            this.cbAsiakasIdVaraus.Location = new System.Drawing.Point(14, 30);
            this.cbAsiakasIdVaraus.Name = "cbAsiakasIdVaraus";
            this.cbAsiakasIdVaraus.Size = new System.Drawing.Size(200, 21);
            this.cbAsiakasIdVaraus.Sorted = true;
            this.cbAsiakasIdVaraus.TabIndex = 1;
            // 
            // lblVaraukset
            // 
            this.lblVaraukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaraukset.Location = new System.Drawing.Point(20, 16);
            this.lblVaraukset.Name = "lblVaraukset";
            this.lblVaraukset.Size = new System.Drawing.Size(221, 139);
            this.lblVaraukset.TabIndex = 32;
            this.lblVaraukset.Text = "Varaukset";
            this.lblVaraukset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnTakaisinVaraus
            // 
            this.btnTakaisinVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakaisinVaraus.Location = new System.Drawing.Point(707, 16);
            this.btnTakaisinVaraus.Name = "btnTakaisinVaraus";
            this.btnTakaisinVaraus.Size = new System.Drawing.Size(123, 51);
            this.btnTakaisinVaraus.TabIndex = 31;
            this.btnTakaisinVaraus.Text = "Takaisin asiakashallintaan";
            this.btnTakaisinVaraus.UseVisualStyleBackColor = true;
            this.btnTakaisinVaraus.Visible = false;
            this.btnTakaisinVaraus.Click += new System.EventHandler(this.btnTakaisinVaraus_Click);
            // 
            // dgVaraukset
            // 
            this.dgVaraukset.AllowUserToAddRows = false;
            this.dgVaraukset.AllowUserToDeleteRows = false;
            this.dgVaraukset.AllowUserToResizeColumns = false;
            this.dgVaraukset.AllowUserToResizeRows = false;
            this.dgVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVaraukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaraukset.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgVaraukset.Location = new System.Drawing.Point(270, 86);
            this.dgVaraukset.MultiSelect = false;
            this.dgVaraukset.Name = "dgVaraukset";
            this.dgVaraukset.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgVaraukset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVaraukset.Size = new System.Drawing.Size(560, 480);
            this.dgVaraukset.TabIndex = 18;
            // 
            // tabLaskutus
            // 
            this.tabLaskutus.BackColor = System.Drawing.Color.Linen;
            this.tabLaskutus.Controls.Add(this.btnTulostalasku);
            this.tabLaskutus.Controls.Add(this.dgLaskut);
            this.tabLaskutus.Controls.Add(this.btnLahetalasku);
            this.tabLaskutus.Location = new System.Drawing.Point(4, 22);
            this.tabLaskutus.Name = "tabLaskutus";
            this.tabLaskutus.Size = new System.Drawing.Size(852, 584);
            this.tabLaskutus.TabIndex = 4;
            this.tabLaskutus.Text = "Laskutus";
            this.tabLaskutus.Enter += new System.EventHandler(this.tabLaskutus_Enter);
            // 
            // dgLaskut
            // 
            this.dgLaskut.AllowUserToAddRows = false;
            this.dgLaskut.AllowUserToDeleteRows = false;
            this.dgLaskut.AllowUserToResizeColumns = false;
            this.dgLaskut.AllowUserToResizeRows = false;
            this.dgLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLaskut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLaskut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgLaskut.Location = new System.Drawing.Point(3, 3);
            this.dgLaskut.MultiSelect = false;
            this.dgLaskut.Name = "dgLaskut";
            this.dgLaskut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgLaskut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLaskut.Size = new System.Drawing.Size(846, 480);
            this.dgLaskut.TabIndex = 17;
            // 
            // btnLahetalasku
            // 
            this.btnLahetalasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLahetalasku.Location = new System.Drawing.Point(8, 489);
            this.btnLahetalasku.Name = "btnLahetalasku";
            this.btnLahetalasku.Size = new System.Drawing.Size(176, 87);
            this.btnLahetalasku.TabIndex = 0;
            this.btnLahetalasku.Text = "Lähetä lasku";
            this.btnLahetalasku.UseVisualStyleBackColor = true;
            this.btnLahetalasku.Click += new System.EventHandler(this.btnJoonas_Click);
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
            // btnTulostalasku
            // 
            this.btnTulostalasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTulostalasku.Location = new System.Drawing.Point(668, 489);
            this.btnTulostalasku.Name = "btnTulostalasku";
            this.btnTulostalasku.Size = new System.Drawing.Size(176, 87);
            this.btnTulostalasku.TabIndex = 18;
            this.btnTulostalasku.Text = "Tulosta lasku";
            this.btnTulostalasku.UseVisualStyleBackColor = true;
            this.btnTulostalasku.Click += new System.EventHandler(this.btnTulostalasku_Click);
            // 
            // Aloitussivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(860, 610);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(650, 545);
            this.Name = "Aloitussivu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Newbies Oy Mökkivarausjärjestelmä";
            this.tabControl.ResumeLayout(false);
            this.tabAloitussivu.ResumeLayout(false);
            this.tabAloitussivu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.tabToimintaalue.ResumeLayout(false);
            this.tabToimintaalue.PerformLayout();
            this.pnlMokit.ResumeLayout(false);
            this.pnlMokit.PerformLayout();
            this.pnlTalueet.ResumeLayout(false);
            this.pnlTalueet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).EndInit();
            this.tabAsiakashallinta.ResumeLayout(false);
            this.tabAsiakashallinta.PerformLayout();
            this.pnlTextboxesAsiakas.ResumeLayout(false);
            this.pnlTextboxesAsiakas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakkaat)).EndInit();
            this.tabVaraushallinta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaraukset)).EndInit();
            this.tabLaskutus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLaskut)).EndInit();
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
        private Panel pnlMokit;
        private Panel pnlTalueet;
        private Label lblToimialueNimi;
        private Button btnTakaisin;
        private Button btnNayta;
        private Button btnLisaaMökki;
        private Label lblToimipisteet;
        private DataGridView dgToimipisteet;
        private TextBox txtVarusteluTA;
        private TextBox txtHloMaaraTA;
        private TextBox txtKuvausTA;
        private TextBox txtKatuosoiteTA;
        private TextBox txtMokinnimiTA;
        private TextBox txtPostinroTA;
        private Label lblVarusteluTA;
        private Label lblHloMaaraTA;
        private Label lblKuvausTA;
        private Label lblKatuosoiteTA;
        private Label lblMokkinimiTA;
        private Label lblPostinroTA;
        private Button btnPoista;
        private Label lblError;
        private DataGridView dgAsiakkaat;
        private Button btnPoistaAsiakas;
        private Panel pnlTextboxesAsiakas;
        private TextBox txtHakuAsiakas;
        private Label lblHakuAsiakas;
        private Button btnLisaaAsiakas;
        private Label lblAsiakkaat;
        private TextBox txtPuhelinAs;
        private Label lblPuhelinAsiakas;
        private TextBox txtEmailAs;
        private Label lblEmailAsiakas;
        private TextBox txtOsoiteAs;
        private Label lblOsoiteAsiakas;
        private TextBox txtSukunimiAs;
        private Label lblSukunimiAsiakas;
        private TextBox txtEtunimiAs;
        private Label lblEtunimiAsiakas;
        private TextBox txtPostinroAs;
        private Label lblPostinroAsiakas;
        private Label lblToimialueennimi;
        private TextBox txtToimialueennimi;
        private DataGridView dgLaskut;
        private Button btnLahetalasku;
        private Button btnNaytaVarauksetAs;
        private DataGridView dgVaraukset;
        private Label lblVaraukset;
        private Button btnTakaisinVaraus;
        private Button btnLisaatoimiP;
        private Button btnPoistaToimialue;
        private Panel panel1;
        private DateTimePicker datePaattyyVaraus;
        private Label lblPaattymisPvmVaraus;
        private DateTimePicker dateAlkaaVaraus;
        private Label lblAlkuPvmVaraus;
        private DateTimePicker dateVarattuVaraus;
        private Label lblVarattuPvVaraus;
        private Label lblMokkiIdVaraus;
        private ComboBox cbMokkiIdVaraus;
        private Label lblAsiakasIdVaraus;
        private ComboBox cbAsiakasIdVaraus;
        private Button btnPoistaVaraus;
        private Button btnLisaaPalveluitaVaraus;
        private Button btnVahvistaVaraus;
        private Button btnLisaaVaraus;
        private Button btnTulostalasku;
    }
}

