﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Mokkivaraus
{
    public partial class Aloitussivu : Form
    {
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
            //dataGridin päivitys kyselyn pohjalta
            string query = "SELECT * from mokki";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);

            //takaisin nappi näkyväksi & paneeli 2 auki
            btnTakaisin.Enabled = true;
            btnTakaisin.Visible = true;
            panel2.Visible = true;

            //Id:t textboxeihin VÄLIAIKAINEN RATKAISU ETTEI KAADU
            try
            {
                if (dgToimipisteet.SelectedRows.Count > 0)
                {
                    string toimiId = dgToimipisteet.SelectedRows[0].Cells[1].Value + string.Empty;
                    string mokkiId = dgToimipisteet.SelectedRows[0].Cells[0].Value + string.Empty;

                    txtMokkiID.Text = mokkiId;
                    txtToimiID.Text = toimiId;
                }
            }
            catch
            {
                lblError.Text = "Mökkitietoja ei löytynyt";
            }
        }

        //Siirrytään takaisin toiminta-alueisiin
        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            //dataGridin päivitys kyselyn pohjalta
            string query = "SELECT * from toimintaalue";
            dgToimipisteet = dataGridUpdate(query, dgToimipisteet);

            btnTakaisin.Visible = false;
            panel2.Visible = false;
        }

        //Nappi joka lisää uusia soluja ja/tai muokkaa haluttua
        //Lisää tietoja vähän tyhmästi ATM
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            conn.Open();

            //id intiksi
            int toimipisteid = int.Parse(txtToimiID.Text);

            //insert lause 
            string insertQuery = "insert into mokki(toimintaalue_id, postinro, mokkinimi, katuosoite, kuvaus, henkilomaara, varustelu) values (" + txtToimiID.Text + ",'" + txtPostinro.Text + "','" + txtMokinnimi.Text + "','"
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
        //VÄLIAIKAINEN RATKAISU ETTEI KAADU
        private void dgToimipisteet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblError.Text = "";

            try {
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
            catch {
                lblError.Text = "Mökkitietoja ei löytynyt";
            };


            
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
    }

}
