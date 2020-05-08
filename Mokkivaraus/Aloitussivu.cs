using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;

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

            lblTitle.Location = new Point(Width / 2 - lblTitle.Width / 2, lblTitle.Location.Y);
            pboxLogo.Location = new Point(Width / 2 - pboxLogo.Width / 2, pboxLogo.Location.Y);
            btnToimintaalue.Location = new Point(Width / 2 - btnToimintaalue.Width / 2, btnToimintaalue.Location.Y);
            btnAsiakkaat.Location = new Point(Width / 2 - btnAsiakkaat.Width / 2, btnAsiakkaat.Location.Y);
            btnVaraukset.Location = new Point(Width / 2 - btnVaraukset.Width / 2, btnVaraukset.Location.Y);
            btnLaskutus.Location = new Point(Width / 2 - btnLaskutus.Width / 2, btnLaskutus.Location.Y);
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

            //takaisin nappi näkyväksi & paneeli 2 auki
            btnTakaisin.Enabled = true;
            btnTakaisin.Visible = true;
            panel2.Visible = true;
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


        }

        //Nappi joka lisää uusia soluja ja/tai muokkaa haluttua
        //Lisää tietoja vähän tyhmästi ATM
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            conn.Open();

            //insert lause 
            string insertQuery = "insert into mokki(toimintaalue_id, postinro, mokkinimi, katuosoite, kuvaus, henkilomaara, varustelu) values (" + ID + ",'" + txtPostinro.Text + "','" + txtMokinnimi.Text + "','"
                + txtKatuosoite.Text + "','" + txtKuvaus.Text + "','" + txtHloMaara.Text + "','" + txtVarustelu.Text + "')";
            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //päivitetään datagrid kyselyllä
            insertSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);

            conn.Close();

        }

        //asetetaan paneelien sijainnit samoiksi, piilotetaan takaisin-nappi sekä 2. paneeli 
        private void Toimintaalueet_Load(object sender, EventArgs e)
        {
            panel2.Location = panel1.Location;
            btnTakaisin.Visible = false;
            btnTakaisin.Enabled = false;
            panel2.Visible = false;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //Poistaa valitun rivin tietokannasta, ei päivitä vielä datagridia
            conn.Open();

            string deletequery = "DELETE from mokki WHERE mokki_id=" + dgToimipisteet.SelectedRows[0].Cells[0].Value;
            SQLiteCommand deleteSQL = new SQLiteCommand(deletequery, conn);

            deleteSQL.ExecuteNonQuery();

        }

        #endregion

        #region Asiakashallinta
        private void tabControl_Enter(object sender, EventArgs e)
        {
            string query = "SELECT * from asiakas";
            dgAsiakkaat = dataGridUpdate(query, dgAsiakkaat);
        }

        private void txtAsiakasId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))){
                e.Handled = true;
            }
        }




        #endregion

        private void btnJoonas_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Luodaan uusi sähköpostiviesti ja SmtpServer
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.live.com"); //Käytettävän sähköpostin Smtp-osoite

                    mail.From = new MailAddress("xxxxxx@hotmail.com"); //Firman laskutukseen käytettävä sähköpostiosoite
                    mail.To.Add("xxxxxx@gmail.com"); //Vastaanottajan sähköpostiosoite (tähän asiakastietojen datagridistä tieto)
                    mail.Subject = "Village People Oy laskusi"; //Sähköpostin aihe/otsikko
                    mail.Body = "Tässä on laskusi koskien......"; //Itse viesti

                    //Käytettävä kirjautumistunnus sähköpostiin ja sen salasana
                    string mailUser = "xxxxxx@hotmail.com";
                    string mailUserpw = "xxxxxxx";

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
            string query = "SELECT * from asiakas";
            dgLaskutus = dataGridUpdate(query, dgLaskutus);
        }
    }

}
