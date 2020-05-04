﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mokkivaraus
{
    public partial class Toimintaalueet : Form
    {
        public Toimintaalueet()
        {
            InitializeComponent();

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
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //
            //Nappi joka lisää uusia soluja ja/tai muokkaa haluttua
            //EI TÄLLÄ HETKELLÄ KÄYTÖSSÄ, VAATII MUUTOKSIA
            /*
            //yhteys
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\mokkivarausDB.db; version=3");
            conn.Open();

            //id intiksi
            int toimipisteid = int.Parse(txtToimipID.Text);

            //insert lause 
            string insertQuery = "insert into mokki(toimintaalue_id, mokkinimi, katuosoite, postinro) values(" + toimipisteid + ",'" + txtToimipNimi.Text + "','" + txtToimipOsoite.Text + "','" + txtToimipPosti.Text + "')";
            SQLiteCommand insertSQL = new SQLiteCommand(insertQuery, conn);

            //kyselyn ajo
            insertSQL.ExecuteNonQuery();

            string query = "SELECT * from mokki";

            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            dgToimipisteet.DataSource = dt;
            adapter.Fill(dt);

            conn.Close();*/

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

        private void Toimipisteet_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Avataan aloitussivu uudestaan
            this.Hide();
            Aloitussivu aloitussivu = new Aloitussivu();
            aloitussivu.BackColor = BackColor;
            aloitussivu.ShowDialog();
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