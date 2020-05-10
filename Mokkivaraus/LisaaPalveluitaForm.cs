using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivaraus
{
    public partial class LisaaPalveluitaForm : Form
    {
        public LisaaPalveluitaForm()
        {
            InitializeComponent();
            string query = "SELECT palvelu_id, nimi FROM palvelu";
            DataTable dt = Aloitussivu.createDataTable(query);
            cbVarausPalvelu.DataSource = dt;
            cbVarausPalvelu.DisplayMember = "nimi";
            cbVarausPalvelu.ValueMember = "palvelu_id";
        }

        public static string varausId;

        private void LisaaPalveluitaForm_Load(object sender, EventArgs e)
        {
            lblLisaaPalveluita.Text = $"Varauksen {varausId} palvelut"; 
            string VarausPalvelutQuery = "SELECT * from varauksen_palvelut WHERE varaus_id=" + varausId;
            dgVarauksenPalvelut = Aloitussivu.dataGridUpdate(VarausPalvelutQuery, dgVarauksenPalvelut);

            //Päivitetään palvelu combobox
            string query = "SELECT palvelu_id, nimi FROM palvelu";
            DataTable dt = Aloitussivu.createDataTable(query);
            cbVarausPalvelu.DataSource = dt;
            cbVarausPalvelu.DisplayMember = "nimi";
            cbVarausPalvelu.ValueMember = "palvelu_id";
            

            //kysely ja sqlite komento jossa parametreinä kysely ja yhteys


        }

        private void txtPostinroAs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) && (e.KeyChar == ' ')))
            {
                e.Handled = true;
            }
        }

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            try
            {
                //Lisää varauksen ID:llä palveluita
                if (txtPalveluLkm.Text != "")
                {

                    string insertQuery = $"INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm) VALUES({varausId}, {cbVarausPalvelu.SelectedValue}, {txtPalveluLkm.Text})";
                    Aloitussivu.modifyDatabaseAndGrid(insertQuery, "SELECT * FROM varauksen_palvelut WHERE varaus_id=" + varausId, dgVarauksenPalvelut);
                }
                else
                {
                    MessageBox.Show("Et antanut lukumäärää");
                    txtPalveluLkm.Focus();
                }
            } catch
            {
                MessageBox.Show("Varauksella ei voi olla useampaa merkintää samasta palvelusta");
            }
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            if(dgVarauksenPalvelut.Rows.Count > 0)
            {
                //Poistaa palveluita
                string deleteQuery = $"DELETE FROM varauksen_palvelut WHERE varaus_id = {varausId} AND palvelu_id = {dgVarauksenPalvelut.SelectedRows[0].Cells[0].Value} AND lkm={dgVarauksenPalvelut.SelectedRows[0].Cells[2].Value}";
                Aloitussivu.modifyDatabaseAndGrid(deleteQuery, "SELECT * FROM varauksen_palvelut WHERE varaus_id=" + varausId, dgVarauksenPalvelut);
            }
            
        }
    }
}
