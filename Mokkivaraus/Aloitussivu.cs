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
    public partial class Aloitussivu : Form
    {
        public Aloitussivu()
        {
            InitializeComponent();


            //Keskitetään kaikki etusivun kontrollit
            lblTitle.Location = new Point(Width / 2 - lblTitle.Width / 2, lblTitle.Location.Y);
            pboxLogo.Location = new Point(Width / 2 - pboxLogo.Width / 2, pboxLogo.Location.Y);
            btnToimipisteet.Location = new Point(Width / 2 - btnToimipisteet.Width / 2, btnToimipisteet.Location.Y);
            btnAsiakkaat.Location = new Point(Width / 2 - btnAsiakkaat.Width / 2, btnAsiakkaat.Location.Y);
            btnVaraukset.Location = new Point(Width / 2 - btnVaraukset.Width / 2, btnVaraukset.Location.Y);
            btnLaskutus.Location = new Point(Width / 2 - btnLaskutus.Width / 2, btnLaskutus.Location.Y);

        }

        //Napin klikkaus event handlerit, joka piilottaa nykyisen formin ja avaa toisen
        private void btnToimipiste_Click(object sender, EventArgs e)
        {
            Toimintaalueet frm = new Toimintaalueet();
            frm.Show();
            this.Hide();
        }
    }

}
