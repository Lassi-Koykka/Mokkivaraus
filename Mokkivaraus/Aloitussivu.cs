using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivaraus
{
    public partial class Aloitussivu : Form
    {

        //Yhteys tietokantaan
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\mokkivarausDB.db; version=3");

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
        #region Etusivun nappien toiminta
        //Napin klikkaus event handlerit vaihtavat aktiivista Tabia
        private void btnToimintaalue_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabToimintaalue;
        }

        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabAsiakashallinta;
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
        private void tabToimintaalue_Enter(object sender, EventArgs e)
        {
            //kysely ja sqlite komento jossa parametreinä kysely ja yhteys
            string query = "SELECT * from toimintaalue";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //datatableen tiedot
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            dgToimipisteet.DataSource = dt;
            adapter.Fill(dt);

            Toimintaalueet_Load(sender, e);
        }


        private void btnNayta_Click(object sender, EventArgs e)
        {

            //kysely ja sqlite komento jossa parametreinä kysely ja yhteys
            string query = "SELECT * from mokki";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //datatableen tiedot
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            dgToimipisteet.DataSource = dt;
            adapter.Fill(dt);

            //takaisin nappi näkyväksi & paneeli 2 auki
            btnTakaisin.Enabled = true;
            btnTakaisin.Visible = true;
            panel2.Visible = true;

            //Id:t textboxeihin

            string mokkiId = dgToimipisteet.SelectedRows[0].Cells[0].Value + string.Empty;
            string toimiId = dgToimipisteet.SelectedRows[0].Cells[1].Value + string.Empty;

            txtMokkiID.Text = mokkiId;
            txtToimiID.Text = toimiId;
        }

        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            //kysely ja sqlite komento jossa parametreinä kysely ja yhteys
            string query = "SELECT * from toimintaalue";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //datatableen tiedot
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            dgToimipisteet.DataSource = dt;
            adapter.Fill(dt);

            btnTakaisin.Visible = false;
            panel2.Visible = false;
        }
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //Nappi joka lisää uusia soluja ja/tai muokkaa haluttua
            //Lisää tietoja vähän tyhmästi ATM 

            conn.Open();

            //id intiksi
            int toimipisteid = int.Parse(txtToimiID.Text);

            //insert lause 
            string insertQuery = "insert into mokki(toimintaalue_id, postinro, mokkinimi, katuosoite, kuvaus, henkilomaara, varustelu) values (" + txtToimiID.Text + ",'" + txtPostinro.Text + "','" + txtMokinnimi.Text + "','"
                + txtKatuosoite.Text + "','" + txtKuvaus.Text + "','" + txtHloMaara.Text + "','" + txtVarustelu.Text + "')";
            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //kyselyn ajo
            insertSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";

            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            dgToimipisteet.DataSource = dt;
            adapter.Fill(dt);

            conn.Close();

        }

        private void Toimintaalueet_Load(object sender, EventArgs e)
        {
            //asetetaan paneelien sijainnit samoiksi, piilotetaan takaisin-nappi sekä 2. paneeli
            panel2.Location = panel1.Location;
            btnTakaisin.Visible = false;
            btnTakaisin.Enabled = false;
            panel2.Visible = false;
        }

        private void dgToimipisteet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridin tiedot textboxeihin
            
            string mokkiId = dgToimipisteet.SelectedRows[0].Cells[0].Value + string.Empty;
            string toimiId = dgToimipisteet.SelectedRows[0].Cells[1].Value + string.Empty;
            string postinumero = dgToimipisteet.SelectedRows[0].Cells[2].Value + string.Empty;
            string mokinNimi = dgToimipisteet.SelectedRows[0].Cells[3].Value + string.Empty;
            string katuosoite = dgToimipisteet.SelectedRows[0].Cells[4].Value + string.Empty;
            string kuvaus = dgToimipisteet.SelectedRows[0].Cells[5].Value + string.Empty;
            string hloMaara = dgToimipisteet.SelectedRows[0].Cells[6].Value + string.Empty;
            string varustelu = dgToimipisteet.SelectedRows[0].Cells[7].Value + string.Empty;

            txtMokkiID.Text = mokkiId;
            txtToimiID.Text = toimiId;
            txtPostinro.Text = postinumero;
            txtMokinnimi.Text = mokinNimi;
            txtKatuosoite.Text = katuosoite;
            txtKuvaus.Text = kuvaus;
            txtHloMaara.Text = hloMaara;
            txtVarustelu.Text = varustelu;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //Poistaa valitun rivin tietokannasta, ei päivitä vielä datagridia
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\mokkivarausDB.db; version=3");
            conn.Open();

            string deletequery = "DELETE from mokki WHERE mokki_id="+ dgToimipisteet.SelectedRows[0].Cells[0].Value;
            SQLiteCommand deleteSQL = new SQLiteCommand(deletequery, conn);

            deleteSQL.ExecuteNonQuery();


        }
    }

}
