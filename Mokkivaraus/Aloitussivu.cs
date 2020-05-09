﻿using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
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
        int ID;


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
        }

        #region tietokantayhteys ja formin päivitys kyselyiden perusteella
        //Yhteys tietokantaan ja datatablen luonti
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\mokkivarausDB.db; version=3");

        //Tekee kyselyn tietokantaan ja palauttaa uuden dataGridin joka on muokattu kyselyn pohjalta
        private DataGridView dataGridUpdate(String query, DataGridView dg)
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
            dgToimipisteet = dataGridUpdate(query, dgAsiakkaat);
        }

        private void btnVaraukset_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabVaraushallinta;
        }

        private void btnLaskutus_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabLaskutus;
        }
        #endregion



        #region Toiminta-alueiden hallinta
        //Päivitetään kyselyllä datagrid kun käyttäjä siirtyy toiminta-alue välilehteen
        private void tabToimintaalue_Enter(object sender, EventArgs e)
        {
            //dataGridin päivitys kyselyn pohjalta
            string query = "SELECT * from toimintaalue";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);

            Toimintaalueet_Load(sender, e);

        }

        //Näyttää valitun toimialueen mökit
        private void btnNayta_Click(object sender, EventArgs e)
        {
            toimintaalueID = dgToimipisteet.SelectedRows[0].Cells[0].Value + string.Empty;
            int.TryParse(toimintaalueID, out ID);

            tabToimintaalue.Controls.Add(dgMokit);
            //Uusi datagridview
            dgToimipisteet.Visible = false;
            dgMokit.Location = dgToimipisteet.Location;
            dgMokit.Size = dgToimipisteet.Size;
            dgMokit.Visible = true;
            //KAATUU JOSTAIN SYYSTÄ TÄHÄN JOS NÄYTÄ NAPPIA PAINETAAN UUDESTAAN 7.5.2020
            //

            tabToimintaalue.Controls.Add(dgMokit);
            //dataGridin täyttö mökkien tiedoilla
            string query = "SELECT * from mokki";
            dgMokit = dataGridUpdate(query, dgMokit);

            // napit käytettäviksi & paneeli 2 auki
            btnTakaisin.Enabled = true;
            btnTakaisin.Visible = true;
            btnPoista.Enabled = true;
            panel2.Visible = true;

            lblToimipisteet.Text = "Mökit";
        }

        //Siirrytään takaisin toiminta-alueisiin
        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            //dataGridin päivitys kyselyn pohjalta
            string query = "SELECT * from toimintaalue";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);
            dgMokit.Visible = false;
            dgToimipisteet.Visible = true;
            btnTakaisin.Visible = false;
            panel2.Visible = false;
            btnPoista.Enabled = false;

            lblToimipisteet.Text = "Toiminta-alueet";
        }

        //Nappi joka lisää uusia soluja ja/tai muokkaa haluttua
        //Lisää tietoja vähän tyhmästi ATM
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            conn.Open();

            //insert lause 
            string insertQuery = "insert into mokki(postinro, mokkinimi, katuosoite, kuvaus, henkilomaara, varustelu) values (" + txtPostinroTA.Text + "','" + txtMokinnimiTA.Text + "','"
                + txtKatuosoiteTA.Text + "','" + txtKuvausTA.Text + "','" + txtHloMaaraTA.Text + "','" + txtVarusteluTA.Text + "')";
            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //päivitetään datagrid kyselyllä
            insertSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";
            dgMokit = dataGridUpdate(query, dgMokit);

            conn.Close();

        }

        //asetetaan paneelien sijainnit samoiksi, piilotetaan takaisin-nappi sekä 2. paneeli 
        private void Toimintaalueet_Load(object sender, EventArgs e)
        {
            panel2.Location = panel1.Location;
            btnTakaisin.Visible = false;
            btnTakaisin.Enabled = false;
            panel2.Visible = false;
            btnPoista.Enabled = false;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //Poistaa valitun rivin tietokannasta
            conn.Open();

            string deletequery = "DELETE from mokki WHERE mokki_id=" + dgMokit.SelectedRows[0].Cells[0].Value;
            SQLiteCommand deleteSQL = new SQLiteCommand(deletequery, conn);

            deleteSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";
            dgMokit = dataGridUpdate(query, dgMokit);
            conn.Close();
        }

        #endregion

        #region Asiakashallinta

        //Täysi kyselyString
        string asiakasQuery;
        private void tabControl_Enter(object sender, EventArgs e)
        {
            asiakasQuery = "SELECT * from asiakas";
            dgAsiakkaat = dataGridUpdate(asiakasQuery, dgAsiakkaat);
        }

        private void txtAsiakasId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) && (e.KeyChar == ' '))){
                e.Handled = true;
            }
        }

        private void txtHakuAs_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "") {
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
                } catch
                {
                    asiakasQuery = "SELECT * from asiakas";
                    dgAsiakkaat = dataGridUpdate(asiakasQuery, dgAsiakkaat);
                }
            } else
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
        #endregion

        #region Laskutus
        private void btnJoonas_Click(object sender, EventArgs e)
        {
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
                    
                    //Lisätään dokumenttiin tekstit ja kuvat plus keskitys
                    document.Add(new Paragraph("Village people OY laskusi").SetFont(otsikkofont).SetFontSize(40).SetTextAlignment(iText.Layout.Properties
                        .TextAlignment.CENTER));        
                    iText.Layout.Element.Image logo1 = new iText.Layout.Element.Image(ImageDataFactory.Create("../../Resources/logo.png"));
                    document.Add(logo1.SetHeight(300).SetWidth(300).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));
                    document.Close();

                    //Luodaan uusi sähköpostiviesti ja SmtpServer
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); //Käytettävän sähköpostin Smtp-osoite

                    mail.From = new MailAddress("villagepeopleoy.laskutus@gmail.com"); //Firman laskutukseen käytettävä sähköpostiosoite
                    mail.To.Add("lassi_koykka@hotmail.com"); //Vastaanottajan sähköpostiosoite (tähän asiakastietojen datagridistä tieto)
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

        
    }

}
