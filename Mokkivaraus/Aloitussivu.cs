﻿using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Annot;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace Mokkivaraus
{
    public partial class Aloitussivu : Form
    {
        //Datagridi mökkien tiedoille
        DataGridView dgMokit = new DataGridView();
        string toimintaalueID;


        public Aloitussivu()
        {
            InitializeComponent();

            //Keskitetään kaikki etusivun kontrollit

            lblTitle.Location = new System.Drawing.Point(Width / 2 - lblTitle.Width / 2, lblTitle.Location.Y);
            pboxLogo.Location = new System.Drawing.Point(Width / 2 - pboxLogo.Width / 2, pboxLogo.Location.Y);
            btnToimintaalue.Location = new System.Drawing.Point(Width / 2 - btnToimintaalue.Width / 2, btnToimintaalue.Location.Y);
            btnAsiakkaat.Location = new System.Drawing.Point(Width / 2 - btnAsiakkaat.Width / 2, btnAsiakkaat.Location.Y);
            btnVaraukset.Location = new System.Drawing.Point(Width / 2 - btnVaraukset.Width / 2, btnVaraukset.Location.Y);
            btnLaskutus.Location = new System.Drawing.Point(Width / 2 - btnLaskutus.Width / 2, btnLaskutus.Location.Y);

            //Toimintaalueen nappien sijainnit
            btnPoistaToimialue.Location = btnPoista.Location;
            btnLisaaMökki.Location = btnLisaatoimiP.Location;

        }

        #region tietokantayhteys ja formin päivitys kyselyiden perusteella
        //Yhteys tietokantaan ja datatablen luonti
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\mokkivarausDB.db; version=3");

        //Tekee kyselyn tietokantaan ja palauttaa uuden dataGridin joka on muokattu kyselyn pohjalta
        private DataGridView dataGridUpdate(String query, DataGridView dg)
        {
            try
            {
                //Alustetaan uusi datatable
                DataTable dt = new DataTable();

                //kysely ja sqlite komento jossa parametreinä kysely ja yhteys
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                //datatableen tiedot
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                dg.DataSource = dt;

                adapter.Fill(dt);
                return dg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tietojen hakemisessa tapahtui virhe: \n" + ex.Message);
                return dg;
            }
        }

        #endregion

        #region Etusivun nappien toiminta
        //Napin klikkaus event handlerit vaihtavat aktiivista Tabia
        private void btnToimintaalue_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabToimintaalue;
            string query = "SELECT * from toimintaalue";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);
        }

        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabAsiakashallinta;
            string query = "SELECT * from asiakas";
            dgAsiakkaat = dataGridUpdate(query, dgAsiakkaat);
        }

        private void btnVaraukset_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabVaraushallinta;
            string query = "SELECT * from varaus";
            dgVaraukset = dataGridUpdate(query, dgVaraukset);
        }

        private void btnLaskutus_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabLaskutus;
            string query = "SELECT * from lasku";
            dgLaskut = dataGridUpdate(query, dgLaskut);
        }
        #endregion

        #region Toiminta-alueiden hallinta
        //Päivitetään kyselyllä datagrid kun käyttäjä siirtyy toiminta-alue välilehteen
        private void tabToimintaalue_Enter(object sender, EventArgs e)
        {
            //dataGridin päivitys kyselyn pohjalta
            string query = "SELECT * from toimintaalue";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);

            dgMokit.Visible = false;
            dgToimipisteet.Visible = true;
            btnTakaisin.Visible = false;
            pnlMokit.Visible = false;
            btnPoista.Visible = false;

            lblToimipisteet.Text = "Toiminta-alueet";

            Toimintaalueet_Load(sender, e);

        }

        //Näyttää valitun toimialueen mökit
        private void btnNayta_Click(object sender, EventArgs e)
        {
            toimintaalueID = dgToimipisteet.SelectedRows[0].Cells[0].Value.ToString();

            tabToimintaalue.Controls.Add(dgMokit);
            //Uusi datagridview
            dgToimipisteet.Visible = false;
            dgMokit.Location = dgToimipisteet.Location;
            dgMokit.Size = dgToimipisteet.Size;
            dgMokit.Visible = true;
            //

            tabToimintaalue.Controls.Add(dgMokit);
            //dataGridin täyttö mökkien tiedoilla
            string query = "SELECT * from mokki WHERE toimintaalue_id=" + toimintaalueID;
            dgMokit = dataGridUpdate(query, dgMokit);

            // napit käytettäviksi & paneeli 2 auki
            btnTakaisin.Enabled = true;
            btnTakaisin.Visible = true;
            btnPoista.Enabled = true;
            pnlMokit.Visible = true;
            btnLisaaMökki.Visible = true;
            btnLisaaMökki.Enabled = true;
            btnLisaatoimiP.Visible = false;

            lblToimipisteet.Text = "Mökit";
        }

        //Siirrytään takaisin toiminta-alueisiin
        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            //dataGridin päivitys kyselyn pohjalta
            string query = "SELECT * from toimintaalue";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);

            //datagridin vaihto ja nappien vaihto
            dgMokit.Visible = false;
            dgToimipisteet.Visible = true;
            btnTakaisin.Visible = false;
            pnlMokit.Visible = false;
            btnPoista.Visible = false;
            btnPoistaToimialue.Visible = true;
            btnLisaaMökki.Visible = false;
            btnLisaatoimiP.Visible = true;

            lblToimipisteet.Text = "Toiminta-alueet";
        }

        //Nappi joka lisää uusia soluja mökkeihin
        //
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in pnlMokit.Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty oikein.");
                    return;
                }
            }

            conn.Open();

            //insert lause 
            string insertQuery = "insert into mokki(toimintaalue_id, postinro, mokkinimi, katuosoite, kuvaus, henkilomaara, varustelu) values (" + toimintaalueID + ",'" + txtPostinroTA.Text + "','" + txtMokinnimiTA.Text + "','"
                + txtKatuosoiteTA.Text + "','" + txtKuvausTA.Text + "','" + txtHloMaaraTA.Text + "','" + txtVarusteluTA.Text + "')";
            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //päivitetään datagrid kyselyllä
            insertSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";
            dgMokit = dataGridUpdate(query, dgMokit);

            conn.Close();

        }
        //Nappi joka lisää uusia soluja toimintaalueisiin
        //
        private void btnLisaatoimiP_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in pnlTalueet.Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty oikein.");
                    return;
                }
            }

            conn.Open();

            //insert lause 
            string insertQuery = "insert into toimintaalue(nimi) values (" + "'" + txtToimialueennimi.Text + "')";
            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //päivitetään datagrid kyselyllä
            insertSQL.ExecuteNonQuery();

            string query = "SELECT * from toimintaalue";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);

            conn.Close();
        }

        //asetetaan paneelien sijainnit samoiksi, piilotetaan nappeja sekä 2. paneeli 
        private void Toimintaalueet_Load(object sender, EventArgs e)
        {
            pnlMokit.Location = pnlTalueet.Location;
            btnTakaisin.Visible = false;
            btnTakaisin.Enabled = false;
            pnlMokit.Visible = false;
            btnPoista.Enabled = false;
            btnLisaaMökki.Enabled = false;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //Poistaa valitun rivin tietokannasta (Mökit)
            conn.Open();

            string deletequery = "DELETE from mokki WHERE mokki_id=" + dgMokit.SelectedRows[0].Cells[0].Value;
            SQLiteCommand deleteSQL = new SQLiteCommand(deletequery, conn);

            deleteSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";
            dgMokit = dataGridUpdate(query, dgMokit);
            conn.Close();
        }

        private void btnPoistaToimialue_Click(object sender, EventArgs e)
        {
            //Poistaa valitun rivin tietokannasta (Toiminta-alueet)
            conn.Open();

            string deletequery = "DELETE from toimintaalue WHERE toimintaalue_id=" + dgToimipisteet.SelectedRows[0].Cells[0].Value;
            SQLiteCommand deleteSQL = new SQLiteCommand(deletequery, conn);

            deleteSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);
            conn.Close();
        }

        #endregion

        #region Asiakashallinta

        //Täysi kyselyString
        string asiakasQuery;

        private void tabAsiakashallinta_Enter(object sender, EventArgs e)
        {
            asiakasQuery = "SELECT * from asiakas";
            dgAsiakkaat = dataGridUpdate(asiakasQuery, dgAsiakkaat);
        }

        private void txtAsiakasId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) && (e.KeyChar == ' ')))
            {
                e.Handled = true;
            }
        }

        private void txtHakuAs_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "")
            {
                try
                {
                    asiakasQuery = $"SELECT * from asiakas WHERE " +
                        $"asiakas_id LIKE '%{txt.Text}%' OR " +
                        $"postinro LIKE '%{txt.Text}%' OR " +
                        $"etunimi LIKE '%{txt.Text}%' OR " +
                        $"sukunimi LIKE '%{txt.Text}%' OR " +
                        $"lahiosoite LIKE '%{txt.Text}%' OR " +
                        $"email LIKE '%{txt.Text}%' OR " +
                        $"puhelinnro LIKE '%{txt.Text}%'";
                    dgAsiakkaat = dataGridUpdate(asiakasQuery, dgAsiakkaat);
                }
                catch
                {
                    asiakasQuery = "SELECT * from asiakas";
                    dgAsiakkaat = dataGridUpdate(asiakasQuery, dgAsiakkaat);
                }
            }
            else
            {
                asiakasQuery = "SELECT * from asiakas";
                dgAsiakkaat = dataGridUpdate(asiakasQuery, dgAsiakkaat);
            }
        }

        private void btnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in pnlTextboxesAsiakas.Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty oikein.");
                    return;
                }
            }

            conn.Open();

            string insertQuery = $"INSERT INTO asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) " +
                $"values ('{txtPostinroAs.Text}', '{txtEtunimiAs.Text}', '{txtSukunimiAs.Text}', '{txtOsoiteAs.Text}', '{txtEmailAs.Text}', '{txtPuhelinAs.Text}')";

            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //päivitetään datagrid kyselyllä
            insertSQL.ExecuteNonQuery();

            txtHakuAsiakas.Text = "";

            asiakasQuery = "SELECT * from asiakas";
            dgAsiakkaat = dataGridUpdate(asiakasQuery, dgAsiakkaat);

            conn.Close();
        }

        private void btnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            if (dgAsiakkaat.Rows.Count > 0)
            {
                //Poistaa valitun rivin tietokannasta
                conn.Open();

                string deleteQuery = "DELETE from asiakas WHERE asiakas_id=" + dgAsiakkaat.SelectedRows[0].Cells[0].Value;
                SQLiteCommand deleteSQL = new SQLiteCommand(deleteQuery, conn);

                deleteSQL.ExecuteNonQuery();
                conn.Close();

                string query = "SELECT * from asiakas";
                dgAsiakkaat = dataGridUpdate(query, dgAsiakkaat);
            }
        }

        private void btnNaytaVarauksetAs_Click(object sender, EventArgs e)
        {
            //Etsii valitun asiakkaan varaukset jos hänellä niitä on ja laittaa ne datagridiin.
            if (dgAsiakkaat.Rows.Count > 0)
            {
                string asiakasid = dgAsiakkaat.SelectedRows[0].Cells[0].Value.ToString();
                string asiakkaanVarauksetQuery = "SELECT * from varaus WHERE asiakas_id=" + asiakasid;
                string asiakasKokonimi = dgAsiakkaat.SelectedRows[0].Cells[2].Value + " " + dgAsiakkaat.SelectedRows[0].Cells[3].Value;
                //Etsii asiakas ID Comoboxista valitun asiakkaan ID:n
                cbAsiakasIdVaraus.Text = asiakasid;
                tabControl.SelectedTab = tabVaraushallinta;
                dgVaraukset = dataGridUpdate(asiakkaanVarauksetQuery, dgVaraukset);
                lblVaraukset.Text = $"Asiakkaan\n {asiakasKokonimi} varaukset";

                cbAsiakasIdVaraus.Enabled = false;
                btnTakaisinVaraus.Visible = true;
            }
        }
        #endregion

        #region Varaukset

        string varausQuery;

        private void tabVaraushallinta_Enter(object sender, EventArgs e)
        {
            //Päivitetään varaushallinta kun sivulle mennään
            btnTakaisinVaraus.Visible = false;
            lblVaraukset.Text = "Varaukset";
            varausQuery = "SELECT * from varaus";
            dgVaraukset = dataGridUpdate(varausQuery, dgVaraukset);

            //Alustetaan uusi datatable
            DataTable dt = new DataTable();

            String query = "SELECT asiakas_id FROM asiakas";

            //Täytetään combobox tietokantakyselyllä
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            cbAsiakasIdVaraus.DataSource = dt;
            cbAsiakasIdVaraus.DisplayMember = "asiakas_id";

            dt = new DataTable();

            query = "SELECT * FROM mokki";

            //kysely ja sqlite komento jossa parametreinä kysely ja yhteys
            cmd = new SQLiteCommand(query, conn);
            adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            cbMokkiIdVaraus.DataSource = dt;
            cbMokkiIdVaraus.DisplayMember = "mokkinimi";
            cbMokkiIdVaraus.ValueMember = "mokki_id";

            cbAsiakasIdVaraus.Enabled = true;
            dateVarattuVaraus.MaxDate = DateTime.Today;
            dateAlkaaVaraus.MinDate = DateTime.Today;
        }

        private void btnTakaisinVaraus_Click(object sender, EventArgs e)
        {
            btnTakaisinVaraus.Visible = false;
            lblVaraukset.Text = "Varaukset";
            tabControl.SelectedTab = tabAsiakashallinta;
            string query = "SELECT * from asiakas";
            dgAsiakkaat = dataGridUpdate(query, dgAsiakkaat);
        }

        private void dateAlkaaVaraus_ValueChanged(object sender, EventArgs e)
        {
            //Muokkaa minimi maksimipäiviä mitä varaukseen voi merkata
            datePaattyyVaraus.MinDate = dateAlkaaVaraus.Value.AddDays(1);
            datePaattyyVaraus.Value = dateAlkaaVaraus.Value.AddDays(2);
        }

        private void btnLisaaVaraus_Click(object sender, EventArgs e)
        {
            //Lisää varauksen tietokantaan
            conn.Open();

            string insertQuery = $"INSERT INTO varaus(asiakas_id, mokki_mokki_id, varattu_pvm, varattu_alkupvm, varattu_loppupvm) " +
                $"values ('{cbAsiakasIdVaraus.Text}', '{cbMokkiIdVaraus.SelectedValue}', '{dateVarattuVaraus.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}', " +
                $"'{dateAlkaaVaraus.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}', '{datePaattyyVaraus.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}')";

            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //päivitetään datagrid kyselyllä
            insertSQL.ExecuteNonQuery();

            if (cbAsiakasIdVaraus.Enabled = false)
            {
                varausQuery = "SELECT * FROM varaus WHERE asiakas_id=" + cbAsiakasIdVaraus.SelectedItem;
            }
            else
            {
                varausQuery = "SELECT * FROM varaus";
            }
            dgVaraukset = dataGridUpdate(varausQuery, dgVaraukset);
            conn.Close();
            //Jostain syystä nappi Enabled = false kun tiedot on lisätty joten täytyy tehdä tämmöistä kikkailua lopuksi
            Button btn = (Button)sender;
            btn.Enabled = true;
        }

        #endregion

        #region Laskutus
        private void btnJoonas_Click(object sender, EventArgs e)
        {
            if (dgLaskut.Rows.Count > 0)
            {
                try
                {
                    //Päämääräkansio mihin lasku.pdf tallentuu
                    string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/lasku.pdf";

                    //Luodaan uusi PdfWriter ja Document ja määritetään sen koko
                    var writer = new PdfWriter(destination);
                    var pdf = new PdfDocument(writer);
                    var document = new Document(pdf);
                    PageSize ps = PageSize.A4;

                    //Otsikon fontti
                    var otsikkofont = PdfFontFactory.CreateFont(FontConstants.TIMES_BOLD);

                    var font = PdfFontFactory.CreateFont(FontConstants.TIMES_ROMAN);

                    //Lisätään dokumenttiin tekstit ja kuvat plus keskitys
                    document.Add(new Paragraph("Village people OY laskusi").SetFont(otsikkofont).SetFontSize(40).SetTextAlignment(iText.Layout.Properties
                        .TextAlignment.CENTER));
                    iText.Layout.Element.Image logo1 = new iText.Layout.Element.Image(ImageDataFactory.Create("../../Resources/logo.png"));
                    document.Add(logo1.SetHeight(200).SetWidth(200).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));

                    conn.Open();

                    //Kysely
                    string query_varausID = "SELECT etunimi, sukunimi, email, puhelinnro FROM lasku " +
                        "INNER JOIN varaus on varaus.varaus_id = lasku.varaus_id " +
                        "INNER JOIN asiakas on asiakas.asiakas_id = varaus.asiakas_id " +
                        "WHERE lasku.lasku_id=" + dgLaskut.SelectedRows[0].Cells[0].Value;
                    SQLiteCommand varausnimi_query = new SQLiteCommand(query_varausID, conn);
                    //Tekee kyselyn ja luo siitä lukijan
                    SQLiteDataReader reader = varausnimi_query.ExecuteReader();
                    //Lukija lukee seuraavan rivin. Palauttaa false jos seuraavaa riviä ei ole joten sillä voisi tarkistaa milloin lopettaa.
                    reader.Read();
                    //Lisätään etunimi ja sukunimi käyttämällä reader.GetString(i) jossa i on kolumnin numero
                    document.Add(new Paragraph("Nimi: " + reader.GetString(0) + " " + reader.GetString(1)).SetFont(font).SetFontSize(15));
                    document.Add(new Paragraph("Sähköposti: " + reader.GetString(2)).SetFont(font).SetFontSize(15));
                    document.Add(new Paragraph("puhelinnumero: " + reader.GetString(3)).SetFont(font).SetFontSize(15));

                    conn.Close();
                    document.Close();

                    //Luodaan uusi sähköpostiviesti ja SmtpServer
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); //Käytettävän sähköpostin Smtp-osoite

                    mail.From = new MailAddress("villagepeopleoy.laskutus@gmail.com"); //Firman laskutukseen käytettävä sähköpostiosoite
                    mail.To.Add("jndonze@hotmail.fi"); //Vastaanottajan sähköpostiosoite (tähän asiakastietojen datagridistä tieto)
                    mail.Subject = "Village People Oy laskusi"; //Sähköpostin aihe/otsikko
                    mail.Body = "Liitteenä on laskusi koskien mökkivaraustasi Village People OY:n kautta."; //Itse viesti
                    Attachment pdflasku = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/lasku.pdf");
                    pdflasku.Name = "lasku.pdf";
                    mail.Attachments.Add(pdflasku); //Liitetiedosto

                    //Käytettävä kirjautumistunnus sähköpostiin ja sen salasana
                    string mailUser = "villagepeopleoy.laskutus@gmail.com";
                    string mailUserpw = "mummo1234";

                    //Käytetään kirjautumistunnuksia ja määritetään portti Smtp:lle
                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(mailUser, mailUserpw);
                    SmtpServer.EnableSsl = true;

                    //Lähetetään lasku
                    SmtpServer.Send(mail);
                    MessageBox.Show("Lasku lähetetty!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void tabLaskutus_Enter(object sender, EventArgs e)
        {
            string query = "SELECT * from lasku";
            dgLaskut = dataGridUpdate(query, dgLaskut);
        }


        #endregion


        private void btnPoistaVaraus_Click(object sender, EventArgs e)
        {
            if (dgVaraukset.Rows.Count > 0)
            {
                //Poistaa valitun rivin tietokannasta
                conn.Open();

                string deleteQuery = "DELETE from varaus WHERE varaus_id=" + dgVaraukset.SelectedRows[0].Cells[0].Value;
                SQLiteCommand deleteSQL = new SQLiteCommand(deleteQuery, conn);

                deleteSQL.ExecuteNonQuery();
                conn.Close();

                string query = "SELECT * from varaus";
                dgVaraukset = dataGridUpdate(query, dgVaraukset);
            }
        }
    }

}
