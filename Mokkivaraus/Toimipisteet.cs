using System;
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
    public partial class Toimipisteet : Form
    {
        public Toimipisteet()
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

    }
}
