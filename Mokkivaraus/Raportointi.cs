using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivaraus
{
    public partial class Raportointi : Form
    {
        public Raportointi()
        {
            InitializeComponent();
        }

        public static String TaNimi, TaID;

        //Mikäli valitulta väliltä löytyy varaustietoja luo raportin
        private void btnMajoittumisraportti_Click(object sender, EventArgs e)
        {
            //Raportin tiedostosijainti
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                $"/{TaNimi}_Majoittumisraportti{dateMajoittuminenMista.Value.ToString()}-{dateMajoittuminenMihin.Value.ToString()}.pdf";
            
            //Kysely joka hakee täysin aikavälille sijoittuvat varaukset toiminta-alueella
            string query = $"SELECT mokkinimi, mokki_id, date(varattu_pvm), date(vahvistus_pvm), date(varattu_alkupvm), date(varattu_loppupvm), toimintaalue.nimi, mokki.toimintaalue_id " +
                $"FROM varaus " +
                $"INNER JOIN mokki ON mokki_id = mokki_mokki_id " +
                $"INNER JOIN toimintaalue ON toimintaalue.toimintaalue_id = mokki.toimintaalue_id " +
                $"WHERE toimintaalue.toimintaalue_id = '{TaID}' ;" +
                $"AND varattu_alkupvm BETWEEN '{dateMajoittuminenMista.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}' " +
                $"AND '{dateMajoittuminenMihin.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}' " +
                $"AND varattu_loppupvm BETWEEN '{dateMajoittuminenMista.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}' " +
                $"AND '{dateMajoittuminenMihin.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}'";

            Aloitussivu.conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query ,Aloitussivu.conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Yhtään majoitustietoa ei löytynyt.");
                Aloitussivu.conn.Close();
            } else {

                //Luodaan fontit
                var otsikkofont = PdfFontFactory.CreateFont(FontConstants.TIMES_BOLD);
                var font = PdfFontFactory.CreateFont(FontConstants.TIMES_ROMAN);


                //alustetaan tiedoston luontiin muuttujat pdf tiedostoa varten
                PdfWriter writer = new PdfWriter(destination);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                //Lisätään otsikko
                document.Add(new Paragraph($"{TaNimi} Majoittumisraportti").SetFont(otsikkofont).SetFontSize(32).SetTextAlignment(iText.Layout.Properties
                .TextAlignment.CENTER));
                document.Add(new Paragraph());

                //Luodaan taulukko pdf tiedostoon
                Table table = new Table(UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();
                table.SetFont(font).SetFontSize(12);

                table.AddHeaderCell(new Paragraph("Mökin nimi").SetBold());
                table.AddHeaderCell(new Paragraph("Mökin ID").SetBold());
                table.AddHeaderCell(new Paragraph("Varattu").SetBold());
                table.AddHeaderCell(new Paragraph("Varaus vahvistettu").SetBold());
                table.AddHeaderCell(new Paragraph("Varauksen alkamispvm").SetBold());
                table.AddHeaderCell(new Paragraph("Varauksen päättumispvm").SetBold());
                table.AddHeaderCell(new Paragraph("Toiminta-alue").SetBold());
                table.AddHeaderCell(new Paragraph("Toiminta-alueen ID").SetBold());
                table.StartNewRow();



                //Luetaan dataa taulukkoon
                while (reader.Read())
                {
                    table.AddCell(reader.GetValue(0).ToString());
                    table.AddCell(reader.GetValue(1).ToString());
                    table.AddCell(reader.GetValue(2).ToString());
                    table.AddCell(reader.GetValue(3).ToString());
                    table.AddCell(reader.GetValue(4).ToString());
                    table.AddCell(reader.GetValue(5).ToString());
                    table.AddCell(reader.GetValue(6).ToString());
                    table.AddCell(reader.GetValue(7).ToString());

                    table.StartNewRow();
                }

                document.Add(table);

                //Suljetaan yhteys ja tiedosto
                Aloitussivu.conn.Close();
                document.Close();

                //Avataan pdf
                ProcessStartInfo startInfo = new ProcessStartInfo(destination);
                Process.Start(startInfo);

            }
        }

        //Mikäli valitulta väliltä löytyy varaustietoja luo raportin
        private void btnLisapalveluraportti_Click(object sender, EventArgs e)
        {
            //Raportin tiedostosijainti
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                $"/{TaNimi}_Lisapalveluraportti{dateLisapalvelutMista.Value.ToString()}-{dateLisapalvelutMihin.Value.ToString()}.pdf";

            string query = "SELECT palvelu.palvelu_id as 'Palvelun ID', palvelu.nimi as 'Palvelun nimi', SUM(varauksen_palvelut.lkm) as 'lukumäärä', palvelu.hinta*varauksen_palvelut.lkm as 'Hinta €',  palvelu.hinta*varauksen_palvelut.lkm*1.24 as 'Hinta €+ alv' " +
                $"FROM varauksen_palvelut " +
                $"INNER JOIN varaus ON varauksen_palvelut.varaus_id = varaus.varaus_id " +
                $"INNER JOIN mokki ON  mokki_mokki_id = mokki.mokki_id INNER JOIN toimintaalue ON mokki.toimintaalue_id = toimintaalue.toimintaalue_id " +
                $"INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id " +
                $"WHERE toimintaalue.toimintaalue_id = '{TaID}' " +
                $"AND varattu_alkupvm BETWEEN '{dateLisapalvelutMista.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}' " +
                $"AND '{dateLisapalvelutMihin.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}' " +
                $"AND varattu_loppupvm BETWEEN '{dateLisapalvelutMista.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}' " +
                $"AND '{dateLisapalvelutMihin.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}'" +
                $" GROUP BY varauksen_palvelut.palvelu_id;";

            Aloitussivu.conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, Aloitussivu.conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Yhtään lisäpalvelun myyntitietoa ei löytynyt.");
                Aloitussivu.conn.Close();
            }
            else
            {
                //Luodaan fontit
                var otsikkofont = PdfFontFactory.CreateFont(FontConstants.TIMES_BOLD);
                var font = PdfFontFactory.CreateFont(FontConstants.TIMES_ROMAN);

                //alustetaan tiedoston luontiin muuttujat pdf tiedostoa varten
                PdfWriter writer = new PdfWriter(destination);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                //Lisätään otsikko
                document.Add(new Paragraph($"{TaNimi} Lisapalveluiden myyntiraportti").SetFont(otsikkofont).SetFontSize(32).SetTextAlignment(iText.Layout.Properties
                .TextAlignment.CENTER));
                document.Add(new Paragraph());

                //Luodaan taulukko pdf tiedostoon
                Table table = new Table(UnitValue.CreatePercentArray(5)).UseAllAvailableWidth();
                table.SetFont(font).SetFontSize(12);

                table.AddHeaderCell(new Paragraph("Palvelun ID").SetBold());
                table.AddHeaderCell(new Paragraph("Palvelun nimi").SetBold());
                table.AddHeaderCell(new Paragraph("Lukumäärä").SetBold());
                table.AddHeaderCell(new Paragraph("Hinta €").SetBold());
                table.AddHeaderCell(new Paragraph("Hinta + alv €").SetBold());

                table.StartNewRow();



                //Luetaan dataa taulukkoon
                while (reader.Read())
                {
                    table.AddCell(reader.GetValue(0).ToString());
                    table.AddCell(reader.GetValue(1).ToString());
                    table.AddCell(reader.GetValue(2).ToString());
                    table.AddCell(reader.GetValue(3).ToString());
                    table.AddCell(reader.GetValue(4).ToString());

                    table.StartNewRow();
                }

                document.Add(table);

                //Suljetaan yhteys ja tiedosto
                Aloitussivu.conn.Close();
                document.Close();

                //Avataan pdf
                ProcessStartInfo startInfo = new ProcessStartInfo(destination);
                Process.Start(startInfo);

            }
        }


        //varmistetaan, että raportin "Mihin" date ei ole vähemmäin kuin "Mista" päivämäärä
        private void dateMajoittuminenMista_ValueChanged(object sender, EventArgs e)
        {
            dateMajoittuminenMihin.MinDate = dateMajoittuminenMista.Value.AddDays(1);
        }

        private void dateLisapalvelutMista_ValueChanged(object sender, EventArgs e)
        {
            dateLisapalvelutMihin.MinDate = dateLisapalvelutMista.Value.AddDays(1);
        }

        private void Raportointi_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        //Asetetaan datejen rajat ja lisätään tekstiin toiminta-alueen nimi
        private void Raportointi_Load(object sender, EventArgs e)
        {
            lblRaportointi.Text = TaNimi + " raportointi";

            dateMajoittuminenMista.MaxDate = DateTime.Now.AddDays(-1);
            dateMajoittuminenMihin.MaxDate = DateTime.Now;

            dateLisapalvelutMista.MaxDate = DateTime.Now.AddDays(-1);
            dateLisapalvelutMihin.MaxDate = DateTime.Now;


        }
    }
}
