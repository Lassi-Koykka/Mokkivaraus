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
        //TabControllin koko muuttuu myös ikkunan kokoa muutettaessa
        private void Aloitussivu_Resize(object sender, EventArgs e)
        {
            tabControl.Size = Size;
        }

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
            //yhteys
            SQLiteConnection conn =
                new SQLiteConnection(@"Data Source=.\mokkivarausDB.db; version=3");

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
        }

        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            //yhteys
            SQLiteConnection conn =
                new SQLiteConnection(@"Data Source=.\mokkivarausDB.db; version=3");

            //kysely ja sqlite komento jossa parametreinä kysely ja yhteys
            string query = "SELECT * from toimintaalue";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //datatableen tiedot
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            dgToimipisteet.DataSource = dt;
            adapter.Fill(dt);

            btnTakaisin.Visible = false;
        }

        private void Toimintaalueet_Load(object sender, EventArgs e)
        {
            //asetetaan paneelien sijainnit samoiksi, piilotetaan takaisin-nappi sekä 2. paneeli
            panel2.Location = panel1.Location;
            btnTakaisin.Visible = false;
            btnTakaisin.Enabled = false;
            panel2.Visible = false;
        }
    }

}
